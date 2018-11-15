namespace InventoryManage
{
    partial class FormProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProducts));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TxtProSearch = new System.Windows.Forms.ToolStripTextBox();
            this.BtProSearch = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtProUnit = new System.Windows.Forms.TextBox();
            this.BtProCreateSup = new System.Windows.Forms.Button();
            this.CbProSupplier = new System.Windows.Forms.ComboBox();
            this.TxtProQuantity = new System.Windows.Forms.TextBox();
            this.TxtProName = new System.Windows.Forms.TextBox();
            this.TxtProCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DgvPro = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.BtProCreate = new System.Windows.Forms.ToolStripButton();
            this.BtProEdit = new System.Windows.Forms.ToolStripButton();
            this.BtProDelete = new System.Windows.Forms.ToolStripButton();
            this.BtProBack = new System.Windows.Forms.ToolStripButton();
            this.BtProFresh = new System.Windows.Forms.ToolStripButton();
            this.CmbPro = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPro)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TxtProSearch,
            this.BtProSearch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(911, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TxtProSearch
            // 
            this.TxtProSearch.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.TxtProSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtProSearch.Margin = new System.Windows.Forms.Padding(380, 0, 1, 0);
            this.TxtProSearch.Name = "TxtProSearch";
            this.TxtProSearch.Size = new System.Drawing.Size(100, 25);
            this.TxtProSearch.Text = "Fill information";
            this.TxtProSearch.Click += new System.EventHandler(this.TxtProSearch_Click);
            // 
            // BtProSearch
            // 
            this.BtProSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtProSearch.Image = global::InventoryManage.Properties.Resources.search;
            this.BtProSearch.ImageTransparentColor = System.Drawing.Color.Thistle;
            this.BtProSearch.Name = "BtProSearch";
            this.BtProSearch.Size = new System.Drawing.Size(62, 22);
            this.BtProSearch.Text = "Search";
            this.BtProSearch.Click += new System.EventHandler(this.BtProSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Teal;
            this.groupBox1.Controls.Add(this.TxtProUnit);
            this.groupBox1.Controls.Add(this.BtProCreateSup);
            this.groupBox1.Controls.Add(this.CbProSupplier);
            this.groupBox1.Controls.Add(this.TxtProQuantity);
            this.groupBox1.Controls.Add(this.TxtProName);
            this.groupBox1.Controls.Add(this.TxtProCode);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(887, 93);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết sản phẩm";
            // 
            // TxtProUnit
            // 
            this.TxtProUnit.Enabled = false;
            this.TxtProUnit.Location = new System.Drawing.Point(307, 61);
            this.TxtProUnit.Name = "TxtProUnit";
            this.TxtProUnit.Size = new System.Drawing.Size(192, 22);
            this.TxtProUnit.TabIndex = 12;
            // 
            // BtProCreateSup
            // 
            this.BtProCreateSup.Enabled = false;
            this.BtProCreateSup.Image = global::InventoryManage.Properties.Resources.them;
            this.BtProCreateSup.Location = new System.Drawing.Point(846, 31);
            this.BtProCreateSup.Name = "BtProCreateSup";
            this.BtProCreateSup.Size = new System.Drawing.Size(35, 34);
            this.BtProCreateSup.TabIndex = 11;
            this.BtProCreateSup.UseVisualStyleBackColor = true;
            this.BtProCreateSup.Click += new System.EventHandler(this.BtProCreateSup_Click);
            // 
            // CbProSupplier
            // 
            this.CbProSupplier.Enabled = false;
            this.CbProSupplier.FormattingEnabled = true;
            this.CbProSupplier.Location = new System.Drawing.Point(652, 37);
            this.CbProSupplier.Name = "CbProSupplier";
            this.CbProSupplier.Size = new System.Drawing.Size(176, 24);
            this.CbProSupplier.TabIndex = 10;
            // 
            // TxtProQuantity
            // 
            this.TxtProQuantity.Enabled = false;
            this.TxtProQuantity.Location = new System.Drawing.Point(83, 61);
            this.TxtProQuantity.Name = "TxtProQuantity";
            this.TxtProQuantity.Size = new System.Drawing.Size(123, 22);
            this.TxtProQuantity.TabIndex = 8;
            // 
            // TxtProName
            // 
            this.TxtProName.Enabled = false;
            this.TxtProName.Location = new System.Drawing.Point(307, 27);
            this.TxtProName.Name = "TxtProName";
            this.TxtProName.Size = new System.Drawing.Size(192, 22);
            this.TxtProName.TabIndex = 7;
            // 
            // TxtProCode
            // 
            this.TxtProCode.Enabled = false;
            this.TxtProCode.Location = new System.Drawing.Point(83, 27);
            this.TxtProCode.Name = "TxtProCode";
            this.TxtProCode.Size = new System.Drawing.Size(123, 22);
            this.TxtProCode.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(260, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Đơn vị";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(22, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(7, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số Lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(551, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhà phân phối";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(246, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.Controls.Add(this.DgvPro);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(887, 261);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List of Products";
            // 
            // DgvPro
            // 
            this.DgvPro.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DgvPro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPro.Location = new System.Drawing.Point(12, 42);
            this.DgvPro.Name = "DgvPro";
            this.DgvPro.Size = new System.Drawing.Size(875, 213);
            this.DgvPro.TabIndex = 0;
            this.DgvPro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPro_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.toolStrip2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.Location = new System.Drawing.Point(12, 394);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(853, 56);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Function";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtProCreate,
            this.BtProEdit,
            this.BtProDelete,
            this.BtProBack,
            this.BtProFresh});
            this.toolStrip2.Location = new System.Drawing.Point(3, 18);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(847, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            this.toolStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip2_ItemClicked);
            // 
            // BtProCreate
            // 
            this.BtProCreate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BtProCreate.Image = global::InventoryManage.Properties.Resources.Add;
            this.BtProCreate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtProCreate.Margin = new System.Windows.Forms.Padding(40, 1, 0, 2);
            this.BtProCreate.Name = "BtProCreate";
            this.BtProCreate.Size = new System.Drawing.Size(66, 22);
            this.BtProCreate.Text = "Create";
            this.BtProCreate.Visible = false;
            this.BtProCreate.Click += new System.EventHandler(this.BtProCreate_Click);
            // 
            // BtProEdit
            // 
            this.BtProEdit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BtProEdit.Image = global::InventoryManage.Properties.Resources.Edit;
            this.BtProEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtProEdit.Margin = new System.Windows.Forms.Padding(50, 1, 0, 2);
            this.BtProEdit.Name = "BtProEdit";
            this.BtProEdit.Size = new System.Drawing.Size(50, 22);
            this.BtProEdit.Text = "Edit";
            this.BtProEdit.Visible = false;
            this.BtProEdit.Click += new System.EventHandler(this.BtProEdit_Click);
            // 
            // BtProDelete
            // 
            this.BtProDelete.Image = global::InventoryManage.Properties.Resources.delete;
            this.BtProDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtProDelete.Margin = new System.Windows.Forms.Padding(50, 1, 0, 2);
            this.BtProDelete.Name = "BtProDelete";
            this.BtProDelete.Size = new System.Drawing.Size(60, 22);
            this.BtProDelete.Text = "Delete";
            this.BtProDelete.Visible = false;
            this.BtProDelete.Click += new System.EventHandler(this.BtProDelete_Click);
            // 
            // BtProBack
            // 
            this.BtProBack.Image = global::InventoryManage.Properties.Resources.Previous;
            this.BtProBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtProBack.Margin = new System.Windows.Forms.Padding(50, 1, 0, 2);
            this.BtProBack.Name = "BtProBack";
            this.BtProBack.Size = new System.Drawing.Size(52, 22);
            this.BtProBack.Text = "Back";
            this.BtProBack.Click += new System.EventHandler(this.BtProBack_Click);
            // 
            // BtProFresh
            // 
            this.BtProFresh.Image = global::InventoryManage.Properties.Resources.repeat_128;
            this.BtProFresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtProFresh.Margin = new System.Windows.Forms.Padding(50, 1, 0, 2);
            this.BtProFresh.Name = "BtProFresh";
            this.BtProFresh.Size = new System.Drawing.Size(55, 22);
            this.BtProFresh.Text = "Fresh";
            this.BtProFresh.Visible = false;
            this.BtProFresh.Click += new System.EventHandler(this.BtProFresh_Click);
            // 
            // CmbPro
            // 
            this.CmbPro.FormattingEnabled = true;
            this.CmbPro.Items.AddRange(new object[] {
            "Name of Product",
            "Supplier"});
            this.CmbPro.Location = new System.Drawing.Point(249, 1);
            this.CmbPro.Name = "CmbPro";
            this.CmbPro.Size = new System.Drawing.Size(121, 21);
            this.CmbPro.TabIndex = 3;
            // 
            // FormProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(911, 462);
            this.Controls.Add(this.CmbPro);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormProducts";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.FormProducts_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPro)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox TxtProSearch;
        private System.Windows.Forms.ToolStripButton BtProSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtProCreateSup;
        private System.Windows.Forms.ComboBox CbProSupplier;
        private System.Windows.Forms.TextBox TxtProQuantity;
        private System.Windows.Forms.TextBox TxtProName;
        private System.Windows.Forms.TextBox TxtProCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TxtProUnit;
        private System.Windows.Forms.DataGridView DgvPro;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton BtProCreate;
        private System.Windows.Forms.ToolStripButton BtProEdit;
        private System.Windows.Forms.ToolStripButton BtProDelete;
        private System.Windows.Forms.ToolStripButton BtProBack;
        private System.Windows.Forms.ToolStripButton BtProFresh;
        private System.Windows.Forms.ComboBox CmbPro;
    }
}

