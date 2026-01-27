using FingerspotClient.helpers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FingerspotClient.services
{
    internal class AuthService
    {
        private readonly DatabaseService _dbService;

        public AuthService()
        {
            _dbService = new DatabaseService();
        }

        public bool Login(string username, string password)
        {
            using (var conn = _dbService.GetConnection())
            {
                conn.Open();
                string query = "SELECT id, username, role FROM users WHERE username = @user AND password = @pass LIMIT 1";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@user", username);
                    cmd.Parameters.AddWithValue("@pass", password); // Masih plain text sesuai request

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Simpan ke Session
                            UserSession.UserId = reader.GetInt32("id");
                            UserSession.Username = reader.GetString("username");
                            UserSession.Role = reader.GetString("role");
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}
