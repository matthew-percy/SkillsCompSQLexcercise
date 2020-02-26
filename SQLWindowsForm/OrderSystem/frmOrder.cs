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

namespace OrderSystem
{
    public partial class frmOrder : Form
    {
        enum OrderDetailState
        {
            NoState = 0,
            NoStateAddEnabled = 1,
            Update = 2,
            Add = 3
        }

        OrderDetailState currentDetailState = OrderDetailState.NoState;
        OrderDetailState CurrentDetailState
        {
            get
            {
                return currentDetailState;
            }
            set
            {
                if (value == OrderDetailState.NoState)
                {
                    ResetOrderDetailParameters();

                    buttonDetailAdd.Enabled = false;
                    buttonDetailUpdate.Enabled = false;
                    buttonDetailDelete.Enabled = false;

                    buttonOrderDetailAddMode.Enabled = false;

                    OrderDetailEditingEnabled = false;
                }
                if (value == OrderDetailState.NoStateAddEnabled)
                {
                    ResetOrderDetailParameters();

                    buttonDetailAdd.Enabled = false;
                    buttonDetailUpdate.Enabled = false;
                    buttonDetailDelete.Enabled = false;

                    buttonOrderDetailAddMode.Enabled = true;

                    OrderDetailEditingEnabled = false;
                }

                else if (value == OrderDetailState.Add)
                {
                    ResetOrderDetailParameters(false);

                    buttonDetailAdd.Enabled = true;
                    buttonDetailUpdate.Enabled = false;
                    buttonDetailDelete.Enabled = false;

                    buttonOrderDetailAddMode.Enabled = true;

                    OrderDetailEditingEnabled = true;
                }
                else if (value == OrderDetailState.Update)
                {
                    buttonDetailAdd.Enabled = false;
                    buttonDetailUpdate.Enabled = false;
                    buttonDetailDelete.Enabled = true;

                    buttonOrderDetailAddMode.Enabled = true;

                    OrderDetailEditingEnabled = true;
                }
                currentDetailState = value;
            }
        }


        enum OrderState
        {
            NoState = 0,
            Search = 2,
            Add = 3
        }

        OrderState currentState = OrderState.NoState;
        OrderState CurrentState//= State.NoState;
        {
            get
            {
                return currentState;
            }
            set
            {
                if (value == OrderState.NoState)
                {
                    //ResetParameters();
                    ResetOrderParameters();

                    buttonAdd.Enabled = false;
                    buttonUpdate.Enabled = false;
                    buttonDelete.Enabled = false;

                    OrderEditingEnabled = false;

                    //OrderDetailEditingEnabled = false;
                    CurrentDetailState = OrderDetailState.NoState;
                }   
                //if (currentState != value) //if new state is different
                {
                    if (value == OrderState.Add)
                    {
                        //ResetParameters();
                        ResetOrderParameters();

                        buttonAdd.Enabled = true;
                        buttonUpdate.Enabled = false;
                        buttonDelete.Enabled = false;


                        OrderEditingEnabled = true;
                        //OrderDetailEditingEnabled = false;
                        CurrentDetailState = OrderDetailState.NoState;//AddEnabled;
                    }
                    else if (value == OrderState.Search)
                    {
                        buttonAdd.Enabled = false;
                        buttonUpdate.Enabled = false;
                        buttonDelete.Enabled = true;

                        OrderEditingEnabled = true;
                        //OrderDetailEditingEnabled = false;
                        CurrentDetailState = OrderDetailState.NoStateAddEnabled;
                    }
                }
                currentState = value;
            }
        }

        private bool OrderEditingEnabled
        {
            set
            {
                datePickerOrderDate.Enabled = value;
                buttonSearchCustomer.Enabled = value;
                buttonSearchEmployee.Enabled = value;
                buttonSearchShipper.Enabled = value;
            }
        }
        private bool OrderDetailEditingEnabled
        {
            set
            {
                numUpDownQuantity.Enabled = value;
                buttonSearchProduct.Enabled = value;
            }
        }


        public frmOrder()
        {
            InitializeComponent();

            CurrentState = OrderState.NoState;
            CurrentDetailState = OrderDetailState.NoState;
        }




        private void ResetOrderParameters()
        {
            txtBoxOrderID.Clear();
            datePickerOrderDate.Value = DateTime.Now;
            txtBoxCustomerID.Clear();
            txtBoxCustomerName.Clear();

            txtBoxEmployeeID.Clear();
            txtBoxEmployeeName.Clear();
            txtBoxShipperID.Clear();
            txtBoxShipperName.Clear();
        }
        private void ResetOrderDetailParameters(bool includeDataTable = true)
        {
            txtBoxID.Clear();
            txtBoxProductID.Clear();
            txtBoxProductName.Clear();
            numUpDownQuantity.Value = 0;

            if(includeDataTable) dataGridProductQuantity.DataSource = null;
        }
        private void ResetParameters()
        {
            ResetOrderParameters();
            ResetOrderDetailParameters();
        }

