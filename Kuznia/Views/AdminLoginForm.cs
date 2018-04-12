using Kuznia.Helpers;
using Kuznia.Models;
using Kuznia.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kuznia
{
    public partial class AdminLoginForm : Form
    {

        private ILoginService<Admin> _loginService;

        public AdminLoginForm()
        {
            InitializeComponent();
            _loginService = new AdminLoginService(new XMLSerializer<List<Admin>>("Admins.xml"));
            labelResult.Hide();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Admin admin = CreateAdminFromInputs();
            if (_loginService.Login(admin) == null)
            {
                labelResult.Show();
                labelResult.Text = "Nie udalo sie zalogować";
            }
            else
            {
                this.Hide();
                ManageUsersAsAdminForm form = new ManageUsersAsAdminForm();
                form.Closed += (s, args) => this.Close();
                form.Show();
            }
        }

        private Admin CreateAdminFromInputs()
        {
            return new Admin() { Username = txtboxUsername.Text, Password = txtboxPassword.Text };
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm menuForm = new MenuForm();
            menuForm.Closed += (s, args) => this.Close();
            menuForm.Show();
        }
    }
}
