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

namespace Kuznia.Views
{
    public partial class CourierManagePackageForm : Form
    {

        private IPackageService _packageService;
        private BindingSource _bindingSource;

        public CourierManagePackageForm()
        {
            InitializeComponent();
            _packageService =
                new PackageService(new PackageRepository(new XMLSerializer<List<Package>>("Packages.xml")));
            _bindingSource = new BindingSource();
            _bindingSource.DataSource = _packageService.GetAll().MapPackagesToViewModel();

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
            AddEditPackageForm addEditPackageForm = new AddEditPackageForm(_packageService, _bindingSource);
            addEditPackageForm.Show();
        }

        private void btnDeletePackage_Click(object sender, EventArgs e)
        {
            if (ContainsAnyData())
            {
                var package = (PackageViewModel) dataGridViewPackages.CurrentRow.DataBoundItem;
                _packageService.Delete(package.MapPackageViewModelToModel());
                RefreshDataSource();
            }
        }

        private void btnEditPackage_Click(object sender, EventArgs e)
        {
            if (ContainsAnyData())
            {
                var packageVieModel = (PackageViewModel)dataGridViewPackages.CurrentRow.DataBoundItem;
                Package package = _packageService.Get(packageVieModel.PackageId);
                AddEditPackageForm addUserForm = new AddEditPackageForm(_packageService, _bindingSource, package);
                addUserForm.Show();
            }
        }


        private bool ContainsAnyData()
        {
            return _packageService.GetAll().Count > 0;
        }

        private void RefreshDataSource()
        {
            _bindingSource.Clear();
            _bindingSource.DataSource = _packageService.GetAll().MapPackagesToViewModel();
        }
       
    }
}
