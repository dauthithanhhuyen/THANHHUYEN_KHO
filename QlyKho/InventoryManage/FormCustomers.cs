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
    public partial class FormSuppliers : Form
    {
        public FormSuppliers()
        {
            InitializeComponent();
        }
        MyContext db = new MyContext();
        public void LoadDgv()
        {
            var result = from c in db.Customs
                         select new
                         {
                             ID = c.ID,
                             Name = c.Name,
                             Ad = c.Ad,
                             PhoneNumber = c.PhoneNumber,
                             Email = c.Email
                         };
            DgvCus.DataSource = result.ToList();
            DgvCus.Columns["ID"].Width = 50;
            DgvCus.Columns["Name"].Width = 70;
            DgvCus.Columns["Ad"].Width = 120;
            DgvCus.Columns["Ad"].HeaderText = "Address";
            DgvCus.Columns["PhoneNumber"].Width = 100;
            DgvCus.Columns["PhoneNumber"].HeaderText = "Phone";
            DgvCus.Columns["Email"].Width = 150;
        }
        public void LoadDgv( List<Custom> List)
        {
            DgvCus.DataSource = List;
            DgvCus.Columns["ID"].Width = 50;
            DgvCus.Columns["Name"].Width = 70;
            DgvCus.Columns["Ad"].Width = 120;
            DgvCus.Columns["Ad"].HeaderText = "Address";
            DgvCus.Columns["PhoneNumber"].Width = 100;
            DgvCus.Columns["PhoneNumber"].HeaderText = "Phone";
            DgvCus.Columns["Email"].Width = 150;
            DgvCus.Columns["BillExports"].Visible = false;
        }
        public void LoadDetail()
        {
            TxtCusName.Text = DgvCus.CurrentRow.Cells["Name"].Value.ToString();
            TxtCusPhone.Text = DgvCus.CurrentRow.Cells["PhoneNumber"].Value.ToString();
            TxtCusEmail.Text = DgvCus.CurrentRow.Cells["Email"].Value.ToString();
            TxtCusAddress.Text = DgvCus.CurrentRow.Cells["Ad"].Value.ToString();
        }
        private void FormCustomers_Load(object sender, EventArgs e)
        {
            if(Medium.Active == true)
            {
                BtCusCreate.Visible = true;
                BtCusDelete.Visible = true;
                BtCusEdit.Visible = true;
                TxtCusAddress.Enabled = true;
                TxtCusEmail.Enabled = true;
                TxtCusName.Enabled = true;
                TxtCusPhone.Enabled = true;
                BtCusSave.Visible = true;
            }
            LoadDgv();
            if(Medium.FormCus == false ) LoadDetail();
        }

        private void DgvCus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadDetail();
        }

        private void BtCusSearch_Click(object sender, EventArgs e)
        {
            if(CmbCus.Text == "ID of Customer" || CmbCus.Text == "")
            {
                int IdSearch = Convert.ToInt16(TxtCusSearch.Text);
                var Customer = db.Customs.Where(p => p.ID == IdSearch).SingleOrDefault();
                if (Customer != null)
                {
                    for (int i = 0; i < DgvCus.RowCount; i++)
                    {
                        if (DgvCus.Rows[i].Cells[1].Value.ToString().Trim() == Customer.Name)
                        {
                            DgvCus.Rows[i].Selected = true;
                            DgvCus.CurrentCell = DgvCus.Rows[i].Cells[1];
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
            else if( CmbCus.Text == "Name of Customer")
            {
                var result = from c in db.Customs where c.Name.Contains(TxtCusSearch.Text) select c;
                var Customer = result.ToList();
                if(Customer.Count != 0)
                {
                    LoadDgv(Customer);
                    LoadDetail();
                }
                else
                {
                    MessageBox.Show("No results found");
                    LoadDgv();
                    LoadDetail();
                }
            }
            else if(CmbCus.Text == "Address")
            {
                var result = from c in db.Customs where c.Ad.Contains(TxtCusSearch.Text) select c;
                var Customer = result.ToList();
                if (Customer.Count != 0)
                {
                    LoadDgv(Customer);
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

        private void TxtCusSearch_Click(object sender, EventArgs e)
        {
            TxtCusSearch.Clear();
        }

        private void BtCusBack_Click(object sender, EventArgs e)
        {
            FormHome f = new FormHome();
            f.Show();
            this.Hide();
        }

        private void BtCusCreate_Click(object sender, EventArgs e)
        {
            if(TxtCusName.Text == "" || TxtCusPhone.Text == "" || TxtCusEmail.Text == "" || TxtCusAddress.Text == "")
            {
                MessageBox.Show("Fill in all information");
                return;
            }
            Custom Cus = new Custom();
            Cus.Ad = TxtCusAddress.Text;
            Cus.Email = TxtCusEmail.Text;
            Cus.Name = TxtCusName.Text;
            Cus.PhoneNumber = TxtCusPhone.Text;
            db.Customs.Add(Cus);
            db.SaveChanges();
            MessageBox.Show("Add Customer successfully");
            LoadDgv();
            LoadDetail();
        }

        private void BtCusSave_Click(object sender, EventArgs e)
        {
            TxtCusAddress.Clear();
            TxtCusEmail.Clear();
            TxtCusName.Clear();
            TxtCusPhone.Clear();
        }

        private void BtCusEdit_Click(object sender, EventArgs e)
        {
            var Id = DgvCus.CurrentRow.Cells["ID"].Value.ToString();
            int IdCus = Convert.ToInt32(Id);
            var result = db.Customs.Find(IdCus);
            if (TxtCusName.Text == "" || TxtCusPhone.Text == "" || TxtCusEmail.Text == "" || TxtCusAddress.Text == "")
            {
                MessageBox.Show("Fill in all information");
                return;
            }
            result.Name = TxtCusName.Text;
            result.PhoneNumber = TxtCusPhone.Text;
            result.Email = TxtCusEmail.Text;
            result.Ad = TxtCusAddress.Text;
            if (MessageBox.Show("Do you want to save changes?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                db.SaveChanges();
                LoadDgv();
                LoadDetail();
            }
            else return;
        }

        private void BtCusDelete_Click(object sender, EventArgs e)
        {
            var Id = DgvCus.CurrentRow.Cells["ID"].Value.ToString();
            int IdCus = Convert.ToInt32(Id);
            var result = db.Customs.Find(IdCus);
            if (MessageBox.Show("Do you want to delete this item?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                db.Customs.Remove(result);
                db.SaveChanges();
                LoadDgv();
                LoadDetail();
            }
            else return;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
    
}
