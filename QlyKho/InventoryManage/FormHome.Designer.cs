namespace InventoryManage
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Home = new System.Windows.Forms.ToolStripMenuItem();
            this.SignIn = new System.Windows.Forms.ToolStripMenuItem();
            this.Registe = new System.Windows.Forms.ToolStripMenuItem();
            this.View = new System.Windows.Forms.ToolStripMenuItem();
            this.Products = new System.Windows.Forms.ToolStripMenuItem();
            this.Importations = new System.Windows.Forms.ToolStripMenuItem();
            this.Exportations = new System.Windows.Forms.ToolStripMenuItem();
            this.Suppliers = new System.Windows.Forms.ToolStripMenuItem();
            this.Customers = new System.Windows.Forms.ToolStripMenuItem();
            this.Storekeepers = new System.Windows.Forms.ToolStripMenuItem();
            this.Manage = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.importationsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exportationsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.suppliersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.storekeepersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Home,
            this.View,
            this.Manage});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(499, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Home
            // 
            this.Home.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SignIn,
            this.Registe});
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(52, 20);
            this.Home.Text = "Home";
            // 
            // SignIn
            // 
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(112, 22);
            this.SignIn.Text = "Sign In";
            this.SignIn.Click += new System.EventHandler(this.SignIn_Click);
            // 
            // Registe
            // 
            this.Registe.Name = "Registe";
            this.Registe.Size = new System.Drawing.Size(112, 22);
            this.Registe.Text = "Registe";
            this.Registe.Click += new System.EventHandler(this.Registe_Click);
            // 
            // View
            // 
            this.View.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Products,
            this.Importations,
            this.Exportations,
            this.Suppliers,
            this.Customers,
            this.Storekeepers});
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(44, 20);
            this.View.Text = "View";
            // 
            // Products
            // 
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(142, 22);
            this.Products.Text = "Products";
            this.Products.Click += new System.EventHandler(this.Products_Click);
            // 
            // Importations
            // 
            this.Importations.Name = "Importations";
            this.Importations.Size = new System.Drawing.Size(142, 22);
            this.Importations.Text = "Importations";
            this.Importations.Click += new System.EventHandler(this.Importations_Click);
            // 
            // Exportations
            // 
            this.Exportations.Name = "Exportations";
            this.Exportations.Size = new System.Drawing.Size(142, 22);
            this.Exportations.Text = "Exportations";
            this.Exportations.Click += new System.EventHandler(this.Exportations_Click);
            // 
            // Suppliers
            // 
            this.Suppliers.Name = "Suppliers";
            this.Suppliers.Size = new System.Drawing.Size(142, 22);
            this.Suppliers.Text = "Suppliers";
            this.Suppliers.Click += new System.EventHandler(this.Suppliers_Click);
            // 
            // Customers
            // 
            this.Customers.Name = "Customers";
            this.Customers.Size = new System.Drawing.Size(142, 22);
            this.Customers.Text = "Customers";
            this.Customers.Click += new System.EventHandler(this.Customers_Click);
            // 
            // Storekeepers
            // 
            this.Storekeepers.Name = "Storekeepers";
            this.Storekeepers.Size = new System.Drawing.Size(142, 22);
            this.Storekeepers.Text = "Storekeepers";
            this.Storekeepers.Click += new System.EventHandler(this.Storekeepers_Click);
            // 
            // Manage
            // 
            this.Manage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsToolStripMenuItem1,
            this.importationsToolStripMenuItem1,
            this.exportationsToolStripMenuItem1,
            this.suppliersToolStripMenuItem1,
            this.customersToolStripMenuItem1,
            this.storekeepersToolStripMenuItem1});
            this.Manage.Enabled = false;
            this.Manage.Name = "Manage";
            this.Manage.Size = new System.Drawing.Size(62, 20);
            this.Manage.Text = "Manage";
            // 
            // productsToolStripMenuItem1
            // 
            this.productsToolStripMenuItem1.Name = "productsToolStripMenuItem1";
            this.productsToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.productsToolStripMenuItem1.Text = "Products";
            this.productsToolStripMenuItem1.Click += new System.EventHandler(this.productsToolStripMenuItem1_Click);
            // 
            // importationsToolStripMenuItem1
            // 
            this.importationsToolStripMenuItem1.Name = "importationsToolStripMenuItem1";
            this.importationsToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.importationsToolStripMenuItem1.Text = "Importations";
            this.importationsToolStripMenuItem1.Click += new System.EventHandler(this.importationsToolStripMenuItem1_Click);
            // 
            // exportationsToolStripMenuItem1
            // 
            this.exportationsToolStripMenuItem1.Name = "exportationsToolStripMenuItem1";
            this.exportationsToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.exportationsToolStripMenuItem1.Text = "Exportations";
            this.exportationsToolStripMenuItem1.Click += new System.EventHandler(this.exportationsToolStripMenuItem1_Click);
            // 
            // suppliersToolStripMenuItem1
            // 
            this.suppliersToolStripMenuItem1.Name = "suppliersToolStripMenuItem1";
            this.suppliersToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.suppliersToolStripMenuItem1.Text = "Suppliers";
            this.suppliersToolStripMenuItem1.Click += new System.EventHandler(this.suppliersToolStripMenuItem1_Click);
            // 
            // customersToolStripMenuItem1
            // 
            this.customersToolStripMenuItem1.Name = "customersToolStripMenuItem1";
            this.customersToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.customersToolStripMenuItem1.Text = "Customers";
            this.customersToolStripMenuItem1.Click += new System.EventHandler(this.customersToolStripMenuItem1_Click);
            // 
            // storekeepersToolStripMenuItem1
            // 
            this.storekeepersToolStripMenuItem1.Name = "storekeepersToolStripMenuItem1";
            this.storekeepersToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.storekeepersToolStripMenuItem1.Text = "Storekeepers";
            this.storekeepersToolStripMenuItem1.Click += new System.EventHandler(this.storekeepersToolStripMenuItem1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(112, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ KHO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(499, 305);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Home;
        private System.Windows.Forms.ToolStripMenuItem SignIn;
        private System.Windows.Forms.ToolStripMenuItem Registe;
        private System.Windows.Forms.ToolStripMenuItem View;
        private System.Windows.Forms.ToolStripMenuItem Products;
        private System.Windows.Forms.ToolStripMenuItem Importations;
        private System.Windows.Forms.ToolStripMenuItem Exportations;
        private System.Windows.Forms.ToolStripMenuItem Suppliers;
        private System.Windows.Forms.ToolStripMenuItem Customers;
        private System.Windows.Forms.ToolStripMenuItem Storekeepers;
        private System.Windows.Forms.ToolStripMenuItem Manage;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem importationsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exportationsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem suppliersToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem storekeepersToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
    }
}