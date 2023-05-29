using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using task_management.Views;
using task_management.Models;
using task_management._Repositories;
using task_management.Presenters;
using System.Configuration;

namespace task_management
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            String connectionString = ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString;

            /*IMainView mainView = new MainView();
            new MainPresenter(mainView, connectionString);*/

            /*Application.Run((Form) mainView);*/

            ILoginView loginView = new LoginView();
            new LoginPresenter(loginView, connectionString);

            Application.Run((Form)loginView);
        }
    }
}
