namespace ProductSystem
{
    partial class frmProduct
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
            this.labelID = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelUnit = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.txtBoxID = new System.Windows.Forms.TextBox();
            this.txtBoxProductName = new System.Windows.Forms.TextBox();
            this.txtBoxUnit = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.numUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.labelSupplier = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.txtBoxSupplierName = new System.Windows.Forms.TextBox();
            this.txtBoxCategoryName = new System.Windows.Forms.TextBox();
            this.txtBoxSupplierID = new System.Windows.Forms.TextBox();
            this.txtBoxCategoryID = new System.Windows.Forms.TextBox();
            this.buttonSearchSupplier = new System.Windows.Forms.Button();
            this.buttonSearchCategory = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(46, 30);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(21, 13);
            this.labelID.TabIndex = 1;
            this.labelID.Text = "ID:";
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(7, 56);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(78, 13);
            this.labelProductName.TabIndex = 2;
            this.labelProductName.Text = "Product Name:";
            // 
            // labelUnit
            // 
            this.labelUnit.AutoSize = true;
            this.labelUnit.Location = new System.Drawing.Point(7, 82);
            this.labelUnit.Name = "labelUnit";
            this.labelUnit.Size = new System.Drawing.Size(29, 13);
            this.labelUnit.TabIndex = 3;
            this.labelUnit.Text = "Unit:";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(36, 109);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(34, 13);
            this.labelPrice.TabIndex = 4;
            this.labelPrice.Text = "Price:";
            // 
            // txtBoxID
            // 
            this.txtBoxID.Location = new System.Drawing.Point(119, 27);
            this.txtBoxID.Name = "txtBoxID";
            this.txtBoxID.ReadOnly = true;
            this.txtBoxID.Size = new System.Drawing.Size(200, 20);
            this.txtBoxID.TabIndex = 5;
            // 
            // txtBoxProductName
            // 
            this.txtBoxProductName.Location = new System.Drawing.Point(119, 53);
            this.txtBoxProductName.Name = "txtBoxProductName";
            this.txtBoxProductName.Size = new System.Drawing.Size(200, 20);
            this.txtBoxProductName.TabIndex = 6;
            this.txtBoxProductName.TextChanged += new System.EventHandler(this.EmployeeDataEdited);
            // 
            // txtBoxUnit
            // 
            this.txtBoxUnit.Location = new System.Drawing.Point(119, 79);
            this.txtBoxUnit.Name = "txtBoxUnit";
            this.txtBoxUnit.Size = new System.Drawing.Size(200, 20);
            this.txtBoxUnit.TabIndex = 7;
            this.txtBoxUnit.TextChanged += new System.EventHandler(this.EmployeeDataEdited);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.addToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(417, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(325, 39);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(325, 70);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 11;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(325, 99);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 12;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // numUpDownPrice
            // 
            this.numUpDownPrice.DecimalPlaces = 2;
            this.numUpDownPrice.Location = new System.Drawing.Point(119, 109);
            this.numUpDownPrice.Name = "numUpDownPrice";
            this.numUpDownPrice.Size = new System.Drawing.Size(200, 20);
            this.numUpDownPrice.TabIndex = 13;
            // 
            // labelSupplier
            // 
            this.labelSupplier.AutoSize = true;
            this.labelSupplier.Location = new System.Drawing.Point(33, 149);
            this.labelSupplier.Name = "labelSupplier";
            this.labelSupplier.Size = new System.Drawing.Size(48, 13);
            this.labelSupplier.TabIndex = 14;
            this.labelSupplier.Text = "Supplier:";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(36, 186);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(52, 13);
            this.labelCategory.TabIndex = 15;
            this.labelCategory.Text = "Category:";
            // 
            // txtBoxSupplierName
            // 
            this.txtBoxSupplierName.Location = new System.Drawing.Point(172, 146);
            this.txtBoxSupplierName.Name = "txtBoxSupplierName";
            this.txtBoxSupplierName.ReadOnly = true;
            this.txtBoxSupplierName.Size = new System.Drawing.Size(147, 20);
            this.txtBoxSupplierName.TabIndex = 16;
            this.txtBoxSupplierName.TextChanged += new System.EventHandler(this.EmployeeDataEdited);
            // 
            // txtBoxCategoryName
            // 
            this.txtBoxCategoryName.Location = new System.Drawing.Point(172, 179);
            this.txtBoxCategoryName.Name = "txtBoxCategoryName";
            this.txtBoxCategoryName.ReadOnly = true;
            this.txtBoxCategoryName.Size = new System.Drawing.Size(147, 20);
            this.txtBoxCategoryName.TabIndex = 17;
            this.txtBoxCategoryName.TextChanged += new System.EventHandler(this.EmployeeDataEdited);
            // 
            // txtBoxSupplierID
            // 
            this.txtBoxSupplierID.Location = new System.Drawing.Point(119, 146);
            this.txtBoxSupplierID.Name = "txtBoxSupplierID";
            this.txtBoxSupplierID.ReadOnly = true;
            this.txtBoxSupplierID.Size = new System.Drawing.Size(47, 20);
            this.txtBoxSupplierID.TabIndex = 18;
            this.txtBoxSupplierID.TextChanged += new System.EventHandler(this.EmployeeDataEdited);
            // 
            // txtBoxCategoryID
            // 
            this.txtBoxCategoryID.Location = new System.Drawing.Point(119, 179);
            this.txtBoxCategoryID.Name = "txtBoxCategoryID";
            this.txtBoxCategoryID.ReadOnly = true;
            this.txtBoxCategoryID.Size = new System.Drawing.Size(47, 20);
            this.txtBoxCategoryID.TabIndex = 19;
            this.txtBoxCategoryID.TextChanged += new System.EventHandler(this.EmployeeDataEdited);
            // 
            // buttonSearchSupplier
            // 
            this.buttonSearchSupplier.Location = new System.Drawing.Point(325, 144);
            this.buttonSearchSupplier.Name = "buttonSearchSupplier";
            this.buttonSearchSupplier.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchSupplier.TabIndex = 20;
            this.buttonSearchSupplier.Text = "Edit";
            this.buttonSearchSupplier.UseVisualStyleBackColor = true;
            this.buttonSearchSupplier.Click += new System.EventHandler(this.buttonSearchSupplier_Click);
            // 
            // buttonSearchCategory
            // 
            this.buttonSearchCategory.Location = new System.Drawing.Point(325, 177);
            this.buttonSearchCategory.Name = "buttonSearchCategory";
            this.buttonSearchCategory.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchCategory.TabIndex = 21;
            this.buttonSearchCategory.Text = "Edit";
            this.buttonSearchCategory.UseVisualStyleBackColor = true;
            this.buttonSearchCategory.Click += new System.EventHandler(this.buttonSearchCategory_Click);
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 227);
            this.Controls.Add(this.buttonSearchCategory);
            this.Controls.Add(this.buttonSearchSupplier);
            this.Controls.Add(this.txtBoxCategoryID);
            this.Controls.Add(this.txtBoxSupplierID);
            this.Controls.Add(this.txtBoxCategoryName);
            this.Controls.Add(this.txtBoxSupplierName);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.labelSupplier);
            this.Controls.Add(this.numUpDownPrice);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.txtBoxUnit);
            this.Controls.Add(this.txtBoxProductName);
            this.Controls.Add(this.txtBoxID);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelUnit);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Search";
            this.Load += new System.EventHandler(this.frmProduct_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelUnit;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox txtBoxID;
        private System.Windows.Forms.TextBox txtBoxProductName;
        private System.Windows.Forms.TextBox txtBoxUnit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.NumericUpDown numUpDownPrice;
        private System.Windows.Forms.Label labelSupplier;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.TextBox txtBoxSupplierName;
        private System.Windows.Forms.TextBox txtBoxCategoryName;
        private System.Windows.Forms.TextBox txtBoxSupplierID;
        private System.Windows.Forms.TextBox txtBoxCategoryID;
        private System.Windows.Forms.Button buttonSearchSupplier;
        private System.Windows.Forms.Button buttonSearchCategory;
    }
}

