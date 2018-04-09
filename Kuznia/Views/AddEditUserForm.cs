using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kuznia.Models;
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
        }

        public AddEditUserForm(IRepository<Client> repository, BindingSource bindingSource, Client client, int index)
        {
            InitializeComponent();
            _repository = repository;
            _bindingSource = bindingSource;
            button1.Enabled = false;
            _indexToEdit = index;

            FillInputsWithClientData(client);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _repository.Add(CreateClientFromInputs());
            _bindingSource.ResetBindings(false);
            this.Close();
        }

        private Client CreateClientFromInputs()
        {
            Client client = new Client();
            client.FirstName = txtboxFirstName.Text;
            client.LastName = txtboxLastName.Text;
            client.City = txtboxCity.Text;
            client.Street = txtboxStreet.Text;
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
            _bindingSource.ResetBindings(false);
            this.Close();
        }
    }
}
