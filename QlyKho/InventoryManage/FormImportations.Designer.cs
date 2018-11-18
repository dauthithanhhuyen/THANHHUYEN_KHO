namespace InventoryManage
{
    partial class FormImportations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImportations));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.BtImpCreate = new System.Windows.Forms.ToolStripButton();
            this.BtImpEdit = new System.Windows.Forms.ToolStripButton();
            this.BtImpDelete = new System.Windows.Forms.ToolStripButton();
            this.BtImpBack = new System.Windows.Forms.ToolStripButton();
            this.BtImpFresh = new System.Windows.Forms.ToolStripButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CbImpSupplier = new System.Windows.Forms.ComboBox();
            this.TxtImpDeliver = new System.Windows.Forms.TextBox();
            this.TxtImpStorekeeper = new System.Windows.Forms.TextBox();
            this.DgvImp = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtImpStoID = new System.Windows.Forms.TextBox();
            this.BtImpCreateSup = new System.Windows.Forms.Button();
            this.DateImp = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtImpSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtImpSearch = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.BtImpDeletePro = new System.Windows.Forms.Button();
            this.BtImpEditPro = new System.Windows.Forms.Button();
            this.BtImpAddPro = new System.Windows.Forms.Button();
            this.DgvImpPro = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtImpProCreate = new System.Windows.Forms.Button();
            this.TxtImpProUnit = new System.Windows.Forms.TextBox();
            this.CbImpProSup = new System.Windows.Forms.ComboBox();
            this.TxtImpProQuan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtImpProName = new System.Windows.Forms.TextBox();
            this.TxtImpProCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CmbImp = new System.Windows.Forms.ComboBox();
            this.toolStrip2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvImp)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvImpPro)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtImpCreate,
            this.BtImpEdit,
            this.BtImpDelete,
            this.BtImpBack,
            this.BtImpFresh});
            this.toolStrip2.Location = new System.Drawing.Point(3, 18);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(892, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // BtImpCreate
            // 
            this.BtImpCreate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BtImpCreate.Image = global::InventoryManage.Properties.Resources.Add;
            this.BtImpCreate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtImpCreate.Margin = new System.Windows.Forms.Padding(70, 1, 0, 2);
            this.BtImpCreate.Name = "BtImpCreate";
            this.BtImpCreate.Size = new System.Drawing.Size(113, 22);
            this.BtImpCreate.Text = "Create Receipt";
            this.BtImpCreate.Visible = false;
            this.BtImpCreate.Click += new System.EventHandler(this.BtImpCreate_Click);
            // 
            // BtImpEdit
            // 
            this.BtImpEdit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BtImpEdit.Image = global::InventoryManage.Properties.Resources.Edit;
            this.BtImpEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtImpEdit.Margin = new System.Windows.Forms.Padding(70, 1, 0, 2);
            this.BtImpEdit.Name = "BtImpEdit";
            this.BtImpEdit.Size = new System.Drawing.Size(97, 22);
            this.BtImpEdit.Text = "Edit Receipt";
            this.BtImpEdit.Visible = false;
            this.BtImpEdit.Click += new System.EventHandler(this.BtImpEdit_Click);
            // 
            // BtImpDelete
            // 
            this.BtImpDelete.Image = global::InventoryManage.Properties.Resources.delete;
            this.BtImpDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtImpDelete.Margin = new System.Windows.Forms.Padding(70, 1, 0, 2);
            this.BtImpDelete.Name = "BtImpDelete";
            this.BtImpDelete.Size = new System.Drawing.Size(102, 22);
            this.BtImpDelete.Text = "Delete Receipt";
            this.BtImpDelete.Visible = false;
            this.BtImpDelete.Click += new System.EventHandler(this.BtImpDelete_Click);
            // 
            // BtImpBack
            // 
            this.BtImpBack.Image = global::InventoryManage.Properties.Resources.Previous;
            this.BtImpBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtImpBack.Margin = new System.Windows.Forms.Padding(70, 1, 0, 2);
            this.BtImpBack.Name = "BtImpBack";
            this.BtImpBack.Size = new System.Drawing.Size(52, 22);
            this.BtImpBack.Text = "Back";
            this.BtImpBack.Click += new System.EventHandler(this.BtImpBack_Click);
            // 
            // BtImpFresh
            // 
            this.BtImpFresh.Image = global::InventoryManage.Properties.Resources.repeat_128;
            this.BtImpFresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtImpFresh.Margin = new System.Windows.Forms.Padding(70, 1, 0, 2);
            this.BtImpFresh.Name = "BtImpFresh";
            this.BtImpFresh.Size = new System.Drawing.Size(55, 22);
            this.BtImpFresh.Text = "Fresh";
            this.BtImpFresh.Visible = false;
            this.BtImpFresh.Click += new System.EventHandler(this.BtImpFresh_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.toolStrip2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.Location = new System.Drawing.Point(21, 446);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(898, 56);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Function";
            // 
            // CbImpSupplier
            // 
            this.CbImpSupplier.Enabled = false;
            this.CbImpSupplier.FormattingEnabled = true;
            this.CbImpSupplier.Location = new System.Drawing.Point(103, 24);
            this.CbImpSupplier.Name = "CbImpSupplier";
            this.CbImpSupplier.Size = new System.Drawing.Size(105, 24);
            this.CbImpSupplier.TabIndex = 10;
            // 
            // TxtImpDeliver
            // 
            this.TxtImpDeliver.Enabled = false;
            this.TxtImpDeliver.Location = new System.Drawing.Point(112, 65);
            this.TxtImpDeliver.Name = "TxtImpDeliver";
            this.TxtImpDeliver.Size = new System.Drawing.Size(138, 22);
            this.TxtImpDeliver.TabIndex = 7;
            // 
            // TxtImpStorekeeper
            // 
            this.TxtImpStorekeeper.Enabled = false;
            this.TxtImpStorekeeper.Location = new System.Drawing.Point(318, 65);
            this.TxtImpStorekeeper.Name = "TxtImpStorekeeper";
            this.TxtImpStorekeeper.Size = new System.Drawing.Size(104, 22);
            this.TxtImpStorekeeper.TabIndex = 6;
            // 
            // DgvImp
            // 
            this.DgvImp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvImp.Location = new System.Drawing.Point(25, 33);
            this.DgvImp.Name = "DgvImp";
            this.DgvImp.Size = new System.Drawing.Size(478, 240);
            this.DgvImp.TabIndex = 0;
            this.DgvImp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvImp_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.Controls.Add(this.DgvImp);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(509, 295);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách hóa đơn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightSalmon;
            this.label5.Location = new System.Drawing.Point(6, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nhà phân phối";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSalmon;
            this.label3.Location = new System.Drawing.Point(256, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày nhập ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSalmon;
            this.label2.Location = new System.Drawing.Point(256, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chủ kho";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSalmon;
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.TxtImpStoID);
            this.groupBox1.Controls.Add(this.BtImpCreateSup);
            this.groupBox1.Controls.Add(this.DateImp);
            this.groupBox1.Controls.Add(this.CbImpSupplier);
            this.groupBox1.Controls.Add(this.TxtImpStorekeeper);
            this.groupBox1.Controls.Add(this.TxtImpDeliver);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 93);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết hóa đơn nhập kho";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.LightSalmon;
            this.label10.Location = new System.Drawing.Point(430, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "ID";
            // 
            // TxtImpStoID
            // 
            this.TxtImpStoID.Enabled = false;
            this.TxtImpStoID.Location = new System.Drawing.Point(459, 65);
            this.TxtImpStoID.Name = "TxtImpStoID";
            this.TxtImpStoID.Size = new System.Drawing.Size(41, 22);
            this.TxtImpStoID.TabIndex = 15;
            this.TxtImpStoID.TextChanged += new System.EventHandler(this.TxtImpStoID_TextChanged);
            // 
            // BtImpCreateSup
            // 
            this.BtImpCreateSup.Enabled = false;
            this.BtImpCreateSup.Image = ((System.Drawing.Image)(resources.GetObject("BtImpCreateSup.Image")));
            this.BtImpCreateSup.Location = new System.Drawing.Point(214, 21);
            this.BtImpCreateSup.Name = "BtImpCreateSup";
            this.BtImpCreateSup.Size = new System.Drawing.Size(27, 24);
            this.BtImpCreateSup.TabIndex = 12;
            this.BtImpCreateSup.UseVisualStyleBackColor = true;
            this.BtImpCreateSup.Click += new System.EventHandler(this.BtImpCreateSup_Click);
            // 
            // DateImp
            // 
            this.DateImp.CustomFormat = " dd / MM / yyy";
            this.DateImp.Enabled = false;
            this.DateImp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateImp.Location = new System.Drawing.Point(348, 24);
            this.DateImp.Name = "DateImp";
            this.DateImp.Size = new System.Drawing.Size(152, 22);
            this.DateImp.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSalmon;
            this.label1.Location = new System.Drawing.Point(6, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Người giao hàng";
            // 
            // TxtImpSearch
            // 
            this.TxtImpSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TxtImpSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtImpSearch.Margin = new System.Windows.Forms.Padding(300, 0, 1, 0);
            this.TxtImpSearch.Name = "TxtImpSearch";
            this.TxtImpSearch.Size = new System.Drawing.Size(100, 25);
            this.TxtImpSearch.Text = "Điền thông tin";
            this.TxtImpSearch.Click += new System.EventHandler(this.TxtImpSearch_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TxtImpSearch,
            this.BtImpSearch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(944, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtImpSearch
            // 
            this.BtImpSearch.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtImpSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtImpSearch.Image = global::InventoryManage.Properties.Resources.search;
            this.BtImpSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtImpSearch.Name = "BtImpSearch";
            this.BtImpSearch.Size = new System.Drawing.Size(62, 22);
            this.BtImpSearch.Text = "Search";
            this.BtImpSearch.Click += new System.EventHandler(this.BtImpSearch_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Location = new System.Drawing.Point(527, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 396);
            this.panel1.TabIndex = 7;
            // 
            // groupBox5
            // 
            this.groupBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox5.BackgroundImage")));
            this.groupBox5.Controls.Add(this.BtImpDeletePro);
            this.groupBox5.Controls.Add(this.BtImpEditPro);
            this.groupBox5.Controls.Add(this.BtImpAddPro);
            this.groupBox5.Controls.Add(this.DgvImpPro);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox5.Location = new System.Drawing.Point(12, 122);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(386, 251);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Danh sách sản phẩm";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // BtImpDeletePro
            // 
            this.BtImpDeletePro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtImpDeletePro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BtImpDeletePro.ForeColor = System.Drawing.Color.Black;
            this.BtImpDeletePro.Location = new System.Drawing.Point(277, 208);
            this.BtImpDeletePro.Name = "BtImpDeletePro";
            this.BtImpDeletePro.Size = new System.Drawing.Size(99, 27);
            this.BtImpDeletePro.TabIndex = 7;
            this.BtImpDeletePro.Text = "Delete Product";
            this.BtImpDeletePro.UseVisualStyleBackColor = false;
            this.BtImpDeletePro.Visible = false;
            this.BtImpDeletePro.Click += new System.EventHandler(this.BtImpDeletePro_Click);
            // 
            // BtImpEditPro
            // 
            this.BtImpEditPro.BackColor = System.Drawing.Color.MediumAquamarine;
            this.BtImpEditPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BtImpEditPro.ForeColor = System.Drawing.Color.Black;
            this.BtImpEditPro.Location = new System.Drawing.Point(147, 208);
            this.BtImpEditPro.Name = "BtImpEditPro";
            this.BtImpEditPro.Size = new System.Drawing.Size(96, 27);
            this.BtImpEditPro.TabIndex = 6;
            this.BtImpEditPro.Text = "Edit Product";
            this.BtImpEditPro.UseVisualStyleBackColor = false;
            this.BtImpEditPro.Visible = false;
            this.BtImpEditPro.Click += new System.EventHandler(this.BtImpEditPro_Click);
            // 
            // BtImpAddPro
            // 
            this.BtImpAddPro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtImpAddPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BtImpAddPro.ForeColor = System.Drawing.Color.Black;
            this.BtImpAddPro.Location = new System.Drawing.Point(22, 208);
            this.BtImpAddPro.Name = "BtImpAddPro";
            this.BtImpAddPro.Size = new System.Drawing.Size(90, 27);
            this.BtImpAddPro.TabIndex = 5;
            this.BtImpAddPro.Text = "Add Product";
            this.BtImpAddPro.UseVisualStyleBackColor = false;
            this.BtImpAddPro.Visible = false;
            this.BtImpAddPro.Click += new System.EventHandler(this.BtImpAddPro_Click);
            // 
            // DgvImpPro
            // 
            this.DgvImpPro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvImpPro.Location = new System.Drawing.Point(22, 21);
            this.DgvImpPro.Name = "DgvImpPro";
            this.DgvImpPro.Size = new System.Drawing.Size(358, 163);
            this.DgvImpPro.TabIndex = 1;
            this.DgvImpPro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvImpPro_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.LightSalmon;
            this.groupBox4.Controls.Add(this.BtImpProCreate);
            this.groupBox4.Controls.Add(this.TxtImpProUnit);
            this.groupBox4.Controls.Add(this.CbImpProSup);
            this.groupBox4.Controls.Add(this.TxtImpProQuan);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.TxtImpProName);
            this.groupBox4.Controls.Add(this.TxtImpProCode);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox4.Location = new System.Drawing.Point(12, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(386, 100);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chi tiết sản phẩm theo đơn";
            // 
            // BtImpProCreate
            // 
            this.BtImpProCreate.Enabled = false;
            this.BtImpProCreate.Image = ((System.Drawing.Image)(resources.GetObject("BtImpProCreate.Image")));
            this.BtImpProCreate.Location = new System.Drawing.Point(123, 18);
            this.BtImpProCreate.Name = "BtImpProCreate";
            this.BtImpProCreate.Size = new System.Drawing.Size(28, 34);
            this.BtImpProCreate.TabIndex = 19;
            this.BtImpProCreate.UseVisualStyleBackColor = true;
            this.BtImpProCreate.Click += new System.EventHandler(this.BtImpProCreate_Click);
            // 
            // TxtImpProUnit
            // 
            this.TxtImpProUnit.Enabled = false;
            this.TxtImpProUnit.Location = new System.Drawing.Point(334, 27);
            this.TxtImpProUnit.Name = "TxtImpProUnit";
            this.TxtImpProUnit.Size = new System.Drawing.Size(48, 22);
            this.TxtImpProUnit.TabIndex = 18;
            // 
            // CbImpProSup
            // 
            this.CbImpProSup.Enabled = false;
            this.CbImpProSup.FormattingEnabled = true;
            this.CbImpProSup.Location = new System.Drawing.Point(249, 58);
            this.CbImpProSup.Name = "CbImpProSup";
            this.CbImpProSup.Size = new System.Drawing.Size(131, 24);
            this.CbImpProSup.TabIndex = 17;
            // 
            // TxtImpProQuan
            // 
            this.TxtImpProQuan.Enabled = false;
            this.TxtImpProQuan.Location = new System.Drawing.Point(240, 24);
            this.TxtImpProQuan.Name = "TxtImpProQuan";
            this.TxtImpProQuan.Size = new System.Drawing.Size(42, 22);
            this.TxtImpProQuan.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightSalmon;
            this.label7.Location = new System.Drawing.Point(288, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Đơn vị";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.LightSalmon;
            this.label8.Location = new System.Drawing.Point(173, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Số lượng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.LightSalmon;
            this.label9.Location = new System.Drawing.Point(148, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "Nhà phân phối";
            // 
            // TxtImpProName
            // 
            this.TxtImpProName.Enabled = false;
            this.TxtImpProName.Location = new System.Drawing.Point(44, 58);
            this.TxtImpProName.Name = "TxtImpProName";
            this.TxtImpProName.Size = new System.Drawing.Size(83, 22);
            this.TxtImpProName.TabIndex = 11;
            // 
            // TxtImpProCode
            // 
            this.TxtImpProCode.Enabled = false;
            this.TxtImpProCode.Location = new System.Drawing.Point(53, 24);
            this.TxtImpProCode.Name = "TxtImpProCode";
            this.TxtImpProCode.Size = new System.Drawing.Size(49, 22);
            this.TxtImpProCode.TabIndex = 10;
            this.TxtImpProCode.TextChanged += new System.EventHandler(this.TxtImpProCode_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightSalmon;
            this.label4.Location = new System.Drawing.Point(6, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Code";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightSalmon;
            this.label6.Location = new System.Drawing.Point(6, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tên";
            // 
            // CmbImp
            // 
            this.CmbImp.FormattingEnabled = true;
            this.CmbImp.Items.AddRange(new object[] {
            "Id of Receipt",
            "Name of Storekeeper",
            "Name of Supplier",
            "Date of Importing",
            "Year of Importing"});
            this.CmbImp.Location = new System.Drawing.Point(177, 0);
            this.CmbImp.Name = "CmbImp";
            this.CmbImp.Size = new System.Drawing.Size(121, 21);
            this.CmbImp.TabIndex = 8;
            // 
            // FormImportations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(944, 512);
            this.Controls.Add(this.CmbImp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormImportations";
            this.Text = "Importations";
            this.Load += new System.EventHandler(this.FormImportations_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvImp)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvImpPro)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton BtImpDelete;
        private System.Windows.Forms.ToolStripButton BtImpCreate;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton BtImpEdit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox CbImpSupplier;
        private System.Windows.Forms.TextBox TxtImpDeliver;
        private System.Windows.Forms.TextBox TxtImpStorekeeper;
        private System.Windows.Forms.DataGridView DgvImp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker DateImp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton BtImpSearch;
        private System.Windows.Forms.ToolStripTextBox TxtImpSearch;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox TxtImpProName;
        private System.Windows.Forms.TextBox TxtImpProCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView DgvImpPro;
        private System.Windows.Forms.TextBox TxtImpProUnit;
        private System.Windows.Forms.ComboBox CbImpProSup;
        private System.Windows.Forms.TextBox TxtImpProQuan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtImpCreateSup;
        private System.Windows.Forms.Button BtImpProCreate;
        private System.Windows.Forms.ToolStripButton BtImpBack;
        private System.Windows.Forms.ToolStripButton BtImpFresh;
        private System.Windows.Forms.Button BtImpDeletePro;
        private System.Windows.Forms.Button BtImpEditPro;
        private System.Windows.Forms.Button BtImpAddPro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtImpStoID;
        private System.Windows.Forms.ComboBox CmbImp;
    }
}