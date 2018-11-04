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
    public partial class FormSupplier : Form
    {
        public FormSupplier()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        MyContext db = new MyContext();
        public void LoadDgv()
        {
            var result = from c in db.Companys
                         select new
                         {
                             ID = c.ID,
                             Name = c.Name,
                             Ad = c.Ad,
                             PhoneNumber = c.PhoneNumber,
                             Email = c.Email
                         };
            DgvSup.DataSource = result.ToList();
            DgvSup.Columns["ID"].Width = 50;
            DgvSup.Columns["Name"].Width = 70;
            DgvSup.Columns["Ad"].Width = 120;
            DgvSup.Columns["Ad"].HeaderText = "Address";
            DgvSup.Columns["PhoneNumber"].Width = 100;
            DgvSup.Columns["PhoneNumber"].HeaderText = "Phone";
            DgvSup.Columns["Email"].Width = 150;
        }
        public void LoadDgv(List<Company> List)
        {
            DgvSup.DataSource = List;
            DgvSup.Columns["ID"].Width = 50;
            DgvSup.Columns["Name"].Width = 70;
            DgvSup.Columns["Ad"].Width = 120;
            DgvSup.Columns["Ad"].HeaderText = "Address";
            DgvSup.Columns["PhoneNumber"].Width = 100;
            DgvSup.Columns["PhoneNumber"].HeaderText = "Phone";
            DgvSup.Columns["Email"].Width = 150;
            DgvSup.Columns["BillImports"].Visible = false;
            DgvSup.Columns["Products"].Visible = false;
        }
        public void LoadDetail()
        {
            TxtSupName.Text = DgvSup.CurrentRow.Cells["Name"].Value.ToString();
            TxtSupPhone.Text = DgvSup.CurrentRow.Cells["PhoneNumber"].Value.ToString();
            TxtSupEmail.Text = DgvSup.CurrentRow.Cells["Email"].Value.ToString();
            TxtSupAddress.Text = DgvSup.CurrentRow.Cells["Ad"].Value.ToString();
        }
        private void FormSupplier_Load(object sender, EventArgs e)
        {
            if(Medium.Active == true)
            {
                TxtSupAddress.Enabled = true;
                TxtSupEmail.Enabled = true;
                TxtSupName.Enabled = true;
                TxtSupPhone.Enabled = true;
                BtSupCreate.Visible = true;
                BtSupDelete.Visible = true;
                BtSupEdit.Visible = true;
                BtSupFresh.Visible = true;
            }
            LoadDgv();
            if(Medium.FormSup == false) LoadDetail();

        }

        private void DgvSup_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadDetail();
        }

        private void BtSupSearch_Click(object sender, EventArgs e)
        {
            if(CmbSup.Text == "ID of Supplier" || CmbSup.Text == "")
            {
                var IdSearch = Convert.ToInt16(TxtSupSearch.Text);
                var Supplier = db.Companys.Where(p => p.ID == IdSearch).SingleOrDefault();
                if (Supplier != null)
                {
                    for (int i = 0; i < DgvSup.RowCount; i++)
                    {
                        if (DgvSup.Rows[i].Cells[1].Value.ToString().Trim() == Supplier.Name)
                        {
                            DgvSup.Rows[i].Selected = true;
                            DgvSup.CurrentCell = DgvSup.Rows[i].Cells[1];
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
            else if(CmbSup.Text == "Name of Supplier")
            {
                var result = from c in db.Companys where c.Name.Contains(TxtSupSearch.Text) select c;
                var Supplier = result.ToList();
                if (Supplier.Count != 0)
                {
                    LoadDgv(Supplier);
                    LoadDetail();
                }
                else
                {
                    MessageBox.Show("No results found");
                    LoadDgv();
                    LoadDetail();
                }
            }
            else if(CmbSup.Text == "Address")
            {
                var result = from c in db.Companys where c.Ad.Contains(TxtSupSearch.Text) select c;
                var Supplier = result.ToList();
                if (Supplier.Count != 0)
                {
                    LoadDgv(Supplier);
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

        private void TxtSupSearch_Click(object sender, EventArgs e)
        {
            TxtSupSearch.Clear();
        }

        private void BtSupBack_Click(object sender, EventArgs e)
        {
            if(Medium.FormPro == true)
            {
                this.Hide();
                FormProducts p = new FormProducts();
                p.Show();
                return;
            }
            FormHome f = new FormHome();
            f.Show();
            this.Hide();
        }

        private void BtSupFresh_Click(object sender, EventArgs e)
        {
            TxtSupAddress.Clear();
            TxtSupEmail.Clear();
            TxtSupName.Clear();
            TxtSupPhone.Clear();
        }

        private void BtSupCreate_Click(object sender, EventArgs e)
        {
            if (TxtSupName.Text == "" || TxtSupPhone.Text == "" || TxtSupEmail.Text == "" || TxtSupAddress.Text == "")
            {
                MessageBox.Show("Fill in all information");
                return;
            }
            Company Sup = new Company();
            Sup.Ad = TxtSupAddress.Text;
            Sup.Email = TxtSupEmail.Text;
            Sup.Name = TxtSupName.Text;
            Sup.PhoneNumber = TxtSupPhone.Text;
            db.Companys.Add(Sup);
            db.SaveChanges();
            MessageBox.Show("Add item successfully");
            LoadDgv();
            LoadDetail();
        }

        private void BtSupEdit_Click(object sender, EventArgs e)
        {
            var Id = DgvSup.CurrentRow.Cells["ID"].Value.ToString();
            int IdSup = Convert.ToInt32(Id);
            var result = db.Companys.Find(IdSup);
            if (TxtSupName.Text == "" || TxtSupPhone.Text == "" || TxtSupEmail.Text == "" || TxtSupAddress.Text == "")
            {
                MessageBox.Show("Fill in all information");
                return;
            }
            result.Name = TxtSupName.Text;
            result.PhoneNumber = TxtSupPhone.Text;
            result.Email = TxtSupEmail.Text;
            result.Ad = TxtSupAddress.Text;
            if (MessageBox.Show("Do you want to save changes?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                db.SaveChanges();
                LoadDgv();
                LoadDetail();
            }
            else return;
        }

        private void BtSupDelete_Click(object sender, EventArgs e)
        {
            var Id = DgvSup.CurrentRow.Cells["ID"].Value.ToString();
            int IdSup = Convert.ToInt32(Id);
            var result = db.Companys.Find(IdSup);
            if (MessageBox.Show("Do you want to delete this item?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                db.Companys.Remove(result);
                db.SaveChanges();
                LoadDgv();
                LoadDetail();
            }
            else return;
        }
    }
}
