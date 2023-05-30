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
        bool EditTask(Models.Task item);
        void DeleteTask(int id);

        IEnumerable<Models.Task> GetAllTasks();
        IEnumerable<Models.Task> GetByValueTask(String value);
    }
}
