using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using task_management.Models;
using task_management.Views;

namespace task_management.Presenters
{
    public class MainPresenter
    {
        // fields
        private IMainView view;
        private IMainRepository repository;
        private BindingSource taskBindingSource;
        private IEnumerable<Models.Task> taskList;

        // constructor
        public MainPresenter(IMainView view, IMainRepository repository)
        {
            this.view = view;
            this.repository = repository;
            this.taskBindingSource = new BindingSource();

            this.taskList = repository.GetAllTasks();
            this.taskBindingSource.DataSource = taskList;  // set data source

            // associate view events with presenter methods
            this.view.SearchEvent += SearchTask;
            this.view.AddNewEvent += AddNewTask;
            this.view.EditEvent += EditTask;
            this.view.DeleteEvent += DeleteTask;
            this.view.SaveEvent += SaveTask;
            this.view.CancelEvent += CancelTask;

            // set tasks binding source
            this.view.SetTaskListBindingSource(taskBindingSource);

            // load task list view
            LoadTaskList();

            // show view
            this.view.Show();
        }


        // methods
        private void LoadTaskList()
        {
            taskList = repository.GetAllTasks();
            taskBindingSource.DataSource = taskList;

        }

        private void SearchTask(object sender, EventArgs e)
        {
            bool emptyValue = String.IsNullOrWhiteSpace(view.SearchValue);
            if (!emptyValue)
            {
                taskList = repository.GetByValueTask(view.SearchValue);
            }
            else
            {
                taskList = repository.GetAllTasks();
            }

            taskBindingSource.DataSource = taskList;
        }

        private void CancelTask(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SaveTask(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteTask(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void EditTask(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddNewTask(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
