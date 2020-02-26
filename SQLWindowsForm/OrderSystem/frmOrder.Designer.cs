namespace OrderSystem
{
    partial class frmOrder
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
            this.labelOrderID = new System.Windows.Forms.Label();
            this.txtBoxOrderID = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelEmployee = new System.Windows.Forms.Label();
            this.labelShipper = new System.Windows.Forms.Label();
            this.txtBoxEmployeeName = new System.Windows.Forms.TextBox();
            this.txtBoxShipperName = new System.Windows.Forms.TextBox();
            this.txtBoxEmployeeID = new System.Windows.Forms.TextBox();
            this.txtBoxShipperID = new System.Windows.Forms.TextBox();
            this.buttonSearchEmployee = new System.Windows.Forms.Button();
            this.buttonSearchShipper = new System.Windows.Forms.Button();
            this.buttonSearchCustomer = new System.Windows.Forms.Button();
            this.txtBoxCustomerID = new System.Windows.Forms.TextBox();
            this.txtBoxCustomerName = new System.Windows.Forms.TextBox();
            this.labelCustomer = new System.Windows.Forms.Label();
            this.datePickerOrderDate = new System.Windows.Forms.DateTimePicker();
            this.labelOrderDate = new System.Windows.Forms.Label();
            this.txtBoxID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.buttonSearchProduct = new System.Windows.Forms.Button();
            this.txtBoxProductID = new System.Windows.Forms.TextBox();
            this.txtBoxProductName = new System.Windows.Forms.TextBox();
            this.labelProduct = new System.Windows.Forms.Label();
            this.numUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.dataGridProductQuantity = new System.Windows.Forms.DataGridView();
            this.buttonDetailDelete = new System.Windows.Forms.Button();
            this.buttonDetailUpdate = new System.Windows.Forms.Button();
            this.buttonDetailAdd = new System.Windows.Forms.Button();
            this.buttonOrderDetailAddMode = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // labelOrderID
            // 
            this.labelOrderID.AutoSize = true;
            this.labelOrderID.Location = new System.Drawing.Point(18, 49);
            this.labelOrderID.Name = "labelOrderID";
            this.labelOrderID.Size = new System.Drawing.Size(50, 13);
            this.labelOrderID.TabIndex = 1;
            this.labelOrderID.Text = "Order ID:";
            // 
            // txtBoxOrderID
            // 
            this.txtBoxOrderID.Location = new System.Drawing.Point(74, 46);
            this.txtBoxOrderID.Name = "txtBoxOrderID";
            this.txtBoxOrderID.ReadOnly = true;
            this.txtBoxOrderID.Size = new System.Drawing.Size(200, 20);
            this.txtBoxOrderID.TabIndex = 5;
            this.txtBoxOrderID.TextChanged += new System.EventHandler(this.OrderDataEdited);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.addToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(895, 24);
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
            this.buttonAdd.Location = new System.Drawing.Point(21, 190);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(106, 23);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "Add New Order";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(133, 190);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(106, 23);
            this.buttonUpdate.TabIndex = 11;
            this.buttonUpdate.Text = "Update Order";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(245, 190);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(106, 23);
            this.buttonDelete.TabIndex = 12;
            this.buttonDelete.Text = "Delete Order";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelEmployee
            // 
            this.labelEmployee.AutoSize = true;
            this.labelEmployee.Location = new System.Drawing.Point(12, 127);
            this.labelEmployee.Name = "labelEmployee";
            this.labelEmployee.Size = new System.Drawing.Size(56, 13);
            this.labelEmployee.TabIndex = 14;
            this.labelEmployee.Text = "Employee:";
            // 
            // labelShipper
            // 
            this.labelShipper.AutoSize = true;
            this.labelShipper.Location = new System.Drawing.Point(22, 153);
            this.labelShipper.Name = "labelShipper";
            this.labelShipper.Size = new System.Drawing.Size(46, 13);
            this.labelShipper.TabIndex = 15;
            this.labelShipper.Text = "Shipper:";
            // 
            // txtBoxEmployeeName
            // 
            this.txtBoxEmployeeName.Location = new System.Drawing.Point(127, 124);
            this.txtBoxEmployeeName.Name = "txtBoxEmployeeName";
            this.txtBoxEmployeeName.ReadOnly = true;
            this.txtBoxEmployeeName.Size = new System.Drawing.Size(147, 20);
            this.txtBoxEmployeeName.TabIndex = 16;
            this.txtBoxEmployeeName.TextChanged += new System.EventHandler(this.OrderDataEdited);
            // 
            // txtBoxShipperName
            // 
            this.txtBoxShipperName.Location = new System.Drawing.Point(127, 150);
            this.txtBoxShipperName.Name = "txtBoxShipperName";
            this.txtBoxShipperName.ReadOnly = true;
            this.txtBoxShipperName.Size = new System.Drawing.Size(147, 20);
            this.txtBoxShipperName.TabIndex = 17;
            this.txtBoxShipperName.TextChanged += new System.EventHandler(this.OrderDataEdited);
            // 
            // txtBoxEmployeeID
            // 
            this.txtBoxEmployeeID.Location = new System.Drawing.Point(74, 124);
            this.txtBoxEmployeeID.Name = "txtBoxEmployeeID";
            this.txtBoxEmployeeID.ReadOnly = true;
            this.txtBoxEmployeeID.Size = new System.Drawing.Size(47, 20);
            this.txtBoxEmployeeID.TabIndex = 18;
            this.txtBoxEmployeeID.TextChanged += new System.EventHandler(this.OrderDataEdited);
            // 
            // txtBoxShipperID
            // 
            this.txtBoxShipperID.Location = new System.Drawing.Point(74, 150);
            this.txtBoxShipperID.Name = "txtBoxShipperID";
            this.txtBoxShipperID.ReadOnly = true;
            this.txtBoxShipperID.Size = new System.Drawing.Size(47, 20);
            this.txtBoxShipperID.TabIndex = 19;
            this.txtBoxShipperID.TextChanged += new System.EventHandler(this.OrderDataEdited);
            // 
            // buttonSearchEmployee
            // 
            this.buttonSearchEmployee.Location = new System.Drawing.Point(280, 121);
            this.buttonSearchEmployee.Name = "buttonSearchEmployee";
            this.buttonSearchEmployee.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchEmployee.TabIndex = 20;
            this.buttonSearchEmployee.Text = "Edit";
            this.buttonSearchEmployee.UseVisualStyleBackColor = true;
            this.buttonSearchEmployee.Click += new System.EventHandler(this.buttonSearchEmployee_Click);
            // 
            // buttonSearchShipper
            // 
            this.buttonSearchShipper.Location = new System.Drawing.Point(280, 148);
            this.buttonSearchShipper.Name = "buttonSearchShipper";
            this.buttonSearchShipper.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchShipper.TabIndex = 21;
            this.buttonSearchShipper.Text = "Edit";
            this.buttonSearchShipper.UseVisualStyleBackColor = true;
            this.buttonSearchShipper.Click += new System.EventHandler(this.buttonSearchShipper_Click);
            // 
            // buttonSearchCustomer
            // 
            this.buttonSearchCustomer.Location = new System.Drawing.Point(280, 96);
            this.buttonSearchCustomer.Name = "buttonSearchCustomer";
            this.buttonSearchCustomer.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchCustomer.TabIndex = 25;
            this.buttonSearchCustomer.Text = "Edit";
            this.buttonSearchCustomer.UseVisualStyleBackColor = true;
            this.buttonSearchCustomer.Click += new System.EventHandler(this.buttonSearchCustomer_Click);
            // 
            // txtBoxCustomerID
            // 
            this.txtBoxCustomerID.Location = new System.Drawing.Point(74, 98);
            this.txtBoxCustomerID.Name = "txtBoxCustomerID";
            this.txtBoxCustomerID.ReadOnly = true;
            this.txtBoxCustomerID.Size = new System.Drawing.Size(47, 20);
            this.txtBoxCustomerID.TabIndex = 24;
            this.txtBoxCustomerID.TextChanged += new System.EventHandler(this.OrderDataEdited);
            // 
            // txtBoxCustomerName
            // 
            this.txtBoxCustomerName.Location = new System.Drawing.Point(127, 98);
            this.txtBoxCustomerName.Name = "txtBoxCustomerName";
            this.txtBoxCustomerName.ReadOnly = true;
            this.txtBoxCustomerName.Size = new System.Drawing.Size(147, 20);
            this.txtBoxCustomerName.TabIndex = 23;
            this.txtBoxCustomerName.TextChanged += new System.EventHandler(this.OrderDataEdited);
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.Location = new System.Drawing.Point(12, 101);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(54, 13);
            this.labelCustomer.TabIndex = 22;
            this.labelCustomer.Text = "Customer:";
            // 
            // datePickerOrderDate
            // 
            this.datePickerOrderDate.Location = new System.Drawing.Point(74, 72);
            this.datePickerOrderDate.Name = "datePickerOrderDate";
            this.datePickerOrderDate.Size = new System.Drawing.Size(200, 20);
            this.datePickerOrderDate.TabIndex = 26;
            this.datePickerOrderDate.ValueChanged += new System.EventHandler(this.OrderDataEdited);
            // 
            // labelOrderDate
            // 
            this.labelOrderDate.AutoSize = true;
            this.labelOrderDate.Location = new System.Drawing.Point(6, 78);
            this.labelOrderDate.Name = "labelOrderDate";
            this.labelOrderDate.Size = new System.Drawing.Size(62, 13);
            this.labelOrderDate.TabIndex = 27;
            this.labelOrderDate.Text = "Order Date:";
            // 
            // txtBoxID
            // 
            this.txtBoxID.Location = new System.Drawing.Point(445, 150);
            this.txtBoxID.Name = "txtBoxID";
            this.txtBoxID.ReadOnly = true;
            this.txtBoxID.Size = new System.Drawing.Size(200, 20);
            this.txtBoxID.TabIndex = 29;
            this.txtBoxID.TextChanged += new System.EventHandler(this.OrderDetailDataEdited);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(418, 153);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(21, 13);
            this.labelID.TabIndex = 28;
            this.labelID.Text = "ID:";
            // 
            // buttonSearchProduct
            // 
            this.buttonSearchProduct.Location = new System.Drawing.Point(652, 174);
            this.buttonSearchProduct.Name = "buttonSearchProduct";
            this.buttonSearchProduct.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchProduct.TabIndex = 33;
            this.buttonSearchProduct.Text = "Edit";
            this.buttonSearchProduct.UseVisualStyleBackColor = true;
            this.buttonSearchProduct.Click += new System.EventHandler(this.buttonSearchProduct_Click);
            // 
            // txtBoxProductID
            // 
            this.txtBoxProductID.Location = new System.Drawing.Point(446, 176);
            this.txtBoxProductID.Name = "txtBoxProductID";
            this.txtBoxProductID.ReadOnly = true;
            this.txtBoxProductID.Size = new System.Drawing.Size(47, 20);
            this.txtBoxProductID.TabIndex = 32;
            this.txtBoxProductID.TextChanged += new System.EventHandler(this.OrderDetailDataEdited);
            // 
            // txtBoxProductName
            // 
            this.txtBoxProductName.Location = new System.Drawing.Point(499, 176);
            this.txtBoxProductName.Name = "txtBoxProductName";
            this.txtBoxProductName.ReadOnly = true;
            this.txtBoxProductName.Size = new System.Drawing.Size(147, 20);
            this.txtBoxProductName.TabIndex = 31;
            this.txtBoxProductName.TextChanged += new System.EventHandler(this.OrderDetailDataEdited);
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Location = new System.Drawing.Point(392, 179);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(47, 13);
            this.labelProduct.TabIndex = 30;
            this.labelProduct.Text = "Product:";
            // 
            // numUpDownQuantity
            // 
            this.numUpDownQuantity.Location = new System.Drawing.Point(446, 200);
            this.numUpDownQuantity.Name = "numUpDownQuantity";
            this.numUpDownQuantity.Size = new System.Drawing.Size(200, 20);
            this.numUpDownQuantity.TabIndex = 34;
            this.numUpDownQuantity.ValueChanged += new System.EventHandler(this.OrderDetailDataEdited);
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(390, 200);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(49, 13);
            this.labelQuantity.TabIndex = 35;
            this.labelQuantity.Text = "Quantity:";
            // 
            // dataGridProductQuantity
            // 
            this.dataGridProductQuantity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProductQuantity.Location = new System.Drawing.Point(395, 40);
            this.dataGridProductQuantity.Name = "dataGridProductQuantity";
            this.dataGridProductQuantity.ReadOnly = true;
            this.dataGridProductQuantity.Size = new System.Drawing.Size(460, 100);
            this.dataGridProductQuantity.TabIndex = 38;
            this.dataGridProductQuantity.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProductQuantity_CellDoubleClick);
            // 
            // buttonDetailDelete
            // 
            this.buttonDetailDelete.Location = new System.Drawing.Point(749, 200);
            this.buttonDetailDelete.Name = "buttonDetailDelete";
            this.buttonDetailDelete.Size = new System.Drawing.Size(106, 23);
            this.buttonDetailDelete.TabIndex = 41;
            this.buttonDetailDelete.Text = "Delete Product";
            this.buttonDetailDelete.UseVisualStyleBackColor = true;
            this.buttonDetailDelete.Click += new System.EventHandler(this.buttonDetailDelete_Click);
            // 
            // buttonDetailUpdate
            // 
            this.buttonDetailUpdate.Location = new System.Drawing.Point(749, 173);
            this.buttonDetailUpdate.Name = "buttonDetailUpdate";
            this.buttonDetailUpdate.Size = new System.Drawing.Size(106, 23);
            this.buttonDetailUpdate.TabIndex = 40;
            this.buttonDetailUpdate.Text = "Update Product";
            this.buttonDetailUpdate.UseVisualStyleBackColor = true;
            this.buttonDetailUpdate.Click += new System.EventHandler(this.buttonDetailUpdate_Click);
            // 
            // buttonDetailAdd
            // 
            this.buttonDetailAdd.Location = new System.Drawing.Point(749, 147);
            this.buttonDetailAdd.Name = "buttonDetailAdd";
            this.buttonDetailAdd.Size = new System.Drawing.Size(106, 23);
            this.buttonDetailAdd.TabIndex = 39;
            this.buttonDetailAdd.Text = "Add New Product";
            this.buttonDetailAdd.UseVisualStyleBackColor = true;
            this.buttonDetailAdd.Click += new System.EventHandler(this.buttonDetailAdd_Click);
            // 
            // buttonOrderDetailAddMode
            // 
            this.buttonOrderDetailAddMode.Location = new System.Drawing.Point(861, 40);
            this.buttonOrderDetailAddMode.Name = "buttonOrderDetailAddMode";
            this.buttonOrderDetailAddMode.Size = new System.Drawing.Size(25, 23);
            this.buttonOrderDetailAddMode.TabIndex = 42;
            this.buttonOrderDetailAddMode.Text = "+";
            this.buttonOrderDetailAddMode.UseVisualStyleBackColor = true;
            this.buttonOrderDetailAddMode.Click += new System.EventHandler(this.buttonOrderDetailAddMode_Click);
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 254);
            this.Controls.Add(this.buttonOrderDetailAddMode);
            this.Controls.Add(this.buttonDetailDelete);
            this.Controls.Add(this.buttonDetailUpdate);
            this.Controls.Add(this.buttonDetailAdd);
            this.Controls.Add(this.dataGridProductQuantity);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.numUpDownQuantity);
            this.Controls.Add(this.buttonSearchProduct);
            this.Controls.Add(this.txtBoxProductID);
            this.Controls.Add(this.txtBoxProductName);
            this.Controls.Add(this.labelProduct);
            this.Controls.Add(this.txtBoxID);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelOrderDate);
            this.Controls.Add(this.datePickerOrderDate);
            this.Controls.Add(this.buttonSearchCustomer);
            this.Controls.Add(this.txtBoxCustomerID);
            this.Controls.Add(this.txtBoxCustomerName);
            this.Controls.Add(this.labelCustomer);
            this.Controls.Add(this.buttonSearchShipper);
            this.Controls.Add(this.buttonSearchEmployee);
            this.Controls.Add(this.txtBoxShipperID);
            this.Controls.Add(this.txtBoxEmployeeID);
            this.Controls.Add(this.txtBoxShipperName);
            this.Controls.Add(this.txtBoxEmployeeName);
            this.Controls.Add(this.labelShipper);
            this.Controls.Add(this.labelEmployee);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.txtBoxOrderID);
            this.Controls.Add(this.labelOrderID);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Search";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelOrderID;
        private System.Windows.Forms.TextBox txtBoxOrderID;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelEmployee;
        private System.Windows.Forms.Label labelShipper;
        private System.Windows.Forms.TextBox txtBoxEmployeeName;
        private System.Windows.Forms.TextBox txtBoxShipperName;
        private System.Windows.Forms.TextBox txtBoxEmployeeID;
        private System.Windows.Forms.TextBox txtBoxShipperID;
        private System.Windows.Forms.Button buttonSearchEmployee;
        private System.Windows.Forms.Button buttonSearchShipper;
        private System.Windows.Forms.Button buttonSearchCustomer;
        private System.Windows.Forms.TextBox txtBoxCustomerID;
        private System.Windows.Forms.TextBox txtBoxCustomerName;
        private System.Windows.Forms.Label labelCustomer;
        private System.Windows.Forms.DateTimePicker datePickerOrderDate;
        private System.Windows.Forms.Label labelOrderDate;
        private System.Windows.Forms.TextBox txtBoxID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button buttonSearchProduct;
        private System.Windows.Forms.TextBox txtBoxProductID;
        private System.Windows.Forms.TextBox txtBoxProductName;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.NumericUpDown numUpDownQuantity;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.DataGridView dataGridProductQuantity;
        private System.Windows.Forms.Button buttonDetailDelete;
        private System.Windows.Forms.Button buttonDetailUpdate;
        private System.Windows.Forms.Button buttonDetailAdd;
        private System.Windows.Forms.Button buttonOrderDetailAddMode;
    }
}

