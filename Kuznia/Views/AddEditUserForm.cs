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
using Kuznia.Models.Enums;
using Kuznia.Repositories;
using Kuznia.Services;

namespace Kuznia
{
    public partial class AddEditUserForm : Form
    {
        private IClientService _clientService;
        private BindingSource _bindingSource;

        public AddEditUserForm(IClientService clientService, BindingSource bindingSource)
        {
            InitializeComponent();
            _clientService = clientService;
            _bindingSource = bindingSource;
            btnEdit.Enabled = false;
            initComboBox();
        }

        public AddEditUserForm(IClientService clientService, BindingSource bindingSource, Client client)
        {
            InitializeComponent();
            _clientService = clientService;
            _bindingSource = bindingSource;
            button1.Enabled = false;
            txtBoxId.Enabled = false;
            initComboBox();

            FillInputsWithClientData(client);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Client client = CreateClientFromInputs();
            if (client == null)
            {
                MessageBox.Show("Pole ID Klienta musi być liczbą");
            }
            else
            {
                _clientService.Add(client);
                RefreshDataSource();
                this.Close();
            }
           
        }

        private Client CreateClientFromInputs()
        {
            Client client = new Client();
            int id;
            if (!Int32.TryParse(txtBoxId.Text, out id))
            {
                return null;
            }
            client.ClientId = id;
            client.FirstName = txtboxFirstName.Text;
            client.LastName = txtboxLastName.Text;
            client.City = txtboxCity.Text;
            client.Street = txtboxStreet.Text;
            client.Status = ((KeyValuePair<PackageStatus, string>)comboBoxStatus.SelectedItem).Key;
            return client;
        }

        private void FillInputsWithClientData(Client client)
        {
            txtBoxId.Text = client.ClientId.ToString();
            txtboxFirstName.Text = client.FirstName;
            txtboxLastName.Text = client.LastName;
            txtboxCity.Text = client.City;
            txtboxStreet.Text = client.Street;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            _clientService.Update(CreateClientFromInputs());
            RefreshDataSource();
            this.Close();
        }

        private void RefreshDataSource()
        {
            _bindingSource.Clear();
            _bindingSource.DataSource = _clientService.GetAll().MapClientsToViewModel();
        }

        private void initComboBox()
        {
            comboBoxStatus.DataSource = new BindingSource(EnumMapper.PackageStatuses, null);
            comboBoxStatus.DisplayMember = "Value";
            comboBoxStatus.ValueMember = "Key";
        }
    }
}
