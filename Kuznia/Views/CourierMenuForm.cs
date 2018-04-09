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
    public partial class CourierMenuForm : Form
    {
        public CourierMenuForm()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
            this.Hide();
        }

        private void btnOpenCourierForm_Click(object sender, EventArgs e)
        {
            CourierManagePackageForm courierForm = new CourierManagePackageForm();
            courierForm.Show();
            this.Hide();
        }
    }
}
