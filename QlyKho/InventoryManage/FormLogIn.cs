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
    
    public partial class FormLogIn : Form
    {
        
        public FormLogIn()
        {
            InitializeComponent();
        }
        MyContext db = new MyContext();
        private void BtLog_Click(object sender, EventArgs e)
        {
            if(TxtLogName.Text == "" || TxtLogPass.Text == "")
            {
                MessageBox.Show("Nhập vào UserName và PassWord");
                return;
            }
            else
            {
                var result = db.Users.Where(p => p.UserName == TxtLogName.Text && p.Pass == TxtLogPass.Text).SingleOrDefault();
                if(result == null)
                {
                    MessageBox.Show("Tài khoản bạn nhập vào không đúng");
                    TxtLogName.Clear();
                    TxtLogPass.Clear();
                }
                else
                {
                    this.Hide();
                    MessageBox.Show("Đăng nhập thành công");
                    Medium.IdSto = result.ID;
                    Medium.Active = true;
                    FormHome f = new FormHome();
                    f.Show();
                }
            }
        }
    }
}
