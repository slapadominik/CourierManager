using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kuznia.Helpers;
using Kuznia.Models;
using Kuznia.Models.Enums;
using Kuznia.Repositories;
using Kuznia.Services;

namespace Kuznia.Views
{
    public partial class AddEditPackageForm : Form
    {

        private IPackageService _packageService;
        private BindingSource _bindingSource;


        public AddEditPackageForm(IPackageService packageService, BindingSource bindingSource)
        {
            InitializeComponent();
            _packageService = packageService;
            _bindingSource = bindingSource;
            btnEditPackage.Enabled = false;
            initComboBox();
        }

        public AddEditPackageForm(IPackageService packageService, BindingSource bindingSource, Package package)
        {
            InitializeComponent();
            _packageService = packageService;
            _bindingSource = bindingSource;
            btnAddPackage.Enabled = false;
            txtBoxPackageId.Enabled = false;
            initComboBox();
            FillInputsWithPackageData(package);
        }

        private void btnAddPackage_Click(object sender, EventArgs e)
        {
            Package package = CreatePackageFromInputs();
            if (package == null)
            {
                MessageBox.Show("Pole Numer Paczki musi być liczbą");
            }
            else
            {
                _packageService.Add(package);
                _bindingSource.DataSource = _packageService.GetAll().MapPackagesToViewModel();
                this.Close();
            }
        }

        private Package CreatePackageFromInputs()
        {
            Package package = new Package();
            int packageId;
            if (!Int32.TryParse(txtBoxPackageId.Text, out packageId))
            {
                return null;
            }
            package.PackageId = Int32.Parse(txtBoxPackageId.Text);
            package.Status = ((KeyValuePair<PackageStatus, string>) comboBoxStatus.SelectedItem).Key;
            package.DeliveryDateTime = dateTimePicker.Value;
            return package;
        }

        private void initComboBox()
        {
            comboBoxStatus.DataSource = new BindingSource(EnumMapper.PackageStatuses, null);
            comboBoxStatus.DisplayMember = "Value";
            comboBoxStatus.ValueMember = "Key";
        }

        private void FillInputsWithPackageData(Package package)
        {
            txtBoxPackageId.Text = package.PackageId.ToString();
            dateTimePicker.Value = package.DeliveryDateTime;
        }

        private void btnEditPackage_Click(object sender, EventArgs e)
        {
            _packageService.Update(CreatePackageFromInputs());
            _bindingSource.DataSource = _packageService.GetAll().MapPackagesToViewModel();
            this.Close();
        }
    }
}
