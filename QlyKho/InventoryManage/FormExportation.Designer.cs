namespace InventoryManage
{
    partial class FormExportation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExportation));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtExpDeletePro = new System.Windows.Forms.Button();
            this.BtExpEditPro = new System.Windows.Forms.Button();
            this.BtExpAddPro = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.DgvExpPro = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TxtExpProUnit = new System.Windows.Forms.TextBox();
            this.CbExpProSup = new System.Windows.Forms.ComboBox();
            this.TxtExpProQuan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtExpProName = new System.Windows.Forms.TextBox();
            this.TxtExpProCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.BtExpCreate = new System.Windows.Forms.ToolStripButton();
            this.BtExpEdit = new System.Windows.Forms.ToolStripButton();
            this.BtExpDelete = new System.Windows.Forms.ToolStripButton();
            this.BtExpBack = new System.Windows.Forms.ToolStripButton();
            this.BtExpFresh = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DgvExp = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtExpStoID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BtExpCreateCust = new System.Windows.Forms.Button();
            this.DateExp = new System.Windows.Forms.DateTimePicker();
            this.CbExpCustomer = new System.Windows.Forms.ComboBox();
            this.TxtExpStorekeeper = new System.Windows.Forms.TextBox();
            this.TxtExpDeliver = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TxtExpSearch = new System.Windows.Forms.ToolStripTextBox();
            this.BtExpSearch = new System.Windows.Forms.ToolStripButton();
            this.CmbExp = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvExpPro)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvExp)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BtExpDeletePro);
            this.panel1.Controls.Add(this.BtExpEditPro);
            this.panel1.Controls.Add(this.BtExpAddPro);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Location = new System.Drawing.Point(527, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 375);
            this.panel1.TabIndex = 12;
            // 
            // BtExpDeletePro
            // 
            this.BtExpDeletePro.BackColor = System.Drawing.Color.MediumAquamarine;
            this.BtExpDeletePro.Location = new System.Drawing.Point(300, 328);
            this.BtExpDeletePro.Name = "BtExpDeletePro";
            this.BtExpDeletePro.Size = new System.Drawing.Size(92, 27);
            this.BtExpDeletePro.TabIndex = 4;
            this.BtExpDeletePro.Text = "Delete Product";
            this.BtExpDeletePro.UseVisualStyleBackColor = false;
            this.BtExpDeletePro.Visible = false;
            this.BtExpDeletePro.Click += new System.EventHandler(this.BtExpDeletePro_Click);
            // 
            // BtExpEditPro
            // 
            this.BtExpEditPro.BackColor = System.Drawing.Color.MediumAquamarine;
            this.BtExpEditPro.Location = new System.Drawing.Point(168, 328);
            this.BtExpEditPro.Name = "BtExpEditPro";
            this.BtExpEditPro.Size = new System.Drawing.Size(96, 27);
            this.BtExpEditPro.TabIndex = 3;
            this.BtExpEditPro.Text = "Edit Product";
            this.BtExpEditPro.UseVisualStyleBackColor = false;
            this.BtExpEditPro.Visible = false;
            this.BtExpEditPro.Click += new System.EventHandler(this.BtExpEditPro_Click);
            // 
            // BtExpAddPro
            // 
            this.BtExpAddPro.BackColor = System.Drawing.Color.MediumAquamarine;
            this.BtExpAddPro.Location = new System.Drawing.Point(34, 328);
            this.BtExpAddPro.Name = "BtExpAddPro";
            this.BtExpAddPro.Size = new System.Drawing.Size(90, 27);
            this.BtExpAddPro.TabIndex = 2;
            this.BtExpAddPro.Text = "Add Product";
            this.BtExpAddPro.UseVisualStyleBackColor = false;
            this.BtExpAddPro.Visible = false;
            this.BtExpAddPro.Click += new System.EventHandler(this.BtExpAddPro_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox5.BackgroundImage")));
            this.groupBox5.Controls.Add(this.DgvExpPro);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox5.Location = new System.Drawing.Point(12, 122);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(386, 200);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Danh sách sản phẩm";
            // 
            // DgvExpPro
            // 
            this.DgvExpPro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvExpPro.Location = new System.Drawing.Point(12, 21);
            this.DgvExpPro.Name = "DgvExpPro";
            this.DgvExpPro.Size = new System.Drawing.Size(358, 171);
            this.DgvExpPro.TabIndex = 1;
            this.DgvExpPro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvExpPro_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Teal;
            this.groupBox4.Controls.Add(this.TxtExpProUnit);
            this.groupBox4.Controls.Add(this.CbExpProSup);
            this.groupBox4.Controls.Add(this.TxtExpProQuan);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.TxtExpProName);
            this.groupBox4.Controls.Add(this.TxtExpProCode);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox4.Location = new System.Drawing.Point(12, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(386, 100);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chi tiết sản phẩm";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // TxtExpProUnit
            // 
            this.TxtExpProUnit.Enabled = false;
            this.TxtExpProUnit.Location = new System.Drawing.Point(334, 27);
            this.TxtExpProUnit.Name = "TxtExpProUnit";
            this.TxtExpProUnit.Size = new System.Drawing.Size(48, 22);
            this.TxtExpProUnit.TabIndex = 18;
            // 
            // CbExpProSup
            // 
            this.CbExpProSup.Enabled = false;
            this.CbExpProSup.FormattingEnabled = true;
            this.CbExpProSup.Location = new System.Drawing.Point(268, 53);
            this.CbExpProSup.Name = "CbExpProSup";
            this.CbExpProSup.Size = new System.Drawing.Size(112, 24);
            this.CbExpProSup.TabIndex = 17;
            // 
            // TxtExpProQuan
            // 
            this.TxtExpProQuan.Enabled = false;
            this.TxtExpProQuan.Location = new System.Drawing.Point(234, 27);
            this.TxtExpProQuan.Name = "TxtExpProQuan";
            this.TxtExpProQuan.Size = new System.Drawing.Size(42, 22);
            this.TxtExpProQuan.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(285, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Đơn vị";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(167, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Số lượng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(167, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "Nhà phân phối";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // TxtExpProName
            // 
            this.TxtExpProName.Enabled = false;
            this.TxtExpProName.Location = new System.Drawing.Point(53, 55);
            this.TxtExpProName.Name = "TxtExpProName";
            this.TxtExpProName.Size = new System.Drawing.Size(101, 22);
            this.TxtExpProName.TabIndex = 11;
            // 
            // TxtExpProCode
            // 
            this.TxtExpProCode.Enabled = false;
            this.TxtExpProCode.Location = new System.Drawing.Point(53, 24);
            this.TxtExpProCode.Name = "TxtExpProCode";
            this.TxtExpProCode.Size = new System.Drawing.Size(101, 22);
            this.TxtExpProCode.TabIndex = 10;
            this.TxtExpProCode.TextChanged += new System.EventHandler(this.TxtExpProCode_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Teal;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Code";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(6, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tên";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.toolStrip2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.Location = new System.Drawing.Point(12, 415);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(898, 56);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Function";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtExpCreate,
            this.BtExpEdit,
            this.BtExpDelete,
            this.BtExpBack,
            this.BtExpFresh});
            this.toolStrip2.Location = new System.Drawing.Point(3, 18);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(892, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // BtExpCreate
            // 
            this.BtExpCreate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BtExpCreate.Image = global::InventoryManage.Properties.Resources.Add;
            this.BtExpCreate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtExpCreate.Margin = new System.Windows.Forms.Padding(70, 1, 0, 2);
            this.BtExpCreate.Name = "BtExpCreate";
            this.BtExpCreate.Size = new System.Drawing.Size(113, 22);
            this.BtExpCreate.Text = "Create Receipt";
            this.BtExpCreate.Visible = false;
            this.BtExpCreate.Click += new System.EventHandler(this.BtExpCreate_Click);
            // 
            // BtExpEdit
            // 
            this.BtExpEdit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BtExpEdit.Image = global::InventoryManage.Properties.Resources.Edit;
            this.BtExpEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtExpEdit.Margin = new System.Windows.Forms.Padding(70, 1, 0, 2);
            this.BtExpEdit.Name = "BtExpEdit";
            this.BtExpEdit.Size = new System.Drawing.Size(97, 22);
            this.BtExpEdit.Text = "Edit Receipt";
            this.BtExpEdit.Visible = false;
            this.BtExpEdit.Click += new System.EventHandler(this.BtExpEdit_Click);
            // 
            // BtExpDelete
            // 
            this.BtExpDelete.Image = global::InventoryManage.Properties.Resources.delete;
            this.BtExpDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtExpDelete.Margin = new System.Windows.Forms.Padding(70, 1, 0, 2);
            this.BtExpDelete.Name = "BtExpDelete";
            this.BtExpDelete.Size = new System.Drawing.Size(102, 22);
            this.BtExpDelete.Text = "Delete Receipt";
            this.BtExpDelete.Visible = false;
            this.BtExpDelete.Click += new System.EventHandler(this.BtExpDelete_Click);
            // 
            // BtExpBack
            // 
            this.BtExpBack.Image = global::InventoryManage.Properties.Resources.Previous;
            this.BtExpBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtExpBack.Margin = new System.Windows.Forms.Padding(70, 1, 0, 2);
            this.BtExpBack.Name = "BtExpBack";
            this.BtExpBack.Size = new System.Drawing.Size(52, 22);
            this.BtExpBack.Text = "Back";
            this.BtExpBack.Click += new System.EventHandler(this.BtExpBack_Click);
            // 
            // BtExpFresh
            // 
            this.BtExpFresh.Image = global::InventoryManage.Properties.Resources.repeat_128;
            this.BtExpFresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtExpFresh.Margin = new System.Windows.Forms.Padding(70, 1, 0, 2);
            this.BtExpFresh.Name = "BtExpFresh";
            this.BtExpFresh.Size = new System.Drawing.Size(55, 22);
            this.BtExpFresh.Text = "Fresh";
            this.BtExpFresh.Visible = false;
            this.BtExpFresh.Click += new System.EventHandler(this.BtExpFresh_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.Controls.Add(this.DgvExp);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(509, 275);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách hóa đơn";
            // 
            // DgvExp
            // 
            this.DgvExp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvExp.Location = new System.Drawing.Point(21, 27);
            this.DgvExp.Name = "DgvExp";
            this.DgvExp.Size = new System.Drawing.Size(479, 230);
            this.DgvExp.TabIndex = 0;
            this.DgvExp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvExp_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Teal;
            this.groupBox1.Controls.Add(this.TxtExpStoID);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.BtExpCreateCust);
            this.groupBox1.Controls.Add(this.DateExp);
            this.groupBox1.Controls.Add(this.CbExpCustomer);
            this.groupBox1.Controls.Add(this.TxtExpStorekeeper);
            this.groupBox1.Controls.Add(this.TxtExpDeliver);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 93);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết hóa đơn xuất kho";
            // 
            // TxtExpStoID
            // 
            this.TxtExpStoID.Enabled = false;
            this.TxtExpStoID.Location = new System.Drawing.Point(462, 65);
            this.TxtExpStoID.Name = "TxtExpStoID";
            this.TxtExpStoID.Size = new System.Drawing.Size(41, 22);
            this.TxtExpStoID.TabIndex = 14;
            this.TxtExpStoID.TextChanged += new System.EventHandler(this.TxtExpStoID_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(435, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "ID";
            // 
            // BtExpCreateCust
            // 
            this.BtExpCreateCust.Enabled = false;
            this.BtExpCreateCust.Image = global::InventoryManage.Properties.Resources.them;
            this.BtExpCreateCust.Location = new System.Drawing.Point(180, 25);
            this.BtExpCreateCust.Name = "BtExpCreateCust";
            this.BtExpCreateCust.Size = new System.Drawing.Size(27, 24);
            this.BtExpCreateCust.TabIndex = 12;
            this.BtExpCreateCust.UseVisualStyleBackColor = true;
            this.BtExpCreateCust.Click += new System.EventHandler(this.BtExpCreateCust_Click);
            // 
            // DateExp
            // 
            this.DateExp.CustomFormat = " dd / MM / yyy";
            this.DateExp.Enabled = false;
            this.DateExp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateExp.Location = new System.Drawing.Point(348, 24);
            this.DateExp.Name = "DateExp";
            this.DateExp.Size = new System.Drawing.Size(152, 22);
            this.DateExp.TabIndex = 11;
            // 
            // CbExpCustomer
            // 
            this.CbExpCustomer.Enabled = false;
            this.CbExpCustomer.FormattingEnabled = true;
            this.CbExpCustomer.Location = new System.Drawing.Point(84, 26);
            this.CbExpCustomer.Name = "CbExpCustomer";
            this.CbExpCustomer.Size = new System.Drawing.Size(90, 24);
            this.CbExpCustomer.TabIndex = 10;
            // 
            // TxtExpStorekeeper
            // 
            this.TxtExpStorekeeper.Enabled = false;
            this.TxtExpStorekeeper.Location = new System.Drawing.Point(320, 65);
            this.TxtExpStorekeeper.Name = "TxtExpStorekeeper";
            this.TxtExpStorekeeper.Size = new System.Drawing.Size(109, 22);
            this.TxtExpStorekeeper.TabIndex = 6;
            // 
            // TxtExpDeliver
            // 
            this.TxtExpDeliver.Enabled = false;
            this.TxtExpDeliver.Location = new System.Drawing.Point(84, 65);
            this.TxtExpDeliver.Name = "TxtExpDeliver";
            this.TxtExpDeliver.Size = new System.Drawing.Size(123, 22);
            this.TxtExpDeliver.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(0, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(231, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày xuất kho";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(231, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chủ kho";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(6, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giao hàng";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TxtExpSearch,
            this.BtExpSearch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(951, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TxtExpSearch
            // 
            this.TxtExpSearch.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.TxtExpSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtExpSearch.Margin = new System.Windows.Forms.Padding(300, 0, 1, 0);
            this.TxtExpSearch.Name = "TxtExpSearch";
            this.TxtExpSearch.Size = new System.Drawing.Size(100, 25);
            this.TxtExpSearch.Text = "Điền thông tin";
            this.TxtExpSearch.Click += new System.EventHandler(this.TxtExpSearch_Click);
            // 
            // BtExpSearch
            // 
            this.BtExpSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtExpSearch.Image = global::InventoryManage.Properties.Resources.search;
            this.BtExpSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtExpSearch.Name = "BtExpSearch";
            this.BtExpSearch.Size = new System.Drawing.Size(77, 22);
            this.BtExpSearch.Text = "Tìm kiếm";
            this.BtExpSearch.Click += new System.EventHandler(this.BtExpSearch_Click);
            // 
            // CmbExp
            // 
            this.CmbExp.FormattingEnabled = true;
            this.CmbExp.Items.AddRange(new object[] {
            "Id of Receipt",
            "Name of Storekeeper",
            "Name of Customer",
            "Date of Exporting",
            "Year of Exporting"});
            this.CmbExp.Location = new System.Drawing.Point(178, 0);
            this.CmbExp.Name = "CmbExp";
            this.CmbExp.Size = new System.Drawing.Size(121, 21);
            this.CmbExp.TabIndex = 13;
            // 
            // FormExportation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(951, 483);
            this.Controls.Add(this.CmbExp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormExportation";
            this.Text = "FormExportation";
            this.Load += new System.EventHandler(this.FormExportation_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvExpPro)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvExp)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView DgvExpPro;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox TxtExpProUnit;
        private System.Windows.Forms.ComboBox CbExpProSup;
        private System.Windows.Forms.TextBox TxtExpProQuan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtExpProName;
        private System.Windows.Forms.TextBox TxtExpProCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton BtExpCreate;
        private System.Windows.Forms.ToolStripButton BtExpEdit;
        private System.Windows.Forms.ToolStripButton BtExpDelete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DgvExp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker DateExp;
        private System.Windows.Forms.ComboBox CbExpCustomer;
        private System.Windows.Forms.TextBox TxtExpStorekeeper;
        private System.Windows.Forms.TextBox TxtExpDeliver;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox TxtExpSearch;
        private System.Windows.Forms.ToolStripButton BtExpSearch;
        private System.Windows.Forms.Button BtExpCreateCust;
        private System.Windows.Forms.ToolStripButton BtExpBack;
        private System.Windows.Forms.ToolStripButton BtExpFresh;
        private System.Windows.Forms.Button BtExpEditPro;
        private System.Windows.Forms.Button BtExpAddPro;
        private System.Windows.Forms.Button BtExpDeletePro;
        private System.Windows.Forms.TextBox TxtExpStoID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CmbExp;
    }
}