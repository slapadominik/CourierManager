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
    public partial class ManageUsersAsAdminForm : Form
    {
        private IRepository<Client> _repository;
        private BindingSource _bindingSource;

        public ManageUsersAsAdminForm()
        {
            InitializeComponent();
            _repository = new ClientRepository(new XMLSerializer<List<Client>>("Users.xml"));
            _bindingSource = new BindingSource();
            _bindingSource.DataSource = _repository.GetAll().MapClientsToViewModel();

            usersGridView.DataSource = _bindingSource;
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            AddEditUserForm addUserForm = new AddEditUserForm(_repository, _bindingSource);
            addUserForm.Show();           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_repository.GetAll().Count > 0)
            {
                int index = usersGridView.CurrentCell.RowIndex;
                _repository.Delete(index);
                RefreshDataSource();
            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (_repository.GetAll().Count > 0)
            {
                int index = usersGridView.CurrentCell.RowIndex;
                Client client = _repository.Get(index);
                AddEditUserForm addUserForm = new AddEditUserForm(_repository, _bindingSource, client, index);
                addUserForm.Show();
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm menuForm = new MenuForm();
            menuForm.Closed += (s, args) => this.Close();
            menuForm.Show();
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {

        }

        private void RefreshDataSource()
        {
            _bindingSource.Clear();
            _bindingSource.DataSource = _repository.GetAll().MapClientsToViewModel();
        }

    }
}
