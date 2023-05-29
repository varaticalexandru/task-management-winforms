using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_management.Models
{
    public interface ITaskRepository
    {
        // methods
        void Add(Task item);
        bool Edit(Task item);
        void Delete(int id);

        IEnumerable<Task> GetAll();
        IEnumerable<Task> GetByValue(String value);
    }
}
