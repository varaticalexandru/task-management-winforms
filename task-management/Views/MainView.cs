using System;
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
    public partial class MainView : Form, IMainView
    {
        // constructor
        public MainView()
        {
            InitializeComponent();

            AssociateAndRaiseViewEvents();
        }

        // properties (events) 
        public event EventHandler ShowTaskView;
        public event EventHandler ShowTaskAssignmentView;
        public event EventHandler ShowProjectView;
        public event EventHandler ShowCommentView;
        
        
        // methods
        private void AssociateAndRaiseViewEvents()
        {
            tasksButton.Click += delegate { ShowTaskView?.Invoke(this, EventArgs.Empty); };
        }
    }
}
