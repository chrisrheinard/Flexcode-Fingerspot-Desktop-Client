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
    public class DeviceRepository
    {
        private readonly DatabaseService _dbService;

        public DeviceRepository()
        {
            _dbService = new DatabaseService();
        }

        public bool Create(Device device)
        {
            using (var conn = _dbService.GetConnection())
            {
                conn.Open();
                // Kita sesuaikan dengan kolom: name, sn, vc, ac, vkey
                string sql = @"INSERT INTO devices (name, sn, vc, ac, vkey) 
                       VALUES (@name, @sn, @vc, @ac, @vkey)";

                try
                {
                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        // Mapping dari object Device ke Parameter Query
                        cmd.Parameters.AddWithValue("@name", device.Name);
                        cmd.Parameters.AddWithValue("@sn", device.SerialNumber);
                        cmd.Parameters.AddWithValue("@vc", device.VerificationCode);
                        cmd.Parameters.AddWithValue("@ac", device.ActivationCode);
                        cmd.Parameters.AddWithValue("@vkey", device.ValidationKey);

                        int result = cmd.ExecuteNonQuery();
                        return result > 0; // Return true jika ada baris yang bertambah
                    }
                }
                catch (Exception ex)
                {
                    // Catat log error jika perlu
                    throw new Exception("Gagal menyimpan device: " + ex.Message);
                }
            }
        }

        public List<Device> GetAll()
        {
            var list = new List<Device>();
            using (var conn = _dbService.GetConnection())
            {
                conn.Open();
                // 1. Pastikan tabelnya benar: 'devices'
                string sql = "SELECT * FROM devices ORDER BY created_at DESC";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Device
                            {
                                Id = reader.GetInt32("id"),
                                // Cek Null safety untuk kolom yang mungkin null
                                Name = reader.IsDBNull(reader.GetOrdinal("name")) ? null : reader.GetString("name"),

                                // 2. Sesuaikan nama kolom di DB (sn, vc, ac, vkey) dengan Properti Class
                                SerialNumber = reader.GetString("sn"),
                                VerificationCode = reader.GetString("vc"),
                                ActivationCode = reader.GetString("ac"),
                                ValidationKey = reader.GetString("vkey"),

                                CreatedAt = reader.GetDateTime("created_at")
                            });
                        }
                    }
                }
            }
            return list;
        }
    }
}
