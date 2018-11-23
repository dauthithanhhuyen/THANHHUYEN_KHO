namespace InventoryManage
{
    partial class FormSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSupplier));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.BtSupCreate = new System.Windows.Forms.ToolStripButton();
            this.BtSupEdit = new System.Windows.Forms.ToolStripButton();
            this.BtSupDelete = new System.Windows.Forms.ToolStripButton();
            this.BtSupBack = new System.Windows.Forms.ToolStripButton();
            this.BtSupFresh = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DgvSup = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtSupEmail = new System.Windows.Forms.TextBox();
            this.TxtSupPhone = new System.Windows.Forms.TextBox();
            this.TxtSupAddress = new System.Windows.Forms.TextBox();
            this.TxtSupName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TxtSupSearch = new System.Windows.Forms.ToolStripTextBox();
            this.BtSupSearch = new System.Windows.Forms.ToolStripButton();
            this.CmbSup = new System.Windows.Forms.ComboBox();
            this.groupBox3.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSup)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.toolStrip2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.Location = new System.Drawing.Point(12, 354);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(560, 56);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Function";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtSupCreate,
            this.BtSupEdit,
            this.BtSupDelete,
            this.BtSupBack,
            this.BtSupFresh});
            this.toolStrip2.Location = new System.Drawing.Point(3, 18);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(554, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // BtSupCreate
            // 
            this.BtSupCreate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BtSupCreate.Image = global::InventoryManage.Properties.Resources.Add;
            this.BtSupCreate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtSupCreate.Margin = new System.Windows.Forms.Padding(20, 1, 0, 2);
            this.BtSupCreate.Name = "BtSupCreate";
            this.BtSupCreate.Size = new System.Drawing.Size(66, 22);
            this.BtSupCreate.Text = "Create";
            this.BtSupCreate.Visible = false;
            this.BtSupCreate.Click += new System.EventHandler(this.BtSupCreate_Click);
            // 
            // BtSupEdit
            // 
            this.BtSupEdit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.BtSupEdit.Image = global::InventoryManage.Properties.Resources.Edit;
            this.BtSupEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtSupEdit.Margin = new System.Windows.Forms.Padding(50, 1, 0, 2);
            this.BtSupEdit.Name = "BtSupEdit";
            this.BtSupEdit.Size = new System.Drawing.Size(50, 22);
            this.BtSupEdit.Text = "Edit";
            this.BtSupEdit.Visible = false;
            this.BtSupEdit.Click += new System.EventHandler(this.BtSupEdit_Click);
            // 
            // BtSupDelete
            // 
            this.BtSupDelete.Image = global::InventoryManage.Properties.Resources.delete;
            this.BtSupDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtSupDelete.Margin = new System.Windows.Forms.Padding(50, 1, 0, 2);
            this.BtSupDelete.Name = "BtSupDelete";
            this.BtSupDelete.Size = new System.Drawing.Size(60, 22);
            this.BtSupDelete.Text = "Delete";
            this.BtSupDelete.Visible = false;
            this.BtSupDelete.Click += new System.EventHandler(this.BtSupDelete_Click);
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
            // BtSupFresh
            // 
            this.BtSupFresh.Image = global::InventoryManage.Properties.Resources.repeat_128;
            this.BtSupFresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtSupFresh.Margin = new System.Windows.Forms.Padding(50, 1, 0, 2);
            this.BtSupFresh.Name = "BtSupFresh";
            this.BtSupFresh.Size = new System.Drawing.Size(55, 22);
            this.BtSupFresh.Text = "Fresh";
            this.BtSupFresh.Visible = false;
            this.BtSupFresh.Click += new System.EventHandler(this.BtSupFresh_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.Controls.Add(this.DgvSup);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(560, 222);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách nhà phân phối";
            // 
            // DgvSup
            // 
            this.DgvSup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSup.Location = new System.Drawing.Point(34, 36);
            this.DgvSup.Name = "DgvSup";
            this.DgvSup.Size = new System.Drawing.Size(509, 180);
            this.DgvSup.TabIndex = 0;
            this.DgvSup.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSup_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Teal;
            this.groupBox1.Controls.Add(this.TxtSupEmail);
            this.groupBox1.Controls.Add(this.TxtSupPhone);
            this.groupBox1.Controls.Add(this.TxtSupAddress);
            this.groupBox1.Controls.Add(this.TxtSupName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 93);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhà phân phối";
            // 
            // TxtSupEmail
            // 
            this.TxtSupEmail.Enabled = false;
            this.TxtSupEmail.Location = new System.Drawing.Point(394, 58);
            this.TxtSupEmail.Name = "TxtSupEmail";
            this.TxtSupEmail.Size = new System.Drawing.Size(135, 22);
            this.TxtSupEmail.TabIndex = 12;
            // 
            // TxtSupPhone
            // 
            this.TxtSupPhone.Enabled = false;
            this.TxtSupPhone.Location = new System.Drawing.Point(394, 27);
            this.TxtSupPhone.Name = "TxtSupPhone";
            this.TxtSupPhone.Size = new System.Drawing.Size(135, 22);
            this.TxtSupPhone.TabIndex = 8;
            // 
            // TxtSupAddress
            // 
            this.TxtSupAddress.Enabled = false;
            this.TxtSupAddress.Location = new System.Drawing.Point(83, 61);
            this.TxtSupAddress.Name = "TxtSupAddress";
            this.TxtSupAddress.Size = new System.Drawing.Size(123, 22);
            this.TxtSupAddress.TabIndex = 7;
            // 
            // TxtSupName
            // 
            this.TxtSupName.Enabled = false;
            this.TxtSupName.Location = new System.Drawing.Point(83, 27);
            this.TxtSupName.Name = "TxtSupName";
            this.TxtSupName.Size = new System.Drawing.Size(123, 22);
            this.TxtSupName.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 27);
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
            this.label1.Location = new System.Drawing.Point(22, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Địa chỉ";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TxtSupSearch,
            this.BtSupSearch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(582, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // TxtSupSearch
            // 
            this.TxtSupSearch.BackColor = System.Drawing.Color.MediumAquamarine;
            this.TxtSupSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSupSearch.Margin = new System.Windows.Forms.Padding(390, 0, 1, 0);
            this.TxtSupSearch.Name = "TxtSupSearch";
            this.TxtSupSearch.Size = new System.Drawing.Size(100, 25);
            this.TxtSupSearch.Text = "Điền thông tin";
            this.TxtSupSearch.Click += new System.EventHandler(this.TxtSupSearch_Click);
            // 
            // BtSupSearch
            // 
            this.BtSupSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtSupSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtSupSearch.Image = global::InventoryManage.Properties.Resources.search;
            this.BtSupSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtSupSearch.Name = "BtSupSearch";
            this.BtSupSearch.Size = new System.Drawing.Size(62, 22);
            this.BtSupSearch.Text = "Search";
            this.BtSupSearch.Click += new System.EventHandler(this.BtSupSearch_Click);
            // 
            // CmbSup
            // 
            this.CmbSup.FormattingEnabled = true;
            this.CmbSup.Items.AddRange(new object[] {
            "ID of Supplier",
            "Name of Supplier",
            "Address"});
            this.CmbSup.Location = new System.Drawing.Point(269, 0);
            this.CmbSup.Name = "CmbSup";
            this.CmbSup.Size = new System.Drawing.Size(121, 21);
            this.CmbSup.TabIndex = 7;
            // 
            // FormSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(582, 422);
            this.Controls.Add(this.CmbSup);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormSupplier";
            this.Text = "Suppliers";
            this.Load += new System.EventHandler(this.FormSupplier_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvSup)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton BtSupCreate;
        private System.Windows.Forms.ToolStripButton BtSupEdit;
        private System.Windows.Forms.ToolStripButton BtSupDelete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DgvSup;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtSupEmail;
        private System.Windows.Forms.TextBox TxtSupPhone;
        private System.Windows.Forms.TextBox TxtSupAddress;
        private System.Windows.Forms.TextBox TxtSupName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox TxtSupSearch;
        private System.Windows.Forms.ToolStripButton BtSupSearch;
        private System.Windows.Forms.ToolStripButton BtSupBack;
        private System.Windows.Forms.ToolStripButton BtSupFresh;
        private System.Windows.Forms.ComboBox CmbSup;
    }
}