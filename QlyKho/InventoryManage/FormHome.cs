using InventoryManage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManage
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
            if (Medium.Active == true)
            {
                Manage.Enabled = true;
            }
        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            FormLogIn f = new FormLogIn();
            f.Show();
            this.Hide();
        }

        private void Registe_Click(object sender, EventArgs e)
        {
            FormRegistration f = new FormRegistration();
            f.Show();
            this.Hide();
        }

        private void Suppliers_Click(object sender, EventArgs e)
        {
            FormSupplier f = new FormSupplier();
            f.Show();
            this.Hide();
        }

        private void Customers_Click(object sender, EventArgs e)
        {
            FormSuppliers f = new FormSuppliers();
            f.Show();
            this.Hide();
        }

        private void Storekeepers_Click(object sender, EventArgs e)
        {
            FormStorekeepers f = new FormStorekeepers();
            f.Show();
            this.Hide();
        }

        private void Products_Click(object sender, EventArgs e)
        {
            FormProducts f = new FormProducts();
            f.Show();
            this.Hide();
        }

        private void Importations_Click(object sender, EventArgs e)
        {
            FormImportations f = new FormImportations();
            f.Show();
            this.Hide();
        }

        private void Exportations_Click(object sender, EventArgs e)
        {
            FormExportation f = new FormExportation();
            f.Show();
            this.Hide();
        }

        private void storekeepersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormStorekeepers f = new FormStorekeepers();
            f.Show();
            this.Hide();
        }

        private void importationsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormImportations f = new FormImportations();
            f.Show();
            this.Hide();
        }

        private void exportationsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormExportation f = new FormExportation();
            f.Show();
            this.Hide();
        }

        private void suppliersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormSupplier f = new FormSupplier();
            f.Show();
            this.Hide();
        }

        private void customersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormSuppliers f = new FormSuppliers();
            f.Show();
            this.Hide();
        }

        private void productsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormProducts f = new FormProducts();
            f.Show();
            this.Hide();
        }
    }
}
