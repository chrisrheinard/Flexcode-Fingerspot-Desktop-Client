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
    public class CustomerRepository
    {
        private readonly DatabaseService _dbService;

        public CustomerRepository()
        {
            _dbService = new DatabaseService();
        }

        // --- CREATE (Dengan Gambar Sidik Jari) ---
        public bool Create(Customer customer, List<CustomerImage> images)
        {
            using (var conn = _dbService.GetConnection())
            {
                conn.Open();
                using (var tr = conn.BeginTransaction())
                {
                    try
                    {
                        // Insert ke tabel customers
                        string sqlCust = @"INSERT INTO customers (cbs_id, name, finger_template) 
                                           VALUES (@cbs, @name, @template);
                                           SELECT LAST_INSERT_ID();"; // Ambil ID yang baru dibuat

                        int newId;
                        using (var cmd = new MySqlCommand(sqlCust, conn, tr))
                        {
                            cmd.Parameters.AddWithValue("@cbs", customer.CbsId);
                            cmd.Parameters.AddWithValue("@name", customer.Name);
                            cmd.Parameters.AddWithValue("@template", customer.FingerTemplate);
                            newId = Convert.ToInt32(cmd.ExecuteScalar());
                        }

                        // Insert 4 gambar ke tabel customer_images
                        string sqlImg = @"INSERT INTO customer_images (customer_id, image_data, scan_order) 
                                           VALUES (@custId, @img, @order)";

                        foreach (var img in images)
                        {
                            using (var cmdImg = new MySqlCommand(sqlImg, conn, tr))
                            {
                                cmdImg.Parameters.AddWithValue("@custId", newId);
                                cmdImg.Parameters.AddWithValue("@img", img.ImageData);
                                cmdImg.Parameters.AddWithValue("@order", img.ScanOrder);
                                cmdImg.ExecuteNonQuery();
                            }
                        }

                        tr.Commit();
                        return true;
                    }
                    catch (Exception)
                    {
                        tr.Rollback();
                        throw;
                    }
                }
            }
        }

        // --- READ (Ambil Semua Nasabah) ---
        public List<Customer> GetAll()
        {
            var list = new List<Customer>();
            using (var conn = _dbService.GetConnection())
            {
                conn.Open();
                string sql = "SELECT * FROM customers ORDER BY created_at DESC";
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Customer
                            {
                                Id = reader.GetInt32("id"),
                                CbsId = reader.IsDBNull(reader.GetOrdinal("cbs_id")) ? null : reader.GetString("cbs_id"),
                                Name = reader.GetString("name"),
                                FingerTemplate = reader.IsDBNull(reader.GetOrdinal("finger_template")) ? null : reader.GetString("finger_template"),
                                CreatedAt = reader.GetDateTime("created_at")
                            });
                        }
                    }
                }
            }
            return list;
        }

        public bool Update(Customer customer, List<CustomerImage> images = null)
        {
            using (var conn = _dbService.GetConnection())
            {
                conn.Open();
                using (var tr = conn.BeginTransaction())
                {
                    try
                    {
                        // 1. Update data utama nasabah
                        string sqlUpdate = @"UPDATE customers 
                                     SET cbs_id = @cbs, name = @name, finger_template = @template 
                                     WHERE id = @id";

                        using (var cmd = new MySqlCommand(sqlUpdate, conn, tr))
                        {
                            cmd.Parameters.AddWithValue("@cbs", customer.CbsId);
                            cmd.Parameters.AddWithValue("@name", customer.Name);
                            cmd.Parameters.AddWithValue("@template", customer.FingerTemplate);
                            cmd.Parameters.AddWithValue("@id", customer.Id);
                            cmd.ExecuteNonQuery();
                        }

                        // 2. Jika ada gambar baru (registrasi ulang sidik jari)
                        if (images != null && images.Count > 0)
                        {
                            // Hapus gambar lama dulu
                            string sqlDelImg = "DELETE FROM customer_images WHERE customer_id = @custId";
                            using (var cmdDel = new MySqlCommand(sqlDelImg, conn, tr))
                            {
                                cmdDel.Parameters.AddWithValue("@custId", customer.Id);
                                cmdDel.ExecuteNonQuery();
                            }

                            // Masukkan gambar baru
                            string sqlInsImg = @"INSERT INTO customer_images (customer_id, image_data, scan_order) 
                                         VALUES (@custId, @img, @order)";
                            foreach (var img in images)
                            {
                                using (var cmdImg = new MySqlCommand(sqlInsImg, conn, tr))
                                {
                                    cmdImg.Parameters.AddWithValue("@custId", customer.Id);
                                    cmdImg.Parameters.AddWithValue("@img", img.ImageData);
                                    cmdImg.Parameters.AddWithValue("@order", img.ScanOrder);
                                    cmdImg.ExecuteNonQuery();
                                }
                            }
                        }

                        tr.Commit();
                        return true;
                    }
                    catch (Exception)
                    {
                        tr.Rollback();
                        throw;
                    }
                }
            }
        }

        // --- DELETE ---
        public bool Delete(int id)
        {
            using (var conn = _dbService.GetConnection())
            {
                conn.Open();
                // Karena kita pakai ON DELETE CASCADE di database, 
                // data di customer_images akan otomatis ikut terhapus.
                string sql = "DELETE FROM customers WHERE id = @id";
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // --- SEARCH ---
        public List<Customer> Search(string keyword)
        {
            var list = new List<Customer>();
            using (var conn = _dbService.GetConnection())
            {
                conn.Open();
                // Pakai LIKE untuk pencarian partial (sebagian nama)
                string sql = "SELECT * FROM customers WHERE name LIKE @key OR cbs_id LIKE @key";
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@key", "%" + keyword + "%");
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Customer
                            {
                                Id = reader.GetInt32("id"),
                                CbsId = reader.IsDBNull(reader.GetOrdinal("cbs_id")) ? null : reader.GetString("cbs_id"),
                                Name = reader.GetString("name"),
                                FingerTemplate = reader.GetString("finger_template"),
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
