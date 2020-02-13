namespace SQLWindowsForm
{
    partial class Form1
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
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.buttonUpdateEmployee = new System.Windows.Forms.Button();
            this.buttonRemoveEmployee = new System.Windows.Forms.Button();
            this.dataBaseFirstNameTxtbox = new System.Windows.Forms.TextBox();
            this.dataBaseLastNameTxtbox = new System.Windows.Forms.TextBox();
            this.dataBaseDatePicker = new System.Windows.Forms.DateTimePicker();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.lastNameTxtbox = new System.Windows.Forms.TextBox();
            this.firstNameTxtbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(12, 74);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.Size = new System.Drawing.Size(458, 150);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellContentClick);
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.Location = new System.Drawing.Point(1014, 210);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(75, 23);
            this.buttonAddEmployee.TabIndex = 1;
            this.buttonAddEmployee.Text = "Add";
            this.buttonAddEmployee.UseVisualStyleBackColor = true;
            this.buttonAddEmployee.Click += new System.EventHandler(this.buttonAddEmployee_Click);
            // 
            // buttonUpdateEmployee
            // 
            this.buttonUpdateEmployee.Location = new System.Drawing.Point(889, 210);
            this.buttonUpdateEmployee.Name = "buttonUpdateEmployee";
            this.buttonUpdateEmployee.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateEmployee.TabIndex = 2;
            this.buttonUpdateEmployee.Text = "Update";
            this.buttonUpdateEmployee.UseVisualStyleBackColor = true;
            this.buttonUpdateEmployee.Click += new System.EventHandler(this.buttonUpdateEmployee_Click);
            // 
            // buttonRemoveEmployee
            // 
            this.buttonRemoveEmployee.Location = new System.Drawing.Point(662, 210);
            this.buttonRemoveEmployee.Name = "buttonRemoveEmployee";
            this.buttonRemoveEmployee.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveEmployee.TabIndex = 3;
            this.buttonRemoveEmployee.Text = "Remove";
            this.buttonRemoveEmployee.UseVisualStyleBackColor = true;
            this.buttonRemoveEmployee.Click += new System.EventHandler(this.buttonRemoveEmployee_Click);
            // 
            // dataBaseFirstNameTxtbox
            // 
            this.dataBaseFirstNameTxtbox.Location = new System.Drawing.Point(602, 103);
            this.dataBaseFirstNameTxtbox.Name = "dataBaseFirstNameTxtbox";
            this.dataBaseFirstNameTxtbox.ReadOnly = true;
            this.dataBaseFirstNameTxtbox.Size = new System.Drawing.Size(200, 20);
            this.dataBaseFirstNameTxtbox.TabIndex = 4;
            // 
            // dataBaseLastNameTxtbox
            // 
            this.dataBaseLastNameTxtbox.Location = new System.Drawing.Point(602, 132);
            this.dataBaseLastNameTxtbox.Name = "dataBaseLastNameTxtbox";
            this.dataBaseLastNameTxtbox.ReadOnly = true;
            this.dataBaseLastNameTxtbox.Size = new System.Drawing.Size(200, 20);
            this.dataBaseLastNameTxtbox.TabIndex = 5;
            // 
            // dataBaseDatePicker
            // 
            this.dataBaseDatePicker.Enabled = false;
            this.dataBaseDatePicker.Location = new System.Drawing.Point(602, 164);
            this.dataBaseDatePicker.Name = "dataBaseDatePicker";
            this.dataBaseDatePicker.Size = new System.Drawing.Size(200, 20);
            this.dataBaseDatePicker.TabIndex = 6;
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(889, 164);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 20);
            this.datePicker.TabIndex = 9;
            // 
            // lastNameTxtbox
            // 
            this.lastNameTxtbox.Location = new System.Drawing.Point(889, 132);
            this.lastNameTxtbox.Name = "lastNameTxtbox";
            this.lastNameTxtbox.Size = new System.Drawing.Size(200, 20);
            this.lastNameTxtbox.TabIndex = 8;
            // 
            // firstNameTxtbox
            // 
            this.firstNameTxtbox.Location = new System.Drawing.Point(889, 103);
            this.firstNameTxtbox.Name = "firstNameTxtbox";
            this.firstNameTxtbox.Size = new System.Drawing.Size(200, 20);
            this.firstNameTxtbox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 302);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.lastNameTxtbox);
            this.Controls.Add(this.firstNameTxtbox);
            this.Controls.Add(this.dataBaseDatePicker);
            this.Controls.Add(this.dataBaseLastNameTxtbox);
            this.Controls.Add(this.dataBaseFirstNameTxtbox);
            this.Controls.Add(this.buttonRemoveEmployee);
            this.Controls.Add(this.buttonUpdateEmployee);
            this.Controls.Add(this.buttonAddEmployee);
            this.Controls.Add(this.dataGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button buttonAddEmployee;
        private System.Windows.Forms.Button buttonUpdateEmployee;
        private System.Windows.Forms.Button buttonRemoveEmployee;
        private System.Windows.Forms.TextBox dataBaseFirstNameTxtbox;
        private System.Windows.Forms.TextBox dataBaseLastNameTxtbox;
        private System.Windows.Forms.DateTimePicker dataBaseDatePicker;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.TextBox lastNameTxtbox;
        private System.Windows.Forms.TextBox firstNameTxtbox;
    }
}

