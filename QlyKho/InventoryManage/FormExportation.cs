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
    public partial class FormExportation : Form
    {
        public FormExportation()
        {
            InitializeComponent();
        }
        MyContext db = new MyContext();
        public void LoadDgvPro()
        {
            var Id = Convert.ToInt32(DgvExp.CurrentRow.Cells["ID"].Value.ToString());
            var result = from c in db.DetailExports.Where(p => p.IDBill == Id)
                         select new
                         {
                             ID = c.IDProduct,
                             Code = c.Product.Code,
                             Name = c.Product.Name,
                             Quantity = c.Quantity,
                             Unit = c.Product.Unit,
                         };
            DgvExpPro.DataSource = result.ToList();
            DgvExpPro.Columns["ID"].Width = 50;
            DgvExpPro.Columns["Code"].Width = 70;
            DgvExpPro.Columns["Name"].Width = 80;
            DgvExpPro.Columns["Quantity"].Width = 60;
            DgvExpPro.Columns["Unit"].Width =60;
        }

        public void LoadDgv()
        {
            var result = from c in db.BillExports
                         select new
                         {
                             ID = c.ID,
                             Customer = c.Custom.Name,
                             Deliver = c.NameCustom,
                             Storekeeper = c.Storekeeper.Name,
                             Date = c.DateExport,
                         };
            DgvExp.DataSource = result.ToList();
            DgvExp.Columns["ID"].Width = 50;
            DgvExp.Columns["Customer"].Width = 70;
            DgvExp.Columns["Deliver"].Width = 120;
            DgvExp.Columns["Storekeeper"].Width = 120;
            DgvExp.Columns["Date"].Width = 100;
        }
        public void LoadCbCus()
        {
            var result = db.Customs.ToList();
            CbExpCustomer.DataSource = result;
            CbExpCustomer.ValueMember = "ID";
            CbExpCustomer.DisplayMember = "Name";
        }
        public void LoadCbProSup()
        {
            var result = db.Companys.ToList();
            CbExpProSup.DataSource = result;
            CbExpProSup.ValueMember = "ID";
            CbExpProSup.DisplayMember = "Name";
        }
        public void LoadDetail()
        {
            string Id = DgvExp.CurrentRow.Cells["ID"].Value.ToString();
            int IdBill = Convert.ToInt32(Id);
            var result = db.BillExports.Where(p => p.ID == IdBill).SingleOrDefault();
            TxtExpDeliver.Text = result.NameCustom;
            TxtExpStorekeeper.Text = DgvExp.CurrentRow.Cells["Storekeeper"].Value.ToString();
            TxtExpStoID.Text = result.IDStoreKeeper.ToString();
            CbExpCustomer.SelectedValue = result.IDCustom;
            DateExp.Value = DateTime.Parse(result.DateExport.ToString());
        }
        public void LoadDetailPro()
        {
            var IdBill = DgvExp.CurrentRow.Cells["ID"].Value.ToString();
            int Bill = Convert.ToInt16(IdBill);
            string IdPro = DgvExpPro.CurrentRow.Cells["ID"].Value.ToString();
            int Pro = Convert.ToInt16(IdPro);
            var ExpProduct = db.DetailExports.Where(p => p.IDBill == Bill && p.IDProduct == Pro).SingleOrDefault();
            TxtExpProName.Text = ExpProduct.Product.Name;
            TxtExpProCode.Text = ExpProduct.Product.Code;
            TxtExpProQuan.Text = ExpProduct.Quantity.ToString();
            TxtExpProUnit.Text = ExpProduct.Product.Unit;
            CbExpProSup.SelectedValue = ExpProduct.Product.IdCom;
        }
        private void FormExportation_Load(object sender, EventArgs e)
        {
            if(Medium.Active == true)
            {
                BtExpCreate.Visible = true;
                BtExpDelete.Visible = true;
                BtExpEdit.Visible = true;
                BtExpCreateCust.Enabled = true;
                TxtExpDeliver.Enabled = true;
                TxtExpProCode.Enabled = true;
                TxtExpProName.Enabled = true;
                TxtExpProQuan.Enabled = true;
                TxtExpProUnit.Enabled = true;
                TxtExpStorekeeper.Enabled = true;
                CbExpCustomer.Enabled = true;
                CbExpProSup.Enabled = true;
                DateExp.Enabled = true;
                BtExpAddPro.Visible = true;
                BtExpDeletePro.Visible = true;
                BtExpEditPro.Visible = true;
                BtExpFresh.Visible = true;
                TxtExpStoID.Enabled = true;
            }
            LoadDgv();
            LoadCbCus();
            LoadDetail();
            LoadDgvPro();
            LoadCbProSup();
            LoadDetailPro();
        }

        private void DgvExp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadDetail();
            LoadDgvPro();
            LoadDetailPro();
        }

        private void DgvExpPro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadDetailPro();
        }

        private void BtExpBack_Click(object sender, EventArgs e)
        {
            FormHome f = new FormHome();
            f.Show();
            this.Hide();
        }

        private void TxtExpSearch_Click(object sender, EventArgs e)
        {
            TxtExpSearch.Clear();
        }

        private void BtExpSearch_Click(object sender, EventArgs e)
        {
            if(CmbExp.Text == "Id of Receipt")
            {
                int Key = Convert.ToInt32(TxtExpSearch.Text);
                var Bill = db.BillExports.Where(p => p.ID == Key).SingleOrDefault();
                if (Bill != null)
                {
                    for (int i = 0; i < DgvExp.RowCount; i++)
                    {
                        if (DgvExp.Rows[i].Cells[0].Value.ToString().Trim() == Bill.ID.ToString())
                        {
                            DgvExp.Rows[i].Selected = true;
                            DgvExp.CurrentCell = DgvExp.Rows[i].Cells[0];
                            break;
                        }
                    }
                    LoadDetail();
                    LoadDgvPro();
                    LoadDetailPro();

                }
                else
                {
                    MessageBox.Show("No results found");
                }
            }
            else if(CmbExp.Text == "Name of Storekeeper")
            {
                var result = from c in db.BillExports where c.Storekeeper.Name.Contains(TxtExpSearch.Text)
                             select new
                             {
                                 ID = c.ID,
                                 Customer = c.Custom.Name,
                                 Deliver = c.NameCustom,
                                 Storekeeper = c.Storekeeper.Name,
                                 Date = c.DateExport,
                             };
                var Bill = result.ToList();
                if(Bill.Count != 0)
                {
                    DgvExp.DataSource = Bill;
                    DgvExp.Columns["ID"].Width = 50;
                    DgvExp.Columns["Customer"].Width = 70;
                    DgvExp.Columns["Deliver"].Width = 120;
                    DgvExp.Columns["Storekeeper"].Width = 120;
                    DgvExp.Columns["Date"].Width = 100;
                    LoadDetail();
                    LoadDgvPro();
                    LoadDetailPro();
                }
                else
                {
                    MessageBox.Show("No results found");
                    LoadDgv();
                    LoadDetail();
                    LoadDgvPro();
                    LoadDetailPro();
                }
            }
            else if( CmbExp.Text == "Name of Customer")
            {
                var result = from c in db.BillExports
                             where c.Custom.Name.Contains(TxtExpSearch.Text)
                             select new
                             {
                                 ID = c.ID,
                                 Customer = c.Custom.Name,
                                 Deliver = c.NameCustom,
                                 Storekeeper = c.Storekeeper.Name,
                                 Date = c.DateExport,
                             };
                var Bill = result.ToList();
                if (Bill.Count != 0)
                {
                    DgvExp.DataSource = Bill;
                    DgvExp.Columns["ID"].Width = 50;
                    DgvExp.Columns["Customer"].Width = 70;
                    DgvExp.Columns["Deliver"].Width = 120;
                    DgvExp.Columns["Storekeeper"].Width = 120;
                    DgvExp.Columns["Date"].Width = 100;
                    LoadDetail();
                    LoadDgvPro();
                    LoadDetailPro();
                }
                else
                {
                    MessageBox.Show("No results found");
                    LoadDgv();
                    LoadDetail();
                    LoadDgvPro();
                    LoadDetailPro();
                }
            }
            else if(CmbExp.Text == "Date of Exporting")
            {
                var day = DateTime.Parse(TxtExpSearch.Text);
                var result = from c in db.BillExports where c.DateExport == day
                             select new
                             {
                                 ID = c.ID,
                                 Customer = c.Custom.Name,
                                 Deliver = c.NameCustom,
                                 Storekeeper = c.Storekeeper.Name,
                                 Date = c.DateExport,
                             };
                var Bill = result.ToList();
                if (Bill.Count != 0)
                {
                    DgvExp.DataSource = Bill;
                    DgvExp.Columns["ID"].Width = 50;
                    DgvExp.Columns["Customer"].Width = 70;
                    DgvExp.Columns["Deliver"].Width = 120;
                    DgvExp.Columns["Storekeeper"].Width = 120;
                    DgvExp.Columns["Date"].Width = 100;
                    LoadDetail();
                    LoadDgvPro();
                    LoadDetailPro();
                }
                else
                {
                    MessageBox.Show("No results found");
                    LoadDgv();
                    LoadDetail();
                    LoadDgvPro();
                    LoadDetailPro();
                }
            }
            else if(CmbExp.Text == "Month of Exporting")
            {
                var s = TxtExpSearch.Text;
                string[] m;
                m = s.Split('/');
                int month = Convert.ToInt16(m[0]);
                int year = Convert.ToInt16(m[1]);
                var result = from c in db.BillExports
                             where c.DateExport.Value.Month == month && c.DateExport.Value.Year == year
                             select new
                             {
                                 ID = c.ID,
                                 Customer = c.Custom.Name,
                                 Deliver = c.NameCustom,
                                 Storekeeper = c.Storekeeper.Name,
                                 Date = c.DateExport,
                             };
                var Bill = result.ToList();
                if (Bill.Count != 0)
                {
                    DgvExp.DataSource = Bill;
                    DgvExp.Columns["ID"].Width = 50;
                    DgvExp.Columns["Customer"].Width = 70;
                    DgvExp.Columns["Deliver"].Width = 120;
                    DgvExp.Columns["Storekeeper"].Width = 120;
                    DgvExp.Columns["Date"].Width = 100;
                    LoadDetail();
                    LoadDgvPro();
                    LoadDetailPro();
                }
                else
                {
                    MessageBox.Show("No results found");
                    LoadDgv();
                    LoadDetail();
                    LoadDgvPro();
                    LoadDetailPro();
                }
            }
            else
            {
                int year = Convert.ToInt16(TxtExpSearch.Text);
                var result = from c in db.BillExports
                             where c.DateExport.Value.Year == year
                             select new
                             {
                                 ID = c.ID,
                                 Customer = c.Custom.Name,
                                 Deliver = c.NameCustom,
                                 Storekeeper = c.Storekeeper.Name,
                                 Date = c.DateExport,
                             };
                var Bill = result.ToList();
                if (Bill.Count != 0)
                {
                    DgvExp.DataSource = Bill;
                    DgvExp.Columns["ID"].Width = 50;
                    DgvExp.Columns["Customer"].Width = 70;
                    DgvExp.Columns["Deliver"].Width = 120;
                    DgvExp.Columns["Storekeeper"].Width = 120;
                    DgvExp.Columns["Date"].Width = 100;
                    LoadDetail();
                    LoadDgvPro();
                    LoadDetailPro();
                }
                else
                {
                    MessageBox.Show("No results found");
                    LoadDgv();
                    LoadDetail();
                    LoadDgvPro();
                    LoadDetailPro();
                }
            }
        }

        private void BtExpCreateCust_Click(object sender, EventArgs e)
        {
            FormSuppliers f = new FormSuppliers();
            this.Hide();
            Medium.FormCus = true;
            f.Show();
        }

        private void BtExpFresh_Click(object sender, EventArgs e)
        {
            TxtExpDeliver.Clear();
            TxtExpProCode.Clear();
            TxtExpProName.Clear();
            TxtExpProQuan.Clear();
            TxtExpProUnit.Clear();
            var result = db.Storekeepers.Find(Medium.IdSto);
            TxtExpStoID.Text = result.ID.ToString();
            TxtExpStorekeeper.Text = result.Name;
            DgvExpPro.DataSource = null;
        }

        private void BtExpCreate_Click(object sender, EventArgs e)
        {
            if(TxtExpStorekeeper.Text == "" || TxtExpDeliver.Text == "" )
            {
                MessageBox.Show("Fill in all information");
                return;
            }
            BillExport Bill = new BillExport();
            Bill.IDCustom = Convert.ToInt16(CbExpCustomer.SelectedValue.ToString());
            Bill.IDStoreKeeper = Medium.IdSto;
            Bill.NameCustom = TxtExpDeliver.Text;
            Bill.DateExport = DateExp.Value;
            db.BillExports.Add(Bill);
            db.SaveChanges();
            for (int i = 0; i < DgvExpPro.RowCount; i++)
            {
                DetailExport Detail = new DetailExport();
                Detail.IDBill = Bill.ID;
                Detail.IDProduct = Convert.ToInt16(DgvExpPro.Rows[i].Cells["ID"].Value.ToString());
                var res = db.DetailExports.Where(p => p.IDBill == Detail.IDBill && p.IDProduct == Detail.IDProduct).SingleOrDefault();
                if (res != null)
                {
                    res.Quantity = res.Quantity + Convert.ToInt16(DgvExpPro.Rows[i].Cells["Quantity"].Value.ToString());
                    db.SaveChanges();
                }
                else
                {
                    Detail.Quantity = Convert.ToInt16(DgvExpPro.Rows[i].Cells["Quantity"].Value.ToString());
                    db.DetailExports.Add(Detail);
                    db.SaveChanges();
                }
            }
            MessageBox.Show("Add Item successfully");
            LoadDgv();
            LoadDetail();
            LoadDgvPro();
            LoadDetailPro();
        }

        private void toolStrip3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void LoadPro(List<DetailExport> list)
        {
            
            List<ProductExp> ListProExp = new List<ProductExp>();
            for(int i=0; i<list.Count; i++)
            {
                ProductExp ProExp = new ProductExp();
                ProExp.ID= list[i].IDProduct;
                ProExp.Quantity= list[i].Quantity;
                var Pro = db.Products.Find(ProExp.ID);
                ProExp.Name = Pro.Name;
                ProExp.Unit = Pro.Unit;
                //ProExp.Company = Pro.Company.Name;
                ProExp.Code = Pro.Code;
                ListProExp.Add(ProExp);
            }   
            DgvExpPro.DataSource = ListProExp;
            DgvExpPro.Columns["ID"].Width = 50;
           // DgvExpPro.Columns["ID1"].HeaderText = "ID";
            DgvExpPro.Columns["Code"].Width = 70;
           // DgvExpPro.Columns["Code1"].HeaderText = "Code";
            DgvExpPro.Columns["Name"].Width = 80;
           // DgvExpPro.Columns["Name1"].HeaderText = "Name";
            DgvExpPro.Columns["Quantity"].Width = 60;
            //DgvExpPro.Columns["Quan1"].HeaderText = "Quantity";
            DgvExpPro.Columns["Unit"].Width = 60;
            //DgvExpPro.Columns["Unit1"].HeaderText = "Unit";
           // DgvExpPro.Columns["Company"].Width = 70;
           // DgvExpPro.Columns["Company1"].HeaderText = "Supplier";
        }
        private void BtExpAddPro_Click(object sender, EventArgs e)
        {
            List<DetailExport> ListPro = new List<DetailExport>();
            DetailExport ProExp = new DetailExport();
            var Id = Convert.ToInt32(DgvExp.CurrentRow.Cells["ID"].Value.ToString());
            for (int i = 0; i < DgvExpPro.RowCount; i++)
            {
                var str = DgvExpPro.Rows[i].Cells["ID"].Value.ToString();
                var IDProduct = Convert.ToInt16(str);
                var Detail = db.DetailExports.Where(p => p.IDBill == Id && p.IDProduct == IDProduct).SingleOrDefault();
                ListPro.Add(Detail);
            }
            var result = db.Products.Where(p => p.Code == TxtExpProCode.Text).SingleOrDefault();
            if(result == null)
            {
                MessageBox.Show("There isn't this item in the storehouse");
                return;
            }
            else
            {
                TxtExpProName.Text = result.Name;
                TxtExpProUnit.Text = result.Unit;
                CbExpProSup.SelectedValue = result.IdCom;
                if(Convert.ToInt32(TxtExpProQuan.Text) > result.Quantity)
                {
                    MessageBox.Show("There aren't enough items in the storehouse");
                    TxtExpProQuan.Clear();
                    return;
                }
                else
                {
                    ProExp.IDBill = Id;
                    ProExp.IDProduct = result.ID;
                    ProExp.Quantity = Convert.ToInt16(TxtExpProQuan.Text);
                    ListPro.Add(ProExp);
                    LoadPro(ListPro);
                }
            }
            
        }

        private void TxtExpProCode_TextChanged(object sender, EventArgs e)
        {
            var result = db.Products.Where(p => p.Code == TxtExpProCode.Text).SingleOrDefault();
            if( result != null)
            {
                TxtExpProName.Text = result.Name;
                TxtExpProUnit.Text = result.Unit;
                CbExpProSup.SelectedValue = result.IdCom;
            }
            else
            {
                TxtExpProName.Clear();
                TxtExpProUnit.Clear();
            }
        }

        private void BtExpEditPro_Click(object sender, EventArgs e)
        {
            var IdBill = Convert.ToInt16(DgvExp.CurrentRow.Cells["ID"].Value.ToString());
            List<DetailExport> List = new List<DetailExport>();

            for(int i = 0; i<DgvExpPro.RowCount; i++)
            {
                DetailExport ProExp = new DetailExport();
                var str = DgvExpPro.Rows[i].Cells["ID"].Value.ToString();
                ProExp.IDProduct = Convert.ToInt16(str);
                ProExp.IDBill = IdBill;
                var quan = DgvExpPro.Rows[i].Cells["Quantity"].Value.ToString();
                ProExp.Quantity = Convert.ToInt16(quan);
                //var Detail = db.DetailExports.Where(p => p.IDBill == IdBill && p.IDProduct == IDProduct).SingleOrDefault();
                List.Add(ProExp);
            }
            var IDPro = Convert.ToInt16(DgvExpPro.CurrentRow.Cells["ID"].Value.ToString());
            var result = db.Products.Find(IDPro);
            if (Convert.ToInt32(TxtExpProQuan.Text) > result.Quantity)
            {
                MessageBox.Show("There aren't enough items in the storehouse");
                TxtExpProQuan.Clear();
                return;
            }
            else
            {
                var ProExp = List.Where(p => p.IDBill == IdBill && p.IDProduct == IDPro).SingleOrDefault();
                List.Remove(ProExp);
                DetailExport ExpPro = new DetailExport();
                ExpPro.IDBill = IdBill;
                ExpPro.IDProduct = IDPro;
                string quan = TxtExpProQuan.Text;
                ExpPro.Quantity = Convert.ToInt16(quan);
                List.Add(ExpPro);
                LoadPro(List);
            }
        }

        private void BtExpEdit_Click(object sender, EventArgs e)
        {
            var IdBill = DgvExp.CurrentRow.Cells["ID"].Value.ToString();
            int ID = Convert.ToInt16(IdBill);
            var Bill = db.BillExports.Find(ID);
            Bill.IDCustom = Convert.ToInt16(CbExpCustomer.SelectedValue.ToString());
            Bill.NameCustom = TxtExpDeliver.Text;
            Bill.IDStoreKeeper = Convert.ToInt16(TxtExpStoID.Text);
            Bill.DateExport = DateExp.Value;
            if (MessageBox.Show("Do you want to save changes?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                var result = db.DetailExports.Where(p => p.IDBill == ID).ToList();
                for (int i = 0; i < result.Count; i++)
                {
                    db.DetailExports.Remove(result[i]);
                    db.SaveChanges();
                }
                for (int i = 0; i < DgvExpPro.RowCount; i++)
                {
                    DetailExport Detail = new DetailExport();
                    Detail.IDBill = Bill.ID;
                    Detail.IDProduct = Convert.ToInt16(DgvExpPro.Rows[i].Cells["ID"].Value.ToString());
                    var res = db.DetailExports.Where(p => p.IDBill == Detail.IDBill && p.IDProduct == Detail.IDProduct).SingleOrDefault();
                    if (res != null)
                    {
                        res.Quantity = res.Quantity + Convert.ToInt16(DgvExpPro.Rows[i].Cells["Quantity"].Value.ToString());
                        db.SaveChanges();
                    }
                    else
                    {
                        Detail.Quantity = Convert.ToInt16(DgvExpPro.Rows[i].Cells["Quantity"].Value.ToString());
                        db.DetailExports.Add(Detail);
                        db.SaveChanges();
                    }
                }
                db.SaveChanges();
                LoadDgv();
                LoadDetail();
                LoadDgvPro();
                LoadDetailPro();
            }
            else return;

        }

        private void BtExpDeletePro_Click(object sender, EventArgs e)
        {
            List<DetailExport> List = new List<DetailExport>();
            var IdBill = DgvExp.CurrentRow.Cells["ID"].Value.ToString();
            int Bill = Convert.ToInt16(IdBill);
            for (int i = 0; i < DgvExpPro.RowCount; i++)
            {
                DetailExport ExpPro = new DetailExport();
                var str = DgvExpPro.Rows[i].Cells["ID"].Value.ToString();
                ExpPro.IDProduct = Convert.ToInt16(str);
                ExpPro.IDBill = Bill;
                var quan = DgvExpPro.Rows[i].Cells["Quantity"].Value.ToString();
                ExpPro.Quantity = Convert.ToInt16(quan);
                List.Add(ExpPro);
            }
            var IdPro = DgvExpPro.CurrentRow.Cells["ID"].Value.ToString();
            int Pro = Convert.ToInt16(IdPro);
            var ProExp = List.Where(p => p.IDProduct == Pro).SingleOrDefault();
            List.Remove(ProExp);
            LoadPro(List);
            TxtExpProCode.Clear();
            TxtExpProName.Clear();
            TxtExpProUnit.Clear();
            TxtExpProQuan.Clear();
        }

        private void TxtExpStoID_TextChanged(object sender, EventArgs e)
        {
            if(TxtExpStoID.Text != "")
            {
                int ID = Convert.ToInt16(TxtExpStoID.Text);
                var result = db.Storekeepers.Where(p => p.ID == ID).SingleOrDefault();
                if (result != null)
                {
                    TxtExpStorekeeper.Text = result.Name;
                }
                else
                {
                    TxtExpStorekeeper.Clear();
                }
            }
        }

        private void BtExpDelete_Click(object sender, EventArgs e)
        {
            var IdBill = DgvExp.CurrentRow.Cells["ID"].Value.ToString();
            int ID = Convert.ToInt16(IdBill);
            var result = db.DetailExports.Where(p => p.IDBill == ID).ToList();
            if (MessageBox.Show("Do you want to delete item?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                for (int i = 0; i < result.Count; i++)
                {
                    db.DetailExports.Remove(result[i]);
                    db.SaveChanges();
                }
                var Bill = db.BillExports.Find(ID);
                db.BillExports.Remove(Bill);
                db.SaveChanges();
                LoadDgv();
                LoadDetail();
                LoadDgvPro();
                LoadDetailPro();
            }
            else return;  

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
