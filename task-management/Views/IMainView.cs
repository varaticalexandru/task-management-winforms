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
        String Id { get; set; }
        String Name { get; set; }
        String Description { get; set; }
        String DueDate { get; set; }
        String Priority { get; set; }
        String Status { get; set; }
        String ProjectId { get; set; }

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



        // Projects
        // properties
        String ProjectID { get; set; }
        String ProjectName { get; set; }
        String ProjectDescription { get; set; }
        String StartDate { get; set; }
        String EndDate { get; set; }

        String SearchProjectValue { get; set; }

        // events
        event EventHandler SearchProjectEvent;
        event EventHandler AddNewProjectEvent;
        event EventHandler EditProjectEvent;
        event EventHandler DeleteProjectEvent;
        event EventHandler SaveProjectEvent;
        event EventHandler CancelProjectEvent;

        // methods
        void SetProjectListBindingSource(BindingSource projectList);

    }
}
