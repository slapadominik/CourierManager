using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kuznia.Views;

namespace Kuznia
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLoginForm adminLoginForm = new AdminLoginForm();
            adminLoginForm.Closed += (s, args) => this.Close();
            adminLoginForm.Show();
        }

        private void btnCourier_Click(object sender, EventArgs e)
        {
            this.Hide();
            CourierMenuForm courierMenuForm = new CourierMenuForm();
            courierMenuForm.Closed += (s, args) => this.Close();
            courierMenuForm.Show();

        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClientMenuForm clientMenuForm = new ClientMenuForm();
            clientMenuForm.Closed += (s, args) => this.Close();
            clientMenuForm.Show();
        }

    }
}
