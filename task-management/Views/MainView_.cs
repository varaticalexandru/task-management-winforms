/*using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_management.Views
{
    public partial class MainView_ : Form, IMainView_
    {
        // constructor
        public MainView_()
        {
            InitializeComponent();

            AssociateAndRaiseViewEvents();
        }

        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime DueDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Priority { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Status { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int ProjectId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string SearchValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsEdit { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsSuccessful { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Message { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        // properties (events) 
        public event EventHandler ShowTaskView;
        public event EventHandler ShowTaskAssignmentView;
        public event EventHandler ShowProjectView;
        public event EventHandler ShowCommentView;
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetTaskListBindingSource(BindingSource taskList)
        {
            throw new NotImplementedException();
        }


        // methods
        private void AssociateAndRaiseViewEvents()
        {
            tasksButton.Click += delegate { ShowTaskView?.Invoke(this, EventArgs.Empty); };
        }
    }
}
*/