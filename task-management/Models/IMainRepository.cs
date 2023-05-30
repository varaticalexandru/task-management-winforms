using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_management.Models
{
    public interface IMainRepository
    {
        // Tasks
        // methods
        void AddTask(Models.Task item);
        void EditTask(Models.Task item);
        void DeleteTask(int id);

        void AddProject(Models.Project item);
        void EditProject(Models.Project item);
        void DeleteProject(int id);

        IEnumerable<Models.Task> GetAllTasks();
        IEnumerable<Models.Task> GetByValueTask(String value);

        IEnumerable<Models.Project> GetAllProjects();
        IEnumerable<Models.Project> GetByValueProject(String value);
    }
}
