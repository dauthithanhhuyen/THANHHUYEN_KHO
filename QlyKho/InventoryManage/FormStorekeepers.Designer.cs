namespace InventoryManage
{
    partial class FormStorekeepers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStorekeepers));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TxtStoSearch = new System.Windows.Forms.ToolStripTextBox();
            this.BtStoSearch = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BirthDay = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtStoEmail = new System.Windows.Forms.TextBox();
            this.TxtStoPhone = new System.Windows.Forms.TextBox();
            this.TxtStoAddress = new System.Windows.Forms.TextBox();
            this.TxtStoName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DgvSto = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.BtStoCreate = new System.Windows.Forms.ToolStripButton();
            this.BtStoEdit = new System.Windows.Forms.ToolStripButton();
            this.BtStoDelete = new System.Windows.Forms.ToolStripButton();
            this.BtSupBack = new System.Windows.Forms.ToolStripButton();
            this.BtStoFresh = new System.Windows.Forms.ToolStripButton();
            this.CmbSto = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSto)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TxtStoSearch,
            this.BtStoSearch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(570, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TxtStoSearch
            // 
            this.TxtStoSearch.BackColor = System.Drawing.Color.MediumAquamarine;
            this.TxtStoSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtStoSearch.Margin = new System.Windows.Forms.Padding(380, 0, 1, 0);
            this.TxtStoSearch.Name = "TxtStoSearch";
            this.TxtStoSearch.Size = new System.Drawing.Size(100, 25);
            this.TxtStoSearch.Text = "Điền thông tin ";
            this.TxtStoSearch.Click += new System.EventHandler(this.TxtStoSearch_Click);
            // 
            // BtStoSearch
            // 
            this.BtStoSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtStoSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtStoSearch.Image = global::InventoryManage.Properties.Resources.search;
            this.BtStoSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtStoSearch.Name = "BtStoSearch";
            this.BtStoSearch.Size = new System.Drawing.Size(62, 22);
            this.BtStoSearch.Text = "Search";
            this.BtStoSearch.Click += new System.EventHandler(this.BtStoSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSalmon;
            this.groupBox1.Controls.Add(this.BirthDay);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtStoEmail);
            this.groupBox1.Controls.Add(this.TxtStoPhone);
            this.groupBox1.Controls.Add(this.TxtStoAddress);
            this.groupBox1.Controls.Add(this.TxtStoName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(0, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 129);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chủ kho";
            // 
            // BirthDay
            // 
            this.BirthDay.CustomFormat = " dd / MM / yyy";
            this.BirthDay.Enabled = false;
            this.BirthDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BirthDay.Location = new System.Drawing.Point(394, 94);
            this.BirthDay.Name = "BirthDay";
            this.BirthDay.Size = new System.Drawing.Size(135, 22);
            this.BirthDay.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(280, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ngày sinh";
            // 
            // TxtStoEmail
            // 
            this.TxtStoEmail.Enabled = false;
            this.TxtStoEmail.Location = new System.Drawing.Point(394, 58);
            this.TxtStoEmail.Name = "TxtStoEmail";
            this.TxtStoEmail.Size = new System.Drawing.Size(135, 22);
            this.TxtStoEmail.TabIndex = 12;
            // 
            // TxtStoPhone
            // 
            this.TxtStoPhone.Enabled = false;
            this.TxtStoPhone.Location = new System.Drawing.Point(394, 27);
            this.TxtStoPhone.Name = "TxtStoPhone";
            this.TxtStoPhone.Size = new System.Drawing.Size(135, 22);
            this.TxtStoPhone.TabIndex = 8;
            // 
            // TxtStoAddress
            // 
            this.TxtStoAddress.Enabled = false;
            this.TxtStoAddress.Location = new System.Drawing.Point(83, 88);
            this.TxtStoAddress.Name = "TxtStoAddress";
            this.TxtStoAddress.Size = new System.Drawing.Size(123, 22);
            this.TxtStoAddress.TabIndex = 7;
            // 
            // TxtStoName
            // 
            this.TxtStoName.Enabled = false;
            this.TxtStoName.Location = new System.Drawing.Point(83, 36);
            this.TxtStoName.Name = "TxtStoName";
            this.TxtStoName.Size = new System.Drawing.Size(123, 22);
            this.TxtStoName.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "SĐT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Địa chỉ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.Controls.Add(this.DgvSto);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox2.Location = new System.Drawing.Point(0, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(560, 251);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách chủ kho";
            // 
            // DgvSto
            // 
            this.DgvSto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSto.Location = new System.Drawing.Point(21, 32);
            this.DgvSto.Name = "DgvSto";
            this.DgvSto.Size = new System.Drawing.Size(532, 204);
            this.DgvSto.TabIndex = 0;
            this.DgvSto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSto_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.toolStrip2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.Location = new System.Drawing.Point(5, 429);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(560, 56);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Function";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtStoCreate,
            this.BtStoEdit,
            this.BtStoDelete,
            this.BtSupBack,
            this.BtStoFresh});
            this.toolStrip2.Location = new System.Drawing.Point(3, 18);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(554, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // BtStoCreate
            // 
            this.BtStoCreate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BtStoCreate.Image = global::InventoryManage.Properties.Resources.Add;
            this.BtStoCreate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtStoCreate.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
            this.BtStoCreate.Name = "BtStoCreate";
            this.BtStoCreate.Size = new System.Drawing.Size(66, 22);
            this.BtStoCreate.Text = "Create";
            this.BtStoCreate.Visible = false;
            this.BtStoCreate.Click += new System.EventHandler(this.BtStoCreate_Click);
            // 
            // BtStoEdit
            // 
            this.BtStoEdit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BtStoEdit.Image = global::InventoryManage.Properties.Resources.Edit;
            this.BtStoEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtStoEdit.Margin = new System.Windows.Forms.Padding(50, 1, 0, 2);
            this.BtStoEdit.Name = "BtStoEdit";
            this.BtStoEdit.Size = new System.Drawing.Size(50, 22);
            this.BtStoEdit.Text = "Edit";
            this.BtStoEdit.Visible = false;
            this.BtStoEdit.Click += new System.EventHandler(this.BtStoEdit_Click);
            // 
            // BtStoDelete
            // 
            this.BtStoDelete.Image = global::InventoryManage.Properties.Resources.delete;
            this.BtStoDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtStoDelete.Margin = new System.Windows.Forms.Padding(50, 1, 0, 2);
            this.BtStoDelete.Name = "BtStoDelete";
            this.BtStoDelete.Size = new System.Drawing.Size(60, 22);
            this.BtStoDelete.Text = "Delete";
            this.BtStoDelete.Visible = false;
            this.BtStoDelete.Click += new System.EventHandler(this.BtStoDelete_Click);
            // 
            // BtSupBack
            // 
            this.BtSupBack.Image = global::InventoryManage.Properties.Resources.Previous;
            this.BtSupBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtSupBack.Margin = new System.Windows.Forms.Padding(50, 1, 0, 2);
            this.BtSupBack.Name = "BtSupBack";
            this.BtSupBack.Size = new System.Drawing.Size(52, 22);
            this.BtSupBack.Text = "Back";
            this.BtSupBack.Click += new System.EventHandler(this.BtSupBack_Click);
            // 
            // BtStoFresh
            // 
            this.BtStoFresh.Image = global::InventoryManage.Properties.Resources.repeat_128;
            this.BtStoFresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtStoFresh.Margin = new System.Windows.Forms.Padding(50, 1, 0, 2);
            this.BtStoFresh.Name = "BtStoFresh";
            this.BtStoFresh.Size = new System.Drawing.Size(55, 22);
            this.BtStoFresh.Text = "Fresh";
            this.BtStoFresh.Visible = false;
            this.BtStoFresh.Click += new System.EventHandler(this.BtStoFresh_Click);
            // 
            // CmbSto
            // 
            this.CmbSto.FormattingEnabled = true;
            this.CmbSto.Items.AddRange(new object[] {
            "ID of Storekeeper",
            "Name of Storekeeper"});
            this.CmbSto.Location = new System.Drawing.Point(257, 0);
            this.CmbSto.Name = "CmbSto";
            this.CmbSto.Size = new System.Drawing.Size(121, 21);
            this.CmbSto.TabIndex = 10;
            // 
            // FormStorekeepers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(570, 485);
            this.Controls.Add(this.CmbSto);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormStorekeepers";
            this.Text = "Storekeepers";
            this.Load += new System.EventHandler(this.FormStorekeepers_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvSto)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox TxtStoSearch;
        private System.Windows.Forms.ToolStripButton BtStoSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker BirthDay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtStoEmail;
        private System.Windows.Forms.TextBox TxtStoPhone;
        private System.Windows.Forms.TextBox TxtStoAddress;
        private System.Windows.Forms.TextBox TxtStoName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DgvSto;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton BtStoCreate;
        private System.Windows.Forms.ToolStripButton BtStoEdit;
        private System.Windows.Forms.ToolStripButton BtStoDelete;
        private System.Windows.Forms.ToolStripButton BtSupBack;
        private System.Windows.Forms.ToolStripButton BtStoFresh;
        private System.Windows.Forms.ComboBox CmbSto;
    }
}