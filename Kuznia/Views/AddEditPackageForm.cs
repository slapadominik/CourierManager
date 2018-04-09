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

namespace Kuznia.Views
{
    public partial class AddEditPackageForm : Form
    {

        private IRepository<Package> _repository;
        private BindingSource _bindingSource;
        private readonly int _indexToEdit; 

        public AddEditPackageForm(IRepository<Package> repository, BindingSource bindingSource)
        {
            InitializeComponent();
            _repository = repository;
            _bindingSource = bindingSource;
            btnEditPackage.Enabled = false;
            initComboBox();
        }

        public AddEditPackageForm(IRepository<Package> repository, BindingSource bindingSource, Package client, int index)
        {
            InitializeComponent();
            _repository = repository;
            _bindingSource = bindingSource;
            btnEditPackage.Enabled = false;
            initComboBox();
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
                _repository.Add(package);
                _bindingSource.DataSource = _repository.GetAll().MapPackagesToViewModel();
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
            
        }

    }
}
