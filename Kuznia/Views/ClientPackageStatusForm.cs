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
    public partial class ClientPackageStatusForm : Form
    {

        private IRepository<Package> _repository;
        private BindingSource _bindingSource;

        public ClientPackageStatusForm()
        {
            InitializeComponent();
            _repository = new PackageRepository(new XMLSerializer<List<Package>>("Packages.xml"));
            _bindingSource = new BindingSource();
            labelNoPackage.Hide();
            labelErrorId.Hide();
        }

        private void btnCheckStatus_Click(object sender, EventArgs e)
        {
            int packageId;
            if (Int32.TryParse(textBoxPackageId.Text, out packageId))
            {
                var packages = _repository.GetAll().Where(x => x.PackageId == packageId).ToList().MapPackagesToViewModel();
                if (packages.Any())
                {
                    _bindingSource.DataSource = packages;
                    dataGridViewPackages.DataSource = _bindingSource;
                    labelNoPackage.Hide();
                    labelErrorId.Hide();
                }
                else
                {
                    _bindingSource.DataSource = null;
                    dataGridViewPackages.DataSource = null;
                    labelNoPackage.Text = "Paczka o takim numerze nie istnieje.";
                    labelNoPackage.Show();
                    labelErrorId.Hide();
                }
            }
            else
            {
                labelNoPackage.Hide();
                labelErrorId.Text = "Niepoprawny format numeru paczki.";
                labelErrorId.Show();
                
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
            this.Hide();
        }
    }
}
