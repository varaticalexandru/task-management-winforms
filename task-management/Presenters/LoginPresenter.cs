using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task_management.Models;
using task_management.Views;
using task_management._Repositories;
using System.Windows.Forms;

namespace task_management.Presenters
{
    public class LoginPresenter
    {
        // fields
        private ILoginView view;
        private String connectionString;


        // constructor
        public LoginPresenter(ILoginView view, String connectionString)
        {
            this.view = view;
            this.connectionString = connectionString;

            // associate view events with presenter methods
            this.view.Login += Login;
            this.view.Register += Register;
            this.view.HideShowPassword += HideShowPassword;
        }



        // methods
        private void Register(object sender, EventArgs e)
        {
            
        }

        private void Login(object sender, EventArgs e)
        {
            ILoginRepository loginRepository = new LoginRepository(connectionString);
            bool? result = loginRepository.Login(this.view.Username, this.view.Password);

            if (result == true)
            {
                MessageBox.Show("Login successful!");
            }
            else
            {
                MessageBox.Show("Login failed!");
            }
        }

        private void HideShowPassword(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

    }
}
