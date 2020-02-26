using SOC.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderSystem
{
    class frmSearchOrderDetails: frmSearch
    {
        public frmSearchOrderDetails(frmOrder frm) : base(frm) { }

        protected override void FormLoading()
        {
            dataGrid.DataSource = DBManager.SelectAllFromOrderDetailsTable(string.Empty);//SelectAllFromOrderTable(string.Empty);//SelectAllFromCustomerTable(string.Empty);//SelectAllFromEmployeeTable(string.Empty);//SelectAllFromShippingTable(string.Empty);
            base.FormLoading();
        }
        protected override void CellContentClicked(DataGridViewCellEventArgs e)
        {
            int ID = int.Parse(dataGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
            //string name = dataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            int productID = int.Parse(dataGrid.Rows[e.RowIndex].Cells[1].Value.ToString());
            string productName = dataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();

            int quantity = int.Parse(dataGrid.Rows[e.RowIndex].Cells[3].Value.ToString());

            int orderID = int.Parse(dataGrid.Rows[e.RowIndex].Cells[4].Value.ToString());

            DateTime orderDate = DateTime.Parse(dataGrid.Rows[e.RowIndex].Cells[5].Value.ToString());

            int customerID = int.Parse(dataGrid.Rows[e.RowIndex].Cells[6].Value.ToString());
            string customerName = dataGrid.Rows[e.RowIndex].Cells[7].Value.ToString();

            int employeeID = int.Parse(dataGrid.Rows[e.RowIndex].Cells[8].Value.ToString());
            string employeeName = dataGrid.Rows[e.RowIndex].Cells[9].Value.ToString();

            int shipperID = int.Parse(dataGrid.Rows[e.RowIndex].Cells[10].Value.ToString());
            string shipperName = dataGrid.Rows[e.RowIndex].Cells[11].Value.ToString();


            mainForm.UpdateOrderDetailsInfoForSearch(ID, productID, productName, quantity, orderID, orderDate, customerID, customerName, employeeID, employeeName, shipperID, shipperName);
            //mainForm.UpdateParametersToSearch(ID, orderDate, customerID, customerName, employeeID, employeeName, shipperID, shipperName);//UpdateCustomerInfo(ID, name);//UpdateEmployeeInfo(ID, name);//UpdateShipperInfo(ID, name);

        }
        protected override void SearchPressed()
        {
            dataGrid.DataSource = DBManager.SelectAllFromOrderDetailsTable(txtBoxSearch.Text);//SelectAllFromEmployeeTable(txtBoxSearch.Text);//SelectAllFromEmployeeTable(txtBoxSearch.Text);//SelectAllFromShippingTable(txtBoxSearch.Text);//SelectAllFromSupplierTable(txtBoxSearch.Text);

        }

    }
}
