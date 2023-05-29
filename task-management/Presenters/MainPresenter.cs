using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task_management.Views;
using task_management.Models;
using task_management._Repositories;

namespace task_management.Presenters
{
    public class MainPresenter
    {
        // fields
        private IMainView mainView;
        private readonly String connectionString;


        // constructor
        public MainPresenter(IMainView mainView, string connectionString)
        {
            this.mainView = mainView;
            this.connectionString = connectionString;

            // associate view events with presenter methods
            this.mainView.ShowTaskView += ShowTaskView;

            // TODO: add other view events and methods
        }



        // methods
        private void ShowTaskView(object sender, EventArgs e)
        {
            /*ITaskView taskView = new TaskView();*/    // not Singleton

            ITaskView taskView = TaskView.GetInstance(); // Singleton
            ITaskRepository taskRepository = new TaskRepository(connectionString);

            new TaskPresenter(taskView, taskRepository);
        }
    }
}
