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
    public partial class FormStorekeepers : Form
    {
        public FormStorekeepers()
        {
            InitializeComponent();
        }
        MyContext db = new MyContext();

        public void LoadDgv()
        {
            var result = from c in db.Storekeepers
                         select new
                         {
                             ID = c.ID,
                             Name = c.Name,
                             Ad = c.Ad,
                             PhoneNumber = c.PhoneNumber,
                             Email = c.Email,
                             DateOfBirth = c.DateOfBirth
                         };
            DgvSto.DataSource = result.ToList();
            DgvSto.Columns["ID"].Width = 50;
            DgvSto.Columns["Name"].Width = 150;
            DgvSto.Columns["Ad"].Width = 120;
            DgvSto.Columns["Ad"].HeaderText = "Address";
            DgvSto.Columns["PhoneNumber"].Width = 100;
            DgvSto.Columns["PhoneNumber"].HeaderText = "Phone";
            DgvSto.Columns["Email"].Width = 150;
            DgvSto.Columns["DateOfBirth"].Width = 150;
            DgvSto.Columns["DateOfBirth"].HeaderText = "BirthDay";
        }

        public void LoadDgv( List<Storekeeper> List)
        {
            DgvSto.DataSource = List;
            DgvSto.Columns["ID"].Width = 50;
            DgvSto.Columns["Name"].Width = 150;
            DgvSto.Columns["Ad"].Width = 120;
            DgvSto.Columns["Ad"].HeaderText = "Address";
            DgvSto.Columns["PhoneNumber"].Width = 100;
            DgvSto.Columns["PhoneNumber"].HeaderText = "Phone";
            DgvSto.Columns["Email"].Width = 150;
            DgvSto.Columns["DateOfBirth"].Width = 150;
            DgvSto.Columns["DateOfBirth"].HeaderText = "BirthDay";
            DgvSto.Columns["BillImports"].Visible = false;
            DgvSto.Columns["BillExports"].Visible = false;
            DgvSto.Columns["Users"].Visible = false;
        }

        public void LoadDetail()
        {
            TxtStoName.Text = DgvSto.CurrentRow.Cells["Name"].Value.ToString();
            TxtStoPhone.Text = DgvSto.CurrentRow.Cells["PhoneNumber"].Value.ToString();
            TxtStoEmail.Text = DgvSto.CurrentRow.Cells["Email"].Value.ToString();
            TxtStoAddress.Text = DgvSto.CurrentRow.Cells["Ad"].Value.ToString();
            BirthDay.Value = DateTime.Parse(DgvSto.CurrentRow.Cells["DateOfBirth"].Value.ToString());
        }
        //Form load
        private void FormStorekeepers_Load(object sender, EventArgs e)
        {
            LoadDgv();
            if (Medium.FormPro != true)
            {
                LoadDetail();
            }
            if (Medium.Active == true)
            {
                BtStoCreate.Visible = true;
                BtStoDelete.Visible = true;
                BtStoEdit.Visible = true;
                TxtStoAddress.Enabled = true;
                TxtStoEmail.Enabled = true;
                TxtStoName.Enabled = true;
                TxtStoPhone.Enabled = true;
                BirthDay.Enabled = true;
                BtStoFresh.Visible = true;
            }
        }

        private void DgvSto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadDetail();
        }

        private void TxtStoSearch_Click(object sender, EventArgs e)
        {
            TxtStoSearch.Clear();
        }

        private void BtStoSearch_Click(object sender, EventArgs e)
        {
            if(CmbSto.Text == "" || CmbSto.Text == "ID of Storekeepers")
            {
                var IdSearch = Convert.ToInt16(TxtStoSearch.Text);
                var Stokeeper = db.Storekeepers.Where(p => p.ID == IdSearch).SingleOrDefault();
                if (Stokeeper != null)
                {
                    for (int i = 0; i < DgvSto.RowCount; i++)
                    {
                        if (DgvSto.Rows[i].Cells[1].Value.ToString().Trim() == Stokeeper.Name)
                        {
                            DgvSto.Rows[i].Selected = true;
                            DgvSto.CurrentCell = DgvSto.Rows[i].Cells[1];
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
            else
            {
                var result = from c in db.Storekeepers where c.Name.Contains(TxtStoSearch.Text) select c;
                var Storekeeper = result.ToList();
                if (Storekeeper.Count != 0)
                {
                    LoadDgv(Storekeeper);
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

        private void BtSupBack_Click(object sender, EventArgs e)
        {
            FormHome f = new FormHome();
            f.Show();
            this.Hide();
        }

        //

        private void BtStoCreate_Click(object sender, EventArgs e)
        {
            if (TxtStoName.Text == "" || TxtStoPhone.Text == "" || TxtStoEmail.Text == "" || TxtStoAddress.Text == "")
            {
                MessageBox.Show("Fill in all information");
                return;
            }
            Storekeeper Sto = new Storekeeper();
            Sto.Ad = TxtStoAddress.Text;
            Sto.Email = TxtStoEmail.Text;
            Sto.Name = TxtStoName.Text;
            Sto.PhoneNumber = TxtStoPhone.Text;
            Sto.DateOfBirth = BirthDay.Value;
            db.Storekeepers.Add(Sto);
            db.SaveChanges();
            MessageBox.Show("Add item successfully");
            LoadDgv();
            LoadDetail();
        }
        
        //btndelete
        private void BtStoDelete_Click(object sender, EventArgs e)
        {
            var Id = DgvSto.CurrentRow.Cells["ID"].Value.ToString();
            int IdSto = Convert.ToInt32(Id);
            var result = db.Storekeepers.Find(IdSto);
            if (MessageBox.Show("Do you want to delete this item?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                db.Storekeepers.Remove(result);
                db.SaveChanges();
                LoadDgv();
                LoadDetail();
            }
            else return;
        }
        //btnsua
        private void BtStoEdit_Click(object sender, EventArgs e)
        {
            var Id = DgvSto.CurrentRow.Cells["ID"].Value.ToString();
            int IdSto = Convert.ToInt32(Id);
            var result = db.Storekeepers.Find(IdSto);
            if (TxtStoName.Text == "" || TxtStoPhone.Text == "" || TxtStoEmail.Text == "" || TxtStoAddress.Text == "")
            {
                MessageBox.Show("Fill in all information");
                return;
            }
            result.Name = TxtStoName.Text;
            result.PhoneNumber = TxtStoPhone.Text;
            result.Email = TxtStoEmail.Text;
            result.Ad = TxtStoAddress.Text;
            result.DateOfBirth = BirthDay.Value;
            if (MessageBox.Show("Do you want to save changes?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                db.SaveChanges();
                LoadDgv();
                LoadDetail();
            }
            else return;
        }
    }
}
