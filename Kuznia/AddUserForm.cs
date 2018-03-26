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
    public partial class AddUserForm : Form
    {
        private IClientRepository _repository;
        private BindingSource _bindingSource;

        public AddUserForm(IClientRepository repository, BindingSource bindingSource)
        {
            InitializeComponent();
            _repository = repository;
            _bindingSource = bindingSource;
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
    }
}
