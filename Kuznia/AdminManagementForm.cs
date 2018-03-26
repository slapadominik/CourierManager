using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kuznia.Helpers;
using Kuznia.Models;
using Kuznia.Repositories;

namespace Kuznia
{
    public partial class AdminManagementForm : Form
    {
        private IClientRepository _repository;
        private BindingSource _bindingSource;

        public AdminManagementForm()
        {
            InitializeComponent();
            _repository = new ClientRepository(new XMLSerializer<List<Client>>("Users.xml"));
            _bindingSource = new BindingSource();
            _bindingSource.DataSource = _repository.GetClients();

            usersGridView.DataSource = _bindingSource;
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm(_repository, _bindingSource);
            addUserForm.Show();           
        }

        
     
    }
}
