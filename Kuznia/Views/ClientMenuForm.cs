﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kuznia.Views
{
    public partial class ClientMenuForm : Form
    {
        public ClientMenuForm()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm menuForm = new MenuForm();
            menuForm.Closed += (s, args) => this.Close();
            menuForm.Show();
        }

        private void btnCheckStatusForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClientPackageStatusForm form = new ClientPackageStatusForm();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
    }
}
