using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task_management.Models;
using task_management._Repositories;
using task_management.Presenters;
using task_management.Views;
using MySql.Data.MySqlClient;

namespace task_management._Repositories
{
    public class MainRepository : BaseRepository, IMainRepository
    {

        // constructor
        public MainRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }


        // methods
        public void AddTask(Models.Task item)
        {
            throw new NotImplementedException();
        }

        public void DeleteTask(int id)
        {
            throw new NotImplementedException();
        }

        public bool EditTask(Models.Task item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Models.Task> GetAllTasks()
        {
            var taskList = new List<Models.Task>();

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var query = "SELECT * FROM task ORDER BY TaskID DESC";
                var command = new MySqlCommand(query, connection);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // TODO: optimize with yield return
                        var task = new Models.Task();

                        task.Id = reader.IsDBNull(reader.GetOrdinal("TaskID")) ? -1 : reader.GetInt32("TaskID");
                        task.Name = reader.IsDBNull(reader.GetOrdinal("Name")) ? "null" : reader.GetString("Name");
                        task.Description = reader.IsDBNull(reader.GetOrdinal("Description")) ? "null" : reader.GetString("Description");
                        task.DueDate = reader.IsDBNull(reader.GetOrdinal("DueDate")) ? DateTime.MinValue : reader.GetDateTime("DueDate");
                        task.Priority = reader.IsDBNull(reader.GetOrdinal("Priority")) ? "null" : reader.GetString("Priority");
                        task.Status = reader.IsDBNull(reader.GetOrdinal("Status")) ? "null" : reader.GetString("Status");
                        task.ProjectId = reader.IsDBNull(reader.GetOrdinal("ProjectID")) ? -1 : reader.GetInt32("ProjectID");

                        taskList.Add(task);

                    }
                }

            }

            return taskList;
        }

        public IEnumerable<Models.Task> GetByValueTask(string value)
        {
            var taskList = new List<Models.Task>();

            int id = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            String name = value;

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var query = @"SELECT * FROM task
                            WHERE TaskID = @id OR Name LIKE CONCAT('%', @name, '%') 
                            ORDER BY TaskID DESC;";


                var command = new MySqlCommand(query, connection);
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // TODO: optimize with yield return
                        var task = new Models.Task();

                        task.Id = reader.IsDBNull(reader.GetOrdinal("TaskID")) ? -1 : reader.GetInt32("TaskID");    // redundant
                        task.Name = reader.IsDBNull(reader.GetOrdinal("Name")) ? "null" : reader.GetString("Name");
                        task.Description = reader.IsDBNull(reader.GetOrdinal("Description")) ? "null" : reader.GetString("Description");
                        task.DueDate = reader.IsDBNull(reader.GetOrdinal("DueDate")) ? DateTime.MinValue : reader.GetDateTime("DueDate");
                        task.Priority = reader.IsDBNull(reader.GetOrdinal("Priority")) ? "null" : reader.GetString("Priority");
                        task.Status = reader.IsDBNull(reader.GetOrdinal("Status")) ? "null" : reader.GetString("Status");
                        task.ProjectId = reader.IsDBNull(reader.GetOrdinal("ProjectID")) ? -1 : reader.GetInt32("ProjectID");

                        taskList.Add(task);
                    }
                }

            }

            return taskList;
        }
    }
}
