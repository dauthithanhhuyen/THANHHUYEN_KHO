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
    public partial class FormImportations : Form
    {
        public FormImportations()
        {
            InitializeComponent();
        }
        MyContext db = new MyContext();
       

        public void LoadDgv()
        {
            var result = from c in db.BillImports
                         select new
                         {
                             ID = c.ID,
                             Supplier = c.Company.Name,
                             Deliver = c.NameCustom,
                             Storekeeper = c.Storekeeper.Name,
                             Date = c.DateImport,
                         };
            DgvImp.DataSource = result.ToList();
            DgvImp.Columns["ID"].Width = 50;
            DgvImp.Columns["Supplier"].Width = 70;
            DgvImp.Columns["Deliver"].Width = 120;
            DgvImp.Columns["Storekeeper"].Width = 120;
            DgvImp.Columns["Date"].Width = 100;
        }
        public void LoadCbSup()
        {
            var result = db.Companys.ToList();
            CbImpSupplier.DataSource = result;
            CbImpSupplier.ValueMember = "ID";
            CbImpSupplier.DisplayMember = "Name";
        }
        public void LoadCbProSup()
        {
            var result = db.Companys.ToList();
            CbImpProSup.DataSource = result;
            CbImpProSup.ValueMember = "ID";
            CbImpProSup.DisplayMember = "Name";
        }
        public void LoadDetail()
        {
            string Id = DgvImp.CurrentRow.Cells["ID"].Value.ToString();
            int IdBill = Convert.ToInt32(Id);
            var result = db.BillImports.Where(p => p.ID == IdBill).SingleOrDefault();
            TxtImpDeliver.Text = result.NameCustom;
            TxtImpStoID.Text = result.IDStoreKeeper.ToString();
            TxtImpStorekeeper.Text = DgvImp.CurrentRow.Cells["Storekeeper"].Value.ToString();
            CbImpSupplier.SelectedValue = result.IDCompany;
            DateImp.Value = DateTime.Parse(result.DateImport.ToString());
        }
        public void LoadDetailPro()
        {
            var IdBill = DgvImp.CurrentRow.Cells["ID"].Value.ToString();
            int Bill = Convert.ToInt16(IdBill);
            string IdPro = DgvImpPro.CurrentRow.Cells["ID"].Value.ToString();
            int Pro = Convert.ToInt16(IdPro);
            var ImpProduct = db.DetailImports.Where(p => p.IDBill == Bill && p.IDProduct == Pro).SingleOrDefault();
            TxtImpProName.Text = ImpProduct.Product.Name;
            TxtImpProCode.Text = ImpProduct.Product.Code;
            TxtImpProQuan.Text = ImpProduct.Quantity.ToString();
            TxtImpProUnit.Text = ImpProduct.Product.Unit;
            CbImpProSup.SelectedValue = ImpProduct.Product.IdCom;
        }
        private void FormImportations_Load(object sender, EventArgs e)
        {
            if(Medium.Active == true)
            {
                TxtImpDeliver.Enabled = true;
                TxtImpProCode.Enabled = true;
                TxtImpProName.Enabled = true;
                TxtImpProQuan.Enabled = true;
                TxtImpProUnit.Enabled = true;
                TxtImpStorekeeper.Enabled = true;
                BtImpCreateSup.Enabled = true;
                BtImpProCreate.Enabled = true;
                CbImpProSup.Enabled = true;
                CbImpSupplier.Enabled = true;
                BtImpCreate.Visible = true;
                BtImpDelete.Visible = true;
                BtImpEdit.Visible = true;
                DateImp.Enabled = true;
                BtImpAddPro.Visible = true;
                BtImpDeletePro.Visible = true;
                BtImpEditPro.Visible = true;
                BtImpFresh.Visible = true;
                TxtImpStoID.Enabled = true;
            }
            LoadDgv();
            LoadCbSup();
            LoadDetail();
            LoadDgvPro();
            LoadCbProSup();
            LoadDetailPro();
        }

        private void DgvImp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadDetail();
            LoadDgvPro();
            LoadDetailPro();
        }

        private void DgvImpPro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadDetailPro();
        }

        private void BtImpBack_Click(object sender, EventArgs e)
        {
            FormHome f = new FormHome();
            f.Show();
            this.Hide();
        }

        private void TxtImpSearch_Click(object sender, EventArgs e)
        {
            TxtImpSearch.Clear();
        }

        private void BtImpSearch_Click(object sender, EventArgs e)
        {
            if (CmbImp.Text == "Id of Receipt")
            {
                int Key = Convert.ToInt32(TxtImpSearch.Text);
                var Bill = db.BillImports.Where(p => p.ID == Key).SingleOrDefault();
                if (Bill != null)
                {
                    for (int i = 0; i < DgvImp.RowCount; i++)
                    {
                        if (DgvImp.Rows[i].Cells[0].Value.ToString().Trim() == Bill.ID.ToString())
                        {
                            DgvImp.Rows[i].Selected = true;
                            DgvImp.CurrentCell = DgvImp.Rows[i].Cells[0];
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
            else if (CmbImp.Text == "Name of Storekeeper")
            {
                var result = from c in db.BillImports
                             where c.Storekeeper.Name.Contains(TxtImpSearch.Text)
                             select new
                             {
                                 ID = c.ID,
                                 Supplier = c.Company.Name,
                                 Deliver = c.NameCustom,
                                 Storekeeper = c.Storekeeper.Name,
                                 Date = c.DateImport,
                             };
                var Bill = result.ToList();
                if (Bill.Count != 0)
                {
                    DgvImp.DataSource = Bill;
                    DgvImp.Columns["ID"].Width = 50;
                    DgvImp.Columns["Supplier"].Width = 70;
                    DgvImp.Columns["Deliver"].Width = 120;
                    DgvImp.Columns["Storekeeper"].Width = 120;
                    DgvImp.Columns["Date"].Width = 100;
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
            else if (CmbImp.Text == "Name of Supplier")
            {
                var result = from c in db.BillImports
                             where c.Company.Name.Contains(TxtImpSearch.Text)
                             select new
                             {
                                 ID = c.ID,
                                 Supplier = c.Company.Name,
                                 Deliver = c.NameCustom,
                                 Storekeeper = c.Storekeeper.Name,
                                 Date = c.DateImport,
                             };
                var Bill = result.ToList();
                if (Bill.Count != 0)
                {
                    DgvImp.DataSource = Bill;
                    DgvImp.Columns["ID"].Width = 50;
                    DgvImp.Columns["Supplier"].Width = 70;
                    DgvImp.Columns["Deliver"].Width = 120;
                    DgvImp.Columns["Storekeeper"].Width = 120;
                    DgvImp.Columns["Date"].Width = 100;
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
            else if (CmbImp.Text == "Date of Importing")
            {
                var day = DateTime.Parse(TxtImpSearch.Text);
                var result = from c in db.BillImports
                             where c.DateImport == day
                             select new
                             {
                                 ID = c.ID,
                                 Supplier = c.Company.Name,
                                 Deliver = c.NameCustom,
                                 Storekeeper = c.Storekeeper.Name,
                                 Date = c.DateImport,
                             };
                var Bill = result.ToList();
                if (Bill.Count != 0)
                {
                    DgvImp.DataSource = Bill;
                    DgvImp.Columns["ID"].Width = 50;
                    DgvImp.Columns["Supplier"].Width = 70;
                    DgvImp.Columns["Deliver"].Width = 120;
                    DgvImp.Columns["Storekeeper"].Width = 120;
                    DgvImp.Columns["Date"].Width = 100;
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
            else if (CmbImp.Text == "Month of Importing")
            {
                var s = TxtImpSearch.Text;
                string[] m;
                m = s.Split('/');
                int month = Convert.ToInt16(m[0]);
                int year = Convert.ToInt16(m[1]);
                var result = from c in db.BillImports
                             where c.DateImport.Value.Month == month && c.DateImport.Value.Year == year
                             select new
                             {
                                 ID = c.ID,
                                 Supplier = c.Company.Name,
                                 Deliver = c.NameCustom,
                                 Storekeeper = c.Storekeeper.Name,
                                 Date = c.DateImport,
                             };
                var Bill = result.ToList();
                if (Bill.Count != 0)
                {
                    DgvImp.DataSource = Bill;
                    DgvImp.Columns["ID"].Width = 50;
                    DgvImp.Columns["Supplier"].Width = 70;
                    DgvImp.Columns["Deliver"].Width = 120;
                    DgvImp.Columns["Storekeeper"].Width = 120;
                    DgvImp.Columns["Date"].Width = 100;
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
                int year = Convert.ToInt16(TxtImpSearch.Text);
                // var year = DateTime.Parse(TxtImpSearch.Text).Year;
                var result = from c in db.BillImports
                             where c.DateImport.Value.Year == year
                             select new
                             {
                                 ID = c.ID,
                                 Supplier = c.Company.Name,
                                 Deliver = c.NameCustom,
                                 Storekeeper = c.Storekeeper.Name,
                                 Date = c.DateImport,
                             };
                var Bill = result.ToList();
                if (Bill.Count != 0)
                {
                    DgvImp.DataSource = Bill;
                    DgvImp.Columns["ID"].Width = 50;
                    DgvImp.Columns["Supplier"].Width = 70;
                    DgvImp.Columns["Deliver"].Width = 120;
                    DgvImp.Columns["Storekeeper"].Width = 120;
                    DgvImp.Columns["Date"].Width = 100;
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

        private void BtImpCreateSup_Click(object sender, EventArgs e)
        {
            //FormSuppliers f = new FormSuppliers();
            //  this.Hide();
            //  Medium.FormSup = true;
            //  f.Show();
            Medium.FormSup = true;
            FormSuppliers f = new FormSuppliers();
            f.Show();
            this.Hide();
        }
    

        private void BtImpProCreate_Click(object sender, EventArgs e)
        {
            FormProducts f = new FormProducts();
            this.Hide();
            Medium.FormPro = true;
            f.Show();
        }
        private void LoadPro(List<DetailImport> list)
        {

            List<ProductImp> ListProImp = new List<ProductImp>();
            for (int i = 0; i < list.Count; i++)
            {
                ProductImp ProImp = new ProductImp();
                ProImp.ID = list[i].IDProduct;
                ProImp.Quantity = list[i].Quantity;
                var Pro = db.Products.Find(ProImp.ID);
                ProImp.Name = Pro.Name;
                ProImp.Unit = Pro.Unit;
                //ProImp.Company = Pro.Company.Name;
                ProImp.Code = Pro.Code;
                ListProImp.Add(ProImp);
            }
            DgvImpPro.DataSource = ListProImp;
            DgvImpPro.Columns["ID"].Width = 50;
            // DgvImpPro.Columns["ID1"].HeaderText = "ID";
            DgvImpPro.Columns["Code"].Width = 70;
            // DgvImpPro.Columns["Code1"].HeaderText = "Code";
            DgvImpPro.Columns["Name"].Width = 80;
            // DgvImpPro.Columns["Name1"].HeaderText = "Name";
            DgvImpPro.Columns["Quantity"].Width = 60;
            //DgvImpPro.Columns["Quan1"].HeaderText = "Quantity";
            DgvImpPro.Columns["Unit"].Width = 60;
            //DgvImpPro.Columns["Unit1"].HeaderText = "Unit";
            // DgvImpPro.Columns["Company"].Width = 70;
            // DgvImpPro.Columns["Company1"].HeaderText = "Supplier";
        }
        private void BtImpAddPro_Click(object sender, EventArgs e)
        {
            List<DetailImport> ListPro = new List<DetailImport>();
            DetailImport ProImp = new DetailImport();
            var Id = Convert.ToInt32(DgvImp.CurrentRow.Cells["ID"].Value.ToString());
            for (int i = 0; i < DgvImpPro.RowCount; i++)
            {
                var str = DgvImpPro.Rows[i].Cells["ID"].Value.ToString();
                var IDProduct = Convert.ToInt16(str);
                var Detail = db.DetailImports.Where(p => p.IDBill == Id && p.IDProduct == IDProduct).SingleOrDefault();
                ListPro.Add(Detail);
            }
            var result = db.Products.Where(p => p.Code == TxtImpProCode.Text).SingleOrDefault();
            if (result == null)
            {
                MessageBox.Show("There isn't this item in the storehouse, Click to add product");
                return;
            }
            else
            {
                TxtImpProName.Text = result.Name;
                TxtImpProUnit.Text = result.Unit;
                CbImpProSup.SelectedValue = result.IdCom;
                ProImp.IDBill = Id;
                ProImp.IDProduct = result.ID;
                ProImp.Quantity = Convert.ToInt16(TxtImpProQuan.Text);
                ListPro.Add(ProImp);
                LoadPro(ListPro);
            }

        }

        private void BtImpEditPro_Click(object sender, EventArgs e)
        {
            var IdBill = Convert.ToInt16(DgvImp.CurrentRow.Cells["ID"].Value.ToString());
            List<DetailImport> List = new List<DetailImport>();

            for (int i = 0; i < DgvImpPro.RowCount; i++)
            {
                DetailImport Pro = new DetailImport();
                var str = DgvImpPro.Rows[i].Cells["ID"].Value.ToString();
                Pro.IDProduct = Convert.ToInt16(str);
                Pro.IDBill = IdBill;
                var Quan = DgvImpPro.Rows[i].Cells["Quantity"].Value.ToString();
                Pro.Quantity = Convert.ToInt16(Quan);
                //var Detail = db.DetailImports.Where(p => p.IDBill == IdBill && p.IDProduct == IDProduct).SingleOrDefault();
                List.Add(Pro);
            }
            var IDPro = Convert.ToInt16(DgvImpPro.CurrentRow.Cells["ID"].Value.ToString());
            var result = db.Products.Find(IDPro);
            var ProImp = List.Where(p => p.IDBill == IdBill && p.IDProduct == IDPro).SingleOrDefault();
            List.Remove(ProImp);
            DetailImport ImpPro = new DetailImport();
            ImpPro.IDBill = IdBill;
            ImpPro.IDProduct = IDPro;
            string quan = TxtImpProQuan.Text;
            ImpPro.Quantity = Convert.ToInt16(quan);
            List.Add(ImpPro);
            LoadPro(List);
        }

        private void BtImpDeletePro_Click(object sender, EventArgs e)
        {
            List<DetailImport> List = new List<DetailImport>();
            var IdBill = DgvImp.CurrentRow.Cells["ID"].Value.ToString();
            int Bill = Convert.ToInt16(IdBill);
            for (int i = 0; i < DgvImpPro.RowCount; i++)
            {
                DetailImport ImpPro = new DetailImport();
                var str = DgvImpPro.Rows[i].Cells["ID"].Value.ToString();
                ImpPro.IDProduct = Convert.ToInt16(str);
                ImpPro.IDBill = Bill;
                var quan = DgvImpPro.Rows[i].Cells["Quantity"].Value.ToString();
                ImpPro.Quantity = Convert.ToInt16(quan);
                List.Add(ImpPro);
            }
            var IdPro = DgvImpPro.CurrentRow.Cells["ID"].Value.ToString();
            int Pro = Convert.ToInt16(IdPro);
            var ProImp = List.Where(p => p.IDProduct == Pro).SingleOrDefault();
            List.Remove(ProImp);
            LoadPro(List);
            TxtImpProCode.Clear();
            TxtImpProName.Clear();
            TxtImpProUnit.Clear();
            TxtImpProQuan.Clear();
        }

        private void BtImpFresh_Click(object sender, EventArgs e)
        {
            TxtImpDeliver.Clear();
            TxtImpProCode.Clear();
            TxtImpProName.Clear();
            TxtImpProQuan.Clear();
            TxtImpProUnit.Clear();
            var result = db.Storekeepers.Find(Medium.IdSto);
            TxtImpStoID.Text = result.ID.ToString();
            TxtImpStorekeeper.Text = result.Name;
            DgvImpPro.DataSource = null;
        }

        private void BtImpCreate_Click(object sender, EventArgs e)
        {
            if (TxtImpStorekeeper.Text == "" || TxtImpDeliver.Text == "")
            {
                MessageBox.Show("Fill in all information");
                return;
            }
            BillImport Bill = new BillImport();
            Bill.IDCompany = Convert.ToInt16(CbImpSupplier.SelectedValue.ToString());
            Bill.IDStoreKeeper = Medium.IdSto;
            Bill.NameCustom = TxtImpDeliver.Text;
            Bill.DateImport = DateImp.Value;
            db.BillImports.Add(Bill);
            db.SaveChanges();
            for (int i = 0; i < DgvImpPro.RowCount; i++)
            {
                DetailImport Detail = new DetailImport();
                Detail.IDBill = Bill.ID;
                Detail.IDProduct = Convert.ToInt16(DgvImpPro.Rows[i].Cells["ID"].Value.ToString());
                var res = db.DetailImports.Where(p => p.IDBill == Detail.IDBill && p.IDProduct == Detail.IDProduct).SingleOrDefault();
                if (res != null)
                {
                    res.Quantity = res.Quantity + Convert.ToInt16(DgvImpPro.Rows[i].Cells["Quantity"].Value.ToString());
                    db.SaveChanges();
                }
                else
                {
                    Detail.Quantity = Convert.ToInt16(DgvImpPro.Rows[i].Cells["Quantity"].Value.ToString());
                    db.DetailImports.Add(Detail);
                    db.SaveChanges();
                }
            }
            MessageBox.Show("Add Item successfully");
            LoadDgv();
            LoadDetail();
            LoadDgvPro();
            LoadDetailPro();
        }

        private void BtImpEdit_Click(object sender, EventArgs e)
        {
            var IdBill = DgvImp.CurrentRow.Cells["ID"].Value.ToString();
            int ID = Convert.ToInt16(IdBill);
            var Bill = db.BillImports.Find(ID);
            Bill.IDCompany = Convert.ToInt16(CbImpSupplier.SelectedValue.ToString());
            Bill.NameCustom = TxtImpDeliver.Text;
            var IDsto = Convert.ToInt16(TxtImpStoID.Text);
            Bill.IDStoreKeeper = IDsto;
            Bill.DateImport = DateImp.Value;
            if (MessageBox.Show("Do you want to save changes?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                var result = db.DetailImports.Where(p => p.IDBill == ID).ToList();
                for (int i = 0; i < result.Count; i++)
                {
                    db.DetailImports.Remove(result[i]);
                    db.SaveChanges();
                }
                for (int i = 0; i < DgvImpPro.RowCount; i++)
                {
                    DetailImport Detail = new DetailImport();
                    Detail.IDBill = Bill.ID;
                    Detail.IDProduct = Convert.ToInt16(DgvImpPro.Rows[i].Cells["ID"].Value.ToString());
                    var res = db.DetailImports.Where(p => p.IDBill == Detail.IDBill && p.IDProduct == Detail.IDProduct).SingleOrDefault();
                    if (res != null)
                    {
                        res.Quantity = res.Quantity + Convert.ToInt16(DgvImpPro.Rows[i].Cells["Quantity"].Value.ToString());
                        db.SaveChanges();
                    }
                    else
                    {
                        Detail.Quantity = Convert.ToInt16(DgvImpPro.Rows[i].Cells["Quantity"].Value.ToString());
                        db.DetailImports.Add(Detail);
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

        private void BtImpDelete_Click(object sender, EventArgs e)
        {
            var IdBill = DgvImp.CurrentRow.Cells["ID"].Value.ToString();
            int ID = Convert.ToInt16(IdBill);
            var result = db.DetailImports.Where(p => p.IDBill == ID).ToList();
            if (MessageBox.Show("Do you want to delete item?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                for (int i = 0; i < result.Count; i++)
                {
                    db.DetailImports.Remove(result[i]);
                    db.SaveChanges();
                }
                var Bill = db.BillImports.Find(ID);
                db.BillImports.Remove(Bill);
                db.SaveChanges();
                LoadDgv();
                LoadDetail();
                LoadDgvPro();
                LoadDetailPro();
            }
            else return;

        }

        private void TxtImpStoID_TextChanged(object sender, EventArgs e)
        {
            if (TxtImpStoID.Text != "")
            {
                int ID = Convert.ToInt16(TxtImpStoID.Text);
                var result = db.Storekeepers.Where(p => p.ID == ID).SingleOrDefault();
                if (result != null)
                {
                    TxtImpStorekeeper.Text = result.Name;
                }
                else
                {
                    TxtImpStorekeeper.Clear();
                }
            }
        }

        private void TxtImpProCode_TextChanged(object sender, EventArgs e)
        {
            var result = db.Products.Where(p => p.Code == TxtImpProCode.Text).SingleOrDefault();
            if (result != null)
            {
                TxtImpProName.Text = result.Name;
                TxtImpProUnit.Text = result.Unit;
                CbImpProSup.SelectedValue = result.IdCom;
            }
            else
            {
                TxtImpProName.Clear();
                TxtImpProUnit.Clear();
            }
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }
    }
}
