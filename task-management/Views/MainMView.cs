using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using task_management.Models;
using task_management.Presenters;
using task_management.Views;
using task_management._Repositories;

namespace task_management.Views
{
    public partial class MainMView : MaterialForm
    {
        public MainMView()
        {
            InitializeComponent();

            LoginView.getMaterialSkinManager().AddFormToManage(this);


        }
    }
}
