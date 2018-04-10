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

namespace Kuznia.Views
{
    public partial class CourierManagePackageForm : Form
    {

        private IRepository<Package> _repository;
        private BindingSource _bindingSource;

        public CourierManagePackageForm()
        {
            InitializeComponent();
            _repository = new PackageRepository(new XMLSerializer<List<Package>>("Packages.xml"));
            _bindingSource = new BindingSource();
            _bindingSource.DataSource = _repository.GetAll().MapPackagesToViewModel();

            dataGridViewPackages.DataSource = _bindingSource;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
            this.Hide();
        }

        private void btnAddPackage_Click(object sender, EventArgs e)
        {
            AddEditPackageForm addEditPackageForm = new AddEditPackageForm(_repository, _bindingSource);
            addEditPackageForm.Show();
        }

        private void btnDeletePackage_Click(object sender, EventArgs e)
        {
            if (ContainsAnyData())
            {
                int index = dataGridViewPackages.CurrentCell.RowIndex;
                _repository.Delete(index);
                RefreshDataSource();
            }
        }

        private void btnEditPackage_Click(object sender, EventArgs e)
        {
            if (ContainsAnyData())
            {
                int index = dataGridViewPackages.CurrentCell.RowIndex;
                Package package = _repository.Get(index);
                AddEditPackageForm addUserForm = new AddEditPackageForm(_repository, _bindingSource, package, index);
                addUserForm.Show();
            }
        }

        private void btnChangeStatus_Click(object sender, EventArgs e)
        {

        }

        private bool ContainsAnyData()
        {
            return _repository.GetAll().Count > 0;
        }

        private void RefreshDataSource()
        {
            _bindingSource.Clear();
            _bindingSource.DataSource = _repository.GetAll().MapPackagesToViewModel();
        }
       
    }
}
