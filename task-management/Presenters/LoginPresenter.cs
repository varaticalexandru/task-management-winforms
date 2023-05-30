using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task_management.Models;
using task_management.Views;
using task_management._Repositories;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MaterialSkin.Controls;

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
            // validate username and password
            if (!validateUsername() || !validatePassword())
                return;

            ILoginRepository loginRepository = new LoginRepository(connectionString);
            bool? result = loginRepository.Register(this.view.Username, this.view.Password);

            if (result == true)
            {
                MessageBox.Show("Register successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Register failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login(object sender, EventArgs e)
        {
            ILoginRepository loginRepository = new LoginRepository(connectionString);
            bool? result = loginRepository.Login(this.view.Username, this.view.Password);

            if (result == true)
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                IMainView mainView = MainView.GetInstance();
                IMainRepository mainRepository = new MainRepository(connectionString);
                new MainPresenter(mainView, mainRepository);

                ((Form)mainView).Show();
                ((Form)this.view).Hide();
            }
            else
            {
                MessageBox.Show("Login failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HideShowPassword(object sender, EventArgs e)
        {
            if (this.view.HideShow)
            {
                this.view.PasswordTextBox.PasswordChar = '\0';
            }
            else
            {
                this.view.PasswordTextBox.PasswordChar = '⚫';
            }
        }

        private bool validateUsername()
        {
            if (this.view.Username.Length < 3)
            {
                MessageBox.Show("Username must be at least 3 characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool validatePassword()
        {
            String pattern = @"^(?=.*[A-Z])(?=.*[!@#$%^&*()-=_+{};:,.<>?]).{8,}$";

            if (this.view.Password.Length < 8 || !Regex.IsMatch(this.view.Password, pattern))
            {
                MessageBox.Show("Password length must be at least 8, it must include at least one uppercase and one special character!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

    }
}
