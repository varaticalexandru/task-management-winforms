using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task_management.Models;
using MySql.Data.MySqlClient;

namespace task_management._Repositories
{
    public class TaskRepository : BaseRepository, ITaskRepository
    {

        // constructors
        public TaskRepository(String connectionString)
        {
            this.connectionString = connectionString;
        }


        // methods
        public void Add(Models.Task item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Edit(Models.Task item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Models.Task> GetAll()
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

        public IEnumerable<Models.Task> GetByValue(String value)
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
