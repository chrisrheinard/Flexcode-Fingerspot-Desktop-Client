using FingerspotClient.models;
using FingerspotClient.services;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace FingerspotClient.respositories
{
    public class LogRepository
    {
        private readonly DatabaseService _dbService;

        public LogRepository()
        {
            _dbService = new DatabaseService();
        }

        public bool Create(VerificationLog log)
        {
            using (var conn = _dbService.GetConnection())
            {
                conn.Open();
                // evidence_image biasanya foto hasil capture saat itu (jika ada)
                string sql = @"INSERT INTO verification_logs 
                       (customer_id, user_id, device_id, pc_name, verified_at, evidence_image) 
                       VALUES (@custId, @userId, @devId, @pc, @at, @img)";

                try
                {
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@custId", log.CustomerId);
                        cmd.Parameters.AddWithValue("@userId", log.TellerId);
                        cmd.Parameters.AddWithValue("@devId", log.DeviceId);
                        cmd.Parameters.AddWithValue("@pc", Environment.MachineName); // Otomatis ambil nama PC
                        cmd.Parameters.AddWithValue("@at", DateTime.Now);

                        // Jika tidak ada gambar bukti, isi dengan DBNull
                        cmd.Parameters.AddWithValue("@img", (object)log.EvidenceImage ?? DBNull.Value);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Gagal mencatat log verifikasi: " + ex.Message);
                }
            }
        }

        public List<VerificationLog> GetAll()
        {
            var list = new List<VerificationLog>();
            using (var conn = _dbService.GetConnection())
            {
                conn.Open();
                // Query sakti untuk menggabungkan nama dari tabel lain
                string sql = @"SELECT v.id, c.name as customer_name, u.username as teller_name, 
                              d.name as device_name, v.pc_name, v.verified_at
                       FROM verification_logs v
                       LEFT JOIN customers c ON v.customer_id = c.id
                       LEFT JOIN users u ON v.user_id = u.id
                       LEFT JOIN devices d ON v.device_id = d.id
                       ORDER BY v.verified_at DESC";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new VerificationLog
                            {
                                Id = reader.GetInt32("id"),
                                CustomerName = reader.IsDBNull(reader.GetOrdinal("customer_name")) ? "Nasabah Tidak Ditemukan" : reader.GetString("customer_name"),
                                TellerName = reader.GetString("teller_name"),
                                DeviceName = reader.GetString("device_name"),
                                PcName = reader.GetString("pc_name"),
                                VerifiedAt = reader.GetDateTime("verified_at")
                            });
                        }
                    }
                }
            }
            return list;
        }

        public byte[] GetEvidenceImage(int logId)
        {
            using (var conn = _dbService.GetConnection())
            {
                conn.Open();
                string sql = "SELECT evidence_image FROM verification_logs WHERE id = @id";
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", logId);
                    var result = cmd.ExecuteScalar();
                    return result as byte[];
                }
            }
        }

        // --- SEARCH ---
        public List<VerificationLog> Search(string keyword, DateTime? startDate = null, DateTime? endDate = null)
        {
            var list = new List<VerificationLog>();
            using (var conn = _dbService.GetConnection())
            {
                conn.Open();

                // Perhatikan bagian d.name AS device_name <--- INI KUNCINYA
                string sql = @"
            SELECT 
                l.id, 
                c.name AS customer_name, 
                CONCAT(u.username, ' (', u.role, ')') AS teller_name,
                d.name AS device_name, 
                l.pc_name, 
                l.verified_at
            FROM verification_logs l
            LEFT JOIN customers c ON l.customer_id = c.id
            LEFT JOIN users u ON l.user_id = u.id
            LEFT JOIN devices d ON l.device_id = d.id
            WHERE (c.name LIKE @key OR u.username LIKE @key OR l.pc_name LIKE @key)";

                if (startDate.HasValue && endDate.HasValue)
                {
                    sql += " AND l.verified_at BETWEEN @start AND @end";
                }

                sql += " ORDER BY l.verified_at DESC";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@key", "%" + keyword + "%");
                    if (startDate.HasValue && endDate.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@start", startDate.Value.Date);
                        cmd.Parameters.AddWithValue("@end", endDate.Value.Date.AddDays(1).AddSeconds(-1));
                    }

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new VerificationLog
                            {
                                Id = reader.GetInt32("id"),
                                // Kita pakai nama Alias yang ada di SQL tadi
                                CustomerName = reader.IsDBNull(reader.GetOrdinal("customer_name")) ? "N/A" : reader.GetString("customer_name"),
                                TellerName = reader.IsDBNull(reader.GetOrdinal("teller_name")) ? "N/A" : reader.GetString("teller_name"),
                                DeviceName = reader.IsDBNull(reader.GetOrdinal("device_name")) ? "Unknown Alat" : reader.GetString("device_name"),
                                PcName = reader.IsDBNull(reader.GetOrdinal("pc_name")) ? "Unknown PC" : reader.GetString("pc_name"),
                                VerifiedAt = reader.GetDateTime("verified_at")
                            });
                        }
                    }
                }
            }
            return list;
        }
    }
}
