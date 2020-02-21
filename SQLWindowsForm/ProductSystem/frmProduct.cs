using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SOC.Core;

namespace ProductSystem
{
    public partial class frmProduct : Form
    {
        enum State
        {
            NoState = 0,
            Search = 1,
            Add = 2
        }

        State currentState = State.NoState;
        State CurrentState//= State.NoState;
        {
            get
            {
                return currentState;
            }
            set
            {
                if (value == State.NoState)
                {
                    ResetParameters();

                    txtBoxProductName.Enabled = false;
                    txtBoxUnit.Enabled = false;
                    //datePicker.Enabled = false;
                    numUpDownPrice.Enabled = false;

                    buttonAdd.Enabled = false;
                    buttonUpdate.Enabled = false;
                    buttonDelete.Enabled = false;

                    buttonSearchSupplier.Enabled = false;
                    buttonSearchCategory.Enabled = false;
                }   
                //if (currentState != value) //if new state is different
                {
                    if (value == State.Add)
                    {
                        ResetParameters();

                        txtBoxProductName.Enabled = true;
                        txtBoxUnit.Enabled = true;
                        //datePicker.Enabled = true;
                        numUpDownPrice.Enabled = true;

                        buttonAdd.Enabled = true;
                        buttonUpdate.Enabled = false;
                        buttonDelete.Enabled = false;

                        buttonSearchSupplier.Enabled = true;
                        buttonSearchCategory.Enabled = true;
                    }
                    else if (value == State.Search)
                    {

                        txtBoxProductName.Enabled = true;
                        txtBoxUnit.Enabled = true;
                        //datePicker.Enabled = true;
                        numUpDownPrice.Enabled = true;

                        buttonAdd.Enabled = false;
                        buttonUpdate.Enabled = false;
                        buttonDelete.Enabled = true;

                        buttonSearchSupplier.Enabled = true;
                        buttonSearchCategory.Enabled = true;
                    }
                }
                currentState = value;
            }
        }

        public frmProduct()
        {
            InitializeComponent();

            CurrentState = State.NoState;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DBManager.DeleteEmployee(1012);
            //DBManager.UpdateEmployee(1011, "Percy", "Matthew", DateTime.Now);
            //ChangeState(State.NoState);
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new frmSearch(this).ShowDialog(this);
            new frmSearchProducts(this).ShowDialog(this);
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ChangeState(State.Add);
            CurrentState = State.Add;
        }

        private void ResetParameters()
        {
            txtBoxID.Clear();
            txtBoxUnit.Clear();
            txtBoxProductName.Clear();
            //datePicker.Value = DateTime.Now;
            numUpDownPrice.Value = Decimal.Zero;

            txtBoxSupplierID.Clear();
            txtBoxSupplierName.Clear();
            txtBoxCategoryID.Clear();
            txtBoxCategoryName.Clear();
        }



        public void UpdateSupplierInfo(int supplierID, string supplierName)
        {
            txtBoxSupplierID.Text = supplierID.ToString();
            txtBoxSupplierName.Text = supplierName;
        }
        public void UpdateCategoryInfo(int categoryID, string categoryName)
        {
            txtBoxCategoryID.Text = categoryID.ToString();
            txtBoxCategoryName.Text = categoryName;
        }

        public void UpdateParametersToSearch(int ID, string productName, int supplierID, string supplierName, int categoryID, string categoryName, string unit, float price)//string firstName, float price)//DateTime birth)
        {
            //ChangeState(State.Search);
            CurrentState = State.Search;

            textEditedByUser = false; //prevent data edited event from workng

            txtBoxID.Text = ID.ToString();
            txtBoxProductName.Text = productName;

            UpdateSupplierInfo(supplierID, supplierName);
            UpdateCategoryInfo(categoryID, categoryName);

            txtBoxUnit.Text = unit;
            numUpDownPrice.Value = Decimal.Parse(price.ToString());

            textEditedByUser = true;
        }
        private bool textEditedByUser = true;

        private void EmployeeDataEdited(object sender, EventArgs e)
        {
            //MessageBox.Show("hello there");
            if (currentState ==State.Search && textEditedByUser)
            {
                //MessageBox.Show("hello there");
                buttonUpdate.Enabled = true;
            }

        }



        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //if(string.IsNullOrWhiteSpace(txtBoxFirstName.Text)

            //DBManager.AddEmployee(txtBoxUnit.Text, txtBoxProductName.Text, datePicker.Value);
            try
            {
                DBManager.AddProduct(txtBoxProductName.Text, int.Parse(txtBoxSupplierID.Text), int.Parse(txtBoxCategoryID.Text), txtBoxUnit.Text, float.Parse(numUpDownPrice.Value.ToString()));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Parameters missing or invalid");
                return;
            }

            CurrentState = State.NoState;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            //DBManager.UpdateEmployee(int.Parse(txtBoxID.Text), txtBoxUnit.Text, txtBoxProductName.Text, datePicker.Value);

            DBManager.UpdateProduct(int.Parse(txtBoxID.Text), txtBoxProductName.Text, int.Parse(txtBoxSupplierID.Text), int.Parse(txtBoxCategoryID.Text), txtBoxUnit.Text, float.Parse(numUpDownPrice.Value.ToString()));

            CurrentState = State.NoState;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //DBManager.DeleteEmployee(int.Parse(txtBoxID.Text));

            DBManager.DeleteProduct(int.Parse(txtBoxID.Text));

            CurrentState = State.NoState;
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            //DBManager.AddProduct("test", 16, 1, "toasty", 99.99f);
            //DBManager.AddProduct("test", 16, 99, "toasty", 99.99f);
            
        }

        private void buttonSearchSupplier_Click(object sender, EventArgs e)
        {
            new frmSearchSupplier(this).ShowDialog();
        }

        private void buttonSearchCategory_Click(object sender, EventArgs e)
        {
            new frmSearchCategory(this).ShowDialog();
        }
    }
}
