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

namespace Kuznia
{
    public partial class AddEditUserForm : Form
    {
        private IRepository<Client> _repository;
        private BindingSource _bindingSource;
        private readonly int _indexToEdit;

        public AddEditUserForm(IRepository<Client> repository, BindingSource bindingSource)
        {
            InitializeComponent();
            _repository = repository;
            _bindingSource = bindingSource;
            btnEdit.Enabled = false;
            initComboBox();
        }

        public AddEditUserForm(IRepository<Client> repository, BindingSource bindingSource, Client client, int index)
        {
            InitializeComponent();
            _repository = repository;
            _bindingSource = bindingSource;
            button1.Enabled = false;
            _indexToEdit = index;
            initComboBox();

            FillInputsWithClientData(client);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _repository.Add(CreateClientFromInputs());
            RefreshDataSource();
            this.Close();
        }

        private Client CreateClientFromInputs()
        {
            Client client = new Client();
            client.FirstName = txtboxFirstName.Text;
            client.LastName = txtboxLastName.Text;
            client.City = txtboxCity.Text;
            client.Street = txtboxStreet.Text;
            client.Status = ((KeyValuePair<PackageStatus, string>)comboBoxStatus.SelectedItem).Key;
            return client;
        }

        private void FillInputsWithClientData(Client client)
        {
            txtboxFirstName.Text = client.FirstName;
            txtboxLastName.Text = client.LastName;
            txtboxCity.Text = client.City;
            txtboxStreet.Text = client.Street;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            _repository.Update(_indexToEdit, CreateClientFromInputs());
            RefreshDataSource();
            this.Close();
        }

        private void RefreshDataSource()
        {
            _bindingSource.Clear();
            _bindingSource.DataSource = _repository.GetAll().MapClientsToViewModel();
        }

        private void initComboBox()
        {
            comboBoxStatus.DataSource = new BindingSource(EnumMapper.PackageStatuses, null);
            comboBoxStatus.DisplayMember = "Value";
            comboBoxStatus.ValueMember = "Key";
        }
    }
}
