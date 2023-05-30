using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_management.Views
{
    public interface IMainView
    {
        // Tasks
        // properties
        int Id { get; set; }
        String Name { get; set; }
        String Description { get; set; }
        DateTime DueDate { get; set; }
        String Priority { get; set; }
        String Status { get; set; }
        int ProjectId { get; set; }

        String SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        String Message { get; set; }

        // events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        // methods
        void SetTaskListBindingSource(BindingSource taskList);
        void Show();
    }
}