        public void UpdateCustomerInfo(int customerID, string customerName)
        {
            txtBoxCustomerID.Text = customerID.ToString();
            txtBoxCustomerName.Text = customerName;
        }
        public void UpdateEmployeeInfo(int employeeID, string employeeName)
        {
            txtBoxEmployeeID.Text = employeeID.ToString();
            txtBoxEmployeeName.Text = employeeName;
        }
        public void UpdateShipperInfo(int shipperID, string shipperName)
        {
            txtBoxShipperID.Text = shipperID.ToString();
            txtBoxShipperName.Text = shipperName;
        }
        public void UpdateProductInfo(int productID, string productName)
        {
            txtBoxProductID.Text = productID.ToString();
            txtBoxProductName.Text = productName;
        }
        public void UpdateOrderIDInfo(int ID,DateTime orderDate, int customerID,string customerName,int employeeID,string employeeName,int shipperID, string shipperName) //int ID, string productName, int supplierID, string supplierName, int categoryID, string categoryName, string unit, float price)//string firstName, float price)//DateTime birth)
        {
            //ChangeState(State.Search);
            //CurrentState = State.Search;

            CurrentState = OrderState.Search;

            orderEditedByUser = false; //prevent data edited event from workng


            txtBoxOrderID.Text = ID.ToString();
            datePickerOrderDate.Value = orderDate;

            UpdateCustomerInfo(customerID,customerName);
            UpdateEmployeeInfo(employeeID,employeeName);
            UpdateShipperInfo(shipperID,shipperName);

            orderEditedByUser = true;
        }
        public void UpdateOrderDetailsInfoDataTable(DataTable dt)
        {
            dataGridProductQuantity.DataSource = dt;

            foreach (DataGridViewColumn col in dataGridProductQuantity.Columns)
            {
                if (col.Index >= 4) col.Visible = false;
            }
            //dataGridProductQuantity.Columns[
            dataGridProductQuantity.ClearSelection();
        }
        public void UpdateOrderDetailsInfoCurrentSelection(int orderDetailID, int productID, string productName, int quantity)
        {
            CurrentDetailState = OrderDetailState.Update;

            orderDetailEditedByUser = false;

            txtBoxID.Text = orderDetailID.ToString();
            txtBoxProductID.Text = productID.ToString();
            txtBoxProductName.Text = productName;
            numUpDownQuantity.Value = quantity;

            orderDetailEditedByUser = true;
        }


        //no
        public void UpdateOrderDetailsInfoForSearch(int orderDetailID, int productID, string productName, int quantity,int orderID, DateTime orderDate, int customerID, string customerName, int employeeID, string employeeName, int shipperID, string shipperName) //int ID, string productName, int supplierID, string supplierName, int categoryID, string categoryName, string unit, float price)//string firstName, float price)//DateTime birth)
        {
            //ChangeState(State.Search);
            CurrentState = OrderState.Search;

            orderEditedByUser = false; //prevent data edited event from workng

            txtBoxID.Text = orderDetailID.ToString();
            txtBoxProductID.Text = productID.ToString();
            txtBoxProductName.Text = productName;
            numUpDownQuantity.Value = quantity;

            //dataGridProductQuantity.Rows.Add(

            dataGridProductQuantity.DataSource = DBManager.SelectProductAndQuantiyFromOrderDetailsTable(orderID);
            //dataGridProductQuantity.Rows[0].ReadOnly = true;
            //dataGridProductQuantity.Rows[1].ReadOnly = true;

            /*
            foreach (DataGridViewRow row in dataGridProductQuantity.Rows)
            {
                row.Cells[0].ReadOnly = true;
                row.Cells[1].ReadOnly = true;
            }
            */
            UpdateOrderIDInfo(orderID, orderDate, customerID, customerName, employeeID, employeeName, shipperID, shipperName);

            orderEditedByUser = true;



        }


        private bool orderEditedByUser = true;
        private void OrderDataEdited(object sender, EventArgs e)
        {
            if (currentState ==OrderState.Search && orderEditedByUser)
            {
                buttonUpdate.Enabled = true;
            }
        }

