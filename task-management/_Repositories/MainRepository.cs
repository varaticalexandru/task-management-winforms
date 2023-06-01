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
using System.Xml.Linq;

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

        // add task
        public void AddTask(Models.Task model)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var sql = @"INSERT INTO task (Name, Description, DueDate, Priority, Status, ProjectID) 
                              VALUES (@name, @description, @dueDate, @priority, @status, @projectId)";


                var command = new MySqlCommand(sql, connection);
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = model.Name;
                command.Parameters.Add("@description", MySqlDbType.VarChar).Value = model.Description;
                command.Parameters.Add("@dueDate", MySqlDbType.DateTime).Value = model.DueDate;
                command.Parameters.Add("@priority", MySqlDbType.VarChar).Value = model.Priority;
                command.Parameters.Add("@status", MySqlDbType.VarChar).Value = model.Status;

                // check if project id is null or -1
                if (String.IsNullOrEmpty(model.ProjectId.ToString()) || model.ProjectId == -1)
                    command.Parameters.Add("@projectId", MySqlDbType.Int32).Value = DBNull.Value;
                else
                    command.Parameters.Add("@projectId", MySqlDbType.Int32).Value = model.ProjectId;

                command.ExecuteNonQuery();

            }
        }

        // add project
        public void AddProject(Project model)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var sql = @"INSERT INTO project (Name, Description, StartDate, EndDate) 
                            VALUES (@name, @description, @startDate, @endDate)";


                var command = new MySqlCommand(sql, connection);
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = model.Name;
                command.Parameters.Add("@description", MySqlDbType.VarChar).Value = model.Description;
                command.Parameters.Add("@startDate", MySqlDbType.DateTime).Value = model.StartDate;
                command.Parameters.Add("@endDate", MySqlDbType.DateTime).Value = model.EndDate;

                command.ExecuteNonQuery();

            }
        }


        // delete task
        public void DeleteTask(int id)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var sql = @"DELETE FROM task
                            WHERE TaskID = @id";


                var command = new MySqlCommand(sql, connection);
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

                command.ExecuteNonQuery();

            }
        }

        // delete project
        public void DeleteProject(int id)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var sql = @"DELETE FROM project
                            WHERE ProjectID = @id";


                var command = new MySqlCommand(sql, connection);
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

                command.ExecuteNonQuery();

            }
        }


        // edit task
        public void EditTask(Models.Task model)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var sql = @"UPDATE task
                            SET Name = @name, Description = @description, DueDate = @dueDate, Priority = @priority, Status = @status, ProjectID = @projectID
                            WHERE TaskID = @id";


                var command = new MySqlCommand(sql, connection);
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = model.Name;
                command.Parameters.Add("@description", MySqlDbType.VarChar).Value = model.Description;
                command.Parameters.Add("@dueDate", MySqlDbType.DateTime).Value = model.DueDate;
                command.Parameters.Add("@priority", MySqlDbType.VarChar).Value = model.Priority;
                command.Parameters.Add("@status", MySqlDbType.VarChar).Value = model.Status;
                command.Parameters.Add("@projectId", MySqlDbType.Int32).Value = model.ProjectId;
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = model.Id;

                command.ExecuteNonQuery();

            }
        }

        // edit project
        public void EditProject(Project model)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var sql = @"UPDATE project
                            SET Name = @name, Description = @description, StartDate = @startDate, EndDate = @endDate
                            WHERE ProjectID = @id";


                var command = new MySqlCommand(sql, connection);
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = model.Name;
                command.Parameters.Add("@description", MySqlDbType.VarChar).Value = model.Description;
                command.Parameters.Add("@startDate", MySqlDbType.DateTime).Value = model.StartDate;
                command.Parameters.Add("@endDate", MySqlDbType.DateTime).Value = model.EndDate;
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = model.Id;

                command.ExecuteNonQuery();
            }
        }

        
        // get all projects
        public IEnumerable<Project> GetAllProjects()
        {
            var projectList = new List<Models.Project>();

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var query = "SELECT * FROM project ORDER BY ProjectID DESC";
                var command = new MySqlCommand(query, connection);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // TODO: optimize with yield return
                        var project = new Models.Project();

                        project.Id = reader.IsDBNull(reader.GetOrdinal("ProjectID")) ? -1 : reader.GetInt32("ProjectID");
                        project.Name = reader.IsDBNull(reader.GetOrdinal("Name")) ? null : reader.GetString("Name");
                        project.Description = reader.IsDBNull(reader.GetOrdinal("Description")) ? null : reader.GetString("Description");
                        project.StartDate = reader.IsDBNull(reader.GetOrdinal("StartDate")) ? DateTime.MinValue : reader.GetDateTime("StartDate");
                        project.EndDate = reader.IsDBNull(reader.GetOrdinal("EndDate")) ? DateTime.MinValue : reader.GetDateTime("EndDate");


                        projectList.Add(project);

                    }
                }

            }

            return projectList;
        }
        
        // get all tasks
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
                        task.Name = reader.IsDBNull(reader.GetOrdinal("Name")) ? null : reader.GetString("Name");
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


        // get task by id or name
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

        // get project by id or name
        public IEnumerable<Project> GetByValueProject(string value)
        {
            var projectList = new List<Models.Project>();

            int id = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            String name = value;

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                var query = @"SELECT * FROM project
                            WHERE ProjectID = @id OR Name LIKE CONCAT('%', @name, '%') 
                            ORDER BY ProjectID DESC;";


                var command = new MySqlCommand(query, connection);
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // TODO: optimize with yield return
                        var project = new Models.Project();

                        project.Id = reader.IsDBNull(reader.GetOrdinal("ProjectID")) ? -1 : reader.GetInt32("ProjectID");    // redundant
                        project.Name = reader.IsDBNull(reader.GetOrdinal("Name")) ? "null" : reader.GetString("Name");
                        project.Description = reader.IsDBNull(reader.GetOrdinal("Description")) ? "null" : reader.GetString("Description");
                        project.StartDate = reader.IsDBNull(reader.GetOrdinal("StartDate")) ? DateTime.MinValue : reader.GetDateTime("StartDate");
                        project.EndDate = reader.IsDBNull(reader.GetOrdinal("EndDate")) ? DateTime.MinValue : reader.GetDateTime("EndDate");

                        projectList.Add(project);
                    }
                }

            }

            return projectList;
        }

    }
}
