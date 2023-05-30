using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using task_management.Models;
using task_management.Views;

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
                        /*return (cnt < 1) ? false : true;*/

                        if (cnt < 1)
                        {
                            return false;
                        }
                        else
                        {
                            MainView.setCurrentUserID(getCurrentUserID(username, password));
                            return true;
                        }

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

        // get current user ID
        public int getCurrentUserID(String username, String password)
        {

            int userID = -1;    // default value

            using (var connection = new MySqlConnection(connectionString))
            {
                

                connection.Open();

                var getUserIDQuery = @"SELECT UserID
                                    FROM user
                                    WHERE UserName = @username AND Password = @password
                                    ORDER BY UserID DESC";

                var userCommand = new MySqlCommand(getUserIDQuery, connection);
                userCommand.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;
                userCommand.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;

                using (var userReader = userCommand.ExecuteReader())
                {
                    while (userReader.Read())
                    {
                        userID = userReader.IsDBNull(userReader.GetOrdinal("UserID")) ? -1 : userReader.GetInt32("UserID");
                        break;
                    }
                }

            }

            return userID;  // return -1 if not found

        }
    }
}
