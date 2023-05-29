using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using task_management.Models;

namespace task_management._Repositories
{
    public class LoginRepository : BaseRepository, ILoginRepository
    {
        // constructor
        public LoginRepository(String connectionString)
        {
            this.connectionString = connectionString;
        }


        // methods
        public bool? Login(string username, string password)
        {

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var query = @"SELECT COUNT(*) as cnt
                            FROM user
                            WHERE UserName = @username AND Password = @password
                            ORDER BY UserID DESC";

                var command = new MySqlCommand(query, connection);

                command.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;
                command.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int cnt = reader.IsDBNull(reader.GetOrdinal("cnt")) ? -1 : reader.GetInt32("cnt");
                        return (cnt < 1) ? false : true;

                    }
                }

            }

            return false;
        }

        public bool? Register(string username, string password)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var query = @"INSERT INTO user (UserName, Password)
                            VALUES (@username, @password)";

                var command = new MySqlCommand(query, connection);

                command.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;
                command.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;

                int rowsAffected = command.ExecuteNonQuery();

                return (rowsAffected < 1) ? false : true;
            }

        }


        // methods

    }
}
