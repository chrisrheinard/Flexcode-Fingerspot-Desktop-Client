using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation; // Untuk Ping

namespace FingerspotClient.services
{
    public class DatabaseService
    {
        private readonly string _connectionString;

        public DatabaseService()
        {
            // Mengambil koneksi dari App.config
            _connectionString = ConfigurationManager.ConnectionStrings["DbBankConn"].ConnectionString;
        }

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(_connectionString);
        }

        // Membuat tabel otomatis jika belum ada
        public void InitializeDatabase()
        {
            using (var conn = GetConnection())
            {
                conn.Open();

                // Kita gabungkan semua query pembuatan tabel dalam satu string
                string query = @"
                    CREATE TABLE IF NOT EXISTS users (
                        id INT AUTO_INCREMENT PRIMARY KEY,
                        username VARCHAR(50) UNIQUE NOT NULL,
                        password VARCHAR(255) NOT NULL,
                        role VARCHAR(20) NOT NULL
                    );

                    CREATE TABLE IF NOT EXISTS devices (
                        id INT AUTO_INCREMENT PRIMARY KEY,
                        name VARCHAR(50) NULL,
                        sn VARCHAR(50) UNIQUE NOT NULL,
                        vc VARCHAR(50) NOT NULL,
                        ac VARCHAR(50) NOT NULL,
                        vkey VARCHAR(50) NOT NULL,
                        created_at DATETIME DEFAULT CURRENT_TIMESTAMP
                    );

                    CREATE TABLE IF NOT EXISTS customers (
                        id INT AUTO_INCREMENT PRIMARY KEY,
                        cbs_id VARCHAR(50) NULL,
                        name VARCHAR(100) NOT NULL,
                        finger_template TEXT,
                        created_at DATETIME DEFAULT CURRENT_TIMESTAMP
                    );

                    CREATE TABLE IF NOT EXISTS customer_images (
                        id INT AUTO_INCREMENT PRIMARY KEY,
                        customer_id INT,
                        image_data LONGBLOB,
                        scan_order INT,
                        created_at DATETIME DEFAULT CURRENT_TIMESTAMP,
                        FOREIGN KEY (customer_id) REFERENCES customers(id) ON DELETE CASCADE
                    );

                    CREATE TABLE IF NOT EXISTS verification_logs (
                        id INT AUTO_INCREMENT PRIMARY KEY,
                        customer_id INT NULL,
                        verified_at DATETIME DEFAULT CURRENT_TIMESTAMP,
                        evidence_image LONGBLOB,
                        user_id INT,
                        pc_name VARCHAR(100),
                        device_id INT,

                        FOREIGN KEY (customer_id) REFERENCES customers(id) ON DELETE SET NULL,
                        FOREIGN KEY (device_id) REFERENCES devices(id) ON DELETE RESTRICT,
                        FOREIGN KEY (user_id) REFERENCES users(id) ON DELETE RESTRICT
                    );";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                }

                // SEEDER: Buat User Admin Default jika tabel kosong
                string checkUserQuery = "SELECT COUNT(*) FROM users";
                using (var cmdCheck = new MySqlCommand(checkUserQuery, conn))
                {
                    int userCount = Convert.ToInt32(cmdCheck.ExecuteScalar());

                    if (userCount == 0)
                    {
                        // Gunakan password hash di dunia nyata, tapi untuk awal kita pakai plain dulu 
                        // atau langsung masukkan hash manual
                        string seedQuery = @"
                    INSERT INTO users (username, password, role) 
                    VALUES ('admin', 'admin123', 'admin');";

                        using (var cmdSeed = new MySqlCommand(seedQuery, conn))
                        {
                            cmdSeed.ExecuteNonQuery();
                        }
                    }
                }
            }
        }

        public string GetServerIp()
        {
            try
            {
                var builder = new MySql.Data.MySqlClient.MySqlConnectionStringBuilder(_connectionString);
                return builder.Server; // Mengambil bagian "192.168.1.200"
            }
            catch
            {
                return "Unknown";
            }
        }

        // Untuk mengecek koneksi internet berkala
        public bool IsServerReachable()
        {
            try
            {
                string serverIp = GetServerIp();

                using (Ping p = new Ping())
                {
                    // Langsung tembak ke IP Server Database kamu
                    PingReply reply = p.Send(serverIp, 1000);
                    return reply.Status == IPStatus.Success;
                }
            }
            catch { return false; }
        }
    }
}