        private bool orderDetailEditedByUser = true;
        private void OrderDetailDataEdited(object sender, EventArgs e)
        {
            if (currentDetailState == OrderDetailState.Update && orderDetailEditedByUser)
            {
                buttonDetailUpdate.Enabled = true;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int orderID = DBManager.AddOrder(int.Parse(txtBoxCustomerID.Text), int.Parse(txtBoxEmployeeID.Text), datePickerOrderDate.Value, int.Parse(txtBoxShipperID.Text));
                //dataGridProductQuantity.DataSource = DBManager.AddOrder(int.Parse(txtBoxCustomerID.Text), int.Parse(txtBoxEmployeeID.Text), datePickerOrderDate.Value, int.Parse(txtBoxShipperID.Text));


                txtBoxOrderID.Text = orderID.ToString();
                /*
                //if (CurrentState == OrderState.Add)
                {
                    foreach (DataGridViewRow row in dataGridProductQuantity.Rows)
                    {
                        try {

                            int ID = int.Parse(txtBoxOrderID.Text);
                            int productID = int.Parse(row.Cells[1].Value.ToString());
                            int quantity = int.Parse(row.Cells[3].Value.ToString());

                            DBManager.AddOrderDetail(ID, productID, quantity);
                        }
                        catch (NullReferenceException ex) { } //ignore empty row at bottom
                    }
                }*/

                //Add Order Details

            }
            catch (Exception ex)
            {
                MessageBox.Show("Parameters missing or invalid");
                return;
            }


            //txtBoxOrderID.Text = DBManager.ReturnMostRecentlyGeneratedID().ToString();
            //buttonAdd.Enabled = false;
            CurrentState = OrderState.Search;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            DBManager.UpdateOrder(int.Parse(txtBoxOrderID.Text),int.Parse(txtBoxCustomerID.Text),int.Parse(txtBoxEmployeeID.Text),datePickerOrderDate.Value,int.Parse(txtBoxShipperID.Text));

            buttonUpdate.Enabled = false;
            //CurrentState = OrderState.NoState;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //Delete order details first
            //dataGridProductQuantity.Rows[

            //foreach (DataGridViewRow row in dataGridProductQuantity.Rows)
            {
            //    try{ DBManager.DeleteOrderDetail(int.Parse(row.Cells[0].Value.ToString())); }
            //    catch (NullReferenceException ex) { } //ignore empty row at bottom
            }

            
            DBManager.DeleteOrder(int.Parse(txtBoxOrderID.Text));

            CurrentState = OrderState.NoState;
        }



        private void buttonSearchCustomer_Click(object sender, EventArgs e)
        {
            new frmSearchCustomer(this).ShowDialog(this);
        }
        private void buttonSearchEmployee_Click(object sender, EventArgs e)
        {
            new frmSearchEmployee(this).ShowDialog(this);
        }
        private void buttonSearchShipper_Click(object sender, EventArgs e)
        {
            new frmSearchShipper(this).ShowDialog(this);
        }
        private void buttonExistingOrder_Click(object sender, EventArgs e)
        {
            new frmSearchOrder(this).ShowDialog(this);
        }
        private void buttonSearchProduct_Click(object sender, EventArgs e)
        {
            new frmSearchProduct(this).ShowDialog(this);
        }
        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmSearchOrder(this).ShowDialog(this);
        }
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentState = OrderState.Add;
        }

        private void dataGridProductQuantity_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int ID = int.Parse(dataGridProductQuantity.Rows[e.RowIndex].Cells[0].Value.ToString());
                int productID = int.Parse(dataGridProductQuantity.Rows[e.RowIndex].Cells[1].Value.ToString());
                string productName = dataGridProductQuantity.Rows[e.RowIndex].Cells[2].Value.ToString();
                int quantity = int.Parse(dataGridProductQuantity.Rows[e.RowIndex].Cells[3].Value.ToString());

                UpdateOrderDetailsInfoCurrentSelection(ID, productID, productName, quantity);
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void buttonDetailUpdate_Click(object sender, EventArgs e)
        {
            DBManager.UpdateOrderDetail(int.Parse(txtBoxID.Text), int.Parse(txtBoxOrderID.Text), int.Parse(txtBoxProductID.Text), int.Parse(numUpDownQuantity.Value.ToString()));

            CurrentDetailState = OrderDetailState.NoStateAddEnabled;

            UpdateOrderDetailsInfoDataTable(DBManager.SelectAllFromOrderDetailsTable(string.Empty, "A.ORDERID = " + txtBoxOrderID.Text));
        }

        private void buttonDetailDelete_Click(object sender, EventArgs e)
        {
            DBManager.DeleteOrderDetail(int.Parse(txtBoxID.Text));

            CurrentDetailState = OrderDetailState.NoStateAddEnabled;

            UpdateOrderDetailsInfoDataTable(DBManager.SelectAllFromOrderDetailsTable(string.Empty, "A.ORDERID = " + txtBoxOrderID.Text));

        }

        private void buttonDetailAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int orderID = int.Parse(txtBoxOrderID.Text);
                int productID = int.Parse(txtBoxProductID.Text);
                int quantity = int.Parse(numUpDownQuantity.Value.ToString());

                DBManager.AddOrderDetail(orderID,productID,quantity);

                CurrentDetailState = OrderDetailState.NoStateAddEnabled;

                UpdateOrderDetailsInfoDataTable(DBManager.SelectAllFromOrderDetailsTable(string.Empty, "A.ORDERID = " + txtBoxOrderID.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Parameters missing or invalid");
            }
        }

        private void buttonOrderDetailAddMode_Click(object sender, EventArgs e)
        {
            CurrentDetailState = OrderDetailState.Add;
        }
    }
}
