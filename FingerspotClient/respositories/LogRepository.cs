using FingerspotClient.models;
using FingerspotClient.services;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
