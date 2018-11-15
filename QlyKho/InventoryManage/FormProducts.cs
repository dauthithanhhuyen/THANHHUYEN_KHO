using InventoryManage.Models.Entity;
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
    public partial class FormProducts : Form
    {
        public FormProducts()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        MyContext db = new MyContext();
        public void LoadDgv()
        {
            var result = from c in db.Products
                         select new
                         {
                             ID = c.ID,
                             Code = c.Code,
                             Name = c.Name,
                             Quantity = c.Quantity,
                             Unit = c.Unit,
                             Company = c.Company.Name,
                         };
            DgvPro.DataSource = result.ToList();
            DgvPro.Columns["ID"].Width = 50;
            DgvPro.Columns["Code"].Width = 50;
            DgvPro.Columns["Name"].Width = 100;
            DgvPro.Columns["Quantity"].Width = 70;
            DgvPro.Columns["Unit"].Width = 100;
            DgvPro.Columns["Company"].Width = 150;
            DgvPro.Columns["Company"].HeaderText = "Supplier";
        }
        public void LoadDgv( List<Product> List)
        {
            DgvPro.DataSource = List;
            DgvPro.Columns["ID"].Width = 50;
            DgvPro.Columns["Code"].Width = 50;
            DgvPro.Columns["Name"].Width = 100;
            DgvPro.Columns["Quantity"].Width = 70;
            DgvPro.Columns["Unit"].Width = 100;
            DgvPro.Columns["Company"].Width = 150;
            DgvPro.Columns["Company"].HeaderText = "Supplier";

        }
        public void LoadCbSup()
        {
            var result = db.Companys.ToList();
            CbProSupplier.DataSource = result;
            CbProSupplier.ValueMember = "ID";
            CbProSupplier.DisplayMember = "Name";
        }
        public void LoadDetail()
        {
            string code = DgvPro.CurrentRow.Cells["Code"].Value.ToString();
            var product = db.Products.Where(p => p.Code == code).SingleOrDefault();
            TxtProName.Text = product.Name;
            TxtProCode.Text = code;
            TxtProQuantity.Text = product.Quantity.ToString();
            TxtProUnit.Text = product.Unit;
            CbProSupplier.SelectedValue = product.IdCom;
        }
        private void FormProducts_Load(object sender, EventArgs e)
        {
            if(Medium.Active == true)
            {
                TxtProCode.Enabled = true;
                TxtProName.Enabled = true;
                TxtProQuantity.Enabled = true;
                TxtProUnit.Enabled = true;
                CbProSupplier.Enabled = true;
                BtProCreate.Visible = true;
                BtProDelete.Visible = true;
                BtProEdit.Visible = true;
                BtProCreateSup.Enabled = true;
                BtProFresh.Visible = true;
            }
            LoadDgv();
            LoadCbSup();
            if(Medium.FormPro == false) LoadDetail();
        }

        private void DgvPro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadDetail();
        }

        private void TxtProSearch_Click(object sender, EventArgs e)
        {
            TxtProSearch.Clear();
        }

        private void BtProSearch_Click(object sender, EventArgs e)
        {
            if( CmbPro.Text == "Id of Product" || CmbPro.Text == "")
            {
                var IdSearch = Convert.ToInt16(TxtProSearch.Text);
                var product = db.Products.Where(p => p.ID == IdSearch ).SingleOrDefault();
                if (product != null)
                {
                    for (int i = 0; i < DgvPro.RowCount; i++)
                    {
                        if (DgvPro.Rows[i].Cells[1].Value.ToString().Trim() == product.Name)
                        {
                            DgvPro.Rows[i].Selected = true;
                            DgvPro.CurrentCell = DgvPro.Rows[i].Cells[1];
                            break;
                        }
                    }
                    LoadDetail();
                }
                else
                {
                    MessageBox.Show("No results found");
                }
            }
            else if( CmbPro.Text == "Code of Product")
            {
                var IdSearch = TxtProSearch.Text;
                var product = db.Products.Where(p => p.Code == IdSearch).SingleOrDefault();
                if (product != null)
                {
                    for (int i = 0; i < DgvPro.RowCount; i++)
                    {
                        if (DgvPro.Rows[i].Cells[1].Value.ToString().Trim() == product.Name)
                        {
                            DgvPro.Rows[i].Selected = true;
                            DgvPro.CurrentCell = DgvPro.Rows[i].Cells[1];
                            break;
                        }
                    }
                    LoadDetail();
                }
                else
                {
                    MessageBox.Show("No results found");
                }
            }
            else if( CmbPro.Text == "Name of Product")
            {
                var result = from c in db.Products where c.Name.Contains(TxtProSearch.Text) select new
                {
                    ID = c.ID,
                    Code = c.Code,
                    Name = c.Name,
                    Quantity = c.Quantity,
                    Unit = c.Unit,
                    Company = c.Company.Name,
                };
                var Product = result.ToList();
                if( Product.Count != 0)
                {
                    DgvPro.DataSource = Product;
                    DgvPro.Columns["ID"].Width = 50;
                    DgvPro.Columns["Code"].Width = 50;
                    DgvPro.Columns["Name"].Width = 100;
                    DgvPro.Columns["Quantity"].Width = 70;
                    DgvPro.Columns["Unit"].Width = 100;
                    DgvPro.Columns["Company"].Width = 150;
                    DgvPro.Columns["Company"].HeaderText = "Supplier";
                    LoadDetail();
                }
                else
                {
                    MessageBox.Show("No results found");
                    LoadDgv();
                    LoadDetail();
                }
            }
            else
            {
                var result = from c in db.Products
                             where c.Company.Name.Contains(TxtProSearch.Text)
                             select new
                             {
                                 ID = c.ID,
                                 Code = c.Code,
                                 Name = c.Name,
                                 Quantity = c.Quantity,
                                 Unit = c.Unit,
                                 Company = c.Company.Name,
                             };
                var Product = result.ToList();
                if (Product.Count != 0)
                {
                    DgvPro.DataSource = Product;
                    DgvPro.Columns["ID"].Width = 50;
                    DgvPro.Columns["Code"].Width = 50;
                    DgvPro.Columns["Name"].Width = 100;
                    DgvPro.Columns["Quantity"].Width = 70;
                    DgvPro.Columns["Unit"].Width = 100;
                    DgvPro.Columns["Company"].Width = 150;
                    DgvPro.Columns["Company"].HeaderText = "Supplier";
                    LoadDetail();
                }
                else
                {
                    MessageBox.Show("No results found");
                    LoadDgv();
                    LoadDetail();
                }
            }
        }

        private void BtProBack_Click(object sender, EventArgs e)
        {
            FormHome f = new FormHome();
            f.Show();
            this.Hide();
        }

        private void BtProFresh_Click(object sender, EventArgs e)
        {
            TxtProCode.Clear();
            TxtProName.Clear();
            TxtProQuantity.Clear();
            TxtProUnit.Clear();
        }

        private void BtProCreate_Click(object sender, EventArgs e)
        {
            if(TxtProUnit.Text == "" || TxtProCode.Text == "" || TxtProName.Text == "" || TxtProQuantity.Text == "")
            {
                MessageBox.Show("Fill in all information");
                return;
            }
            Product Pro = new Product();
            Pro.Code = TxtProCode.Text;
            Pro.IdCom = Convert.ToInt32(CbProSupplier.SelectedValue.ToString());
            Pro.Name = TxtProName.Text;
            Pro.Quantity = Convert.ToInt32(TxtProQuantity.Text);
            Pro.Unit = TxtProUnit.Text;
            db.Products.Add(Pro);
            db.SaveChanges();
            MessageBox.Show("Add item successfully");
            LoadDgv();
            LoadDetail();


        }

        private void BtProEdit_Click(object sender, EventArgs e)
        {
            var id = DgvPro.CurrentRow.Cells["ID"].Value.ToString();
            int IdPro = Convert.ToInt32(id);
            var Pro = db.Products.Where(p => p.ID == IdPro).SingleOrDefault();
            if (TxtProUnit.Text == "" || TxtProCode.Text == "" || TxtProName.Text == "" || TxtProQuantity.Text == "")
            {
                MessageBox.Show("Fill in all information");
                return;
            }
            Pro.Code = TxtProCode.Text;
            Pro.IdCom = Convert.ToInt32(CbProSupplier.SelectedValue.ToString());
            Pro.Name = TxtProName.Text;
            Pro.Quantity = Convert.ToInt32(TxtProQuantity.Text);
            Pro.Unit = TxtProUnit.Text;
            if (MessageBox.Show("Do you want to save changes?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                db.SaveChanges();
                LoadDgv();
                LoadDetail();
            }
        }

        private void BtProDelete_Click(object sender, EventArgs e)
        {
            var id = DgvPro.CurrentRow.Cells["ID"].Value.ToString();
            int IdPro = Convert.ToInt32(id);
            var Pro = db.Products.Find(IdPro);
            if (MessageBox.Show("Do you want to delete this item?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                db.Products.Remove(Pro);
                db.SaveChanges();
                LoadDgv();
                LoadDetail();
            }
            else return;
        }

        private void BtProCreateSup_Click(object sender, EventArgs e)
        {
            Medium.FormPro = true;
            FormSupplier f = new FormSupplier();
            f.Show();
            this.Hide();
        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
