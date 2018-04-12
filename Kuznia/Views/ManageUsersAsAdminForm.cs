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
using Kuznia.Services;
using Kuznia.ViewModels;

namespace Kuznia
{
    public partial class ManageUsersAsAdminForm : Form
    {
        private IClientService _clientService;
        private BindingSource _bindingSource;

        public ManageUsersAsAdminForm()
        {
            InitializeComponent();
            _clientService = new ClientService(new ClientRepository(new XMLSerializer<List<Client>>("Users.xml")));
            _bindingSource = new BindingSource();
            _bindingSource.DataSource = _clientService.GetAll().MapClientsToViewModel();

            usersGridView.DataSource = _bindingSource;
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            AddEditUserForm addUserForm = new AddEditUserForm(_clientService, _bindingSource);
            addUserForm.Show();           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_clientService.GetAll().Count > 0)
            {
                ClientViewModel client = (ClientViewModel) usersGridView.CurrentRow.DataBoundItem;
                _clientService.Delete(client.MapClientViewModelToModel());
                RefreshDataSource();
            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (_clientService.GetAll().Count > 0)
            {
                ClientViewModel clientViewModel = (ClientViewModel) usersGridView.CurrentRow.DataBoundItem;
                Client client = _clientService.Get(clientViewModel.ClientId);
                AddEditUserForm addUserForm = new AddEditUserForm(_clientService, _bindingSource, client);
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

        private void RefreshDataSource()
        {
            _bindingSource.Clear();
            _bindingSource.DataSource = _clientService.GetAll().MapClientsToViewModel();
        }

    }
}
