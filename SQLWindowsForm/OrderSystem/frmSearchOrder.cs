using SOC.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderSystem
{
    class frmSearchOrder: frmSearch
    {
        public frmSearchOrder(frmOrder frm) : base(frm) { }

        protected override void FormLoading()
        {
            dataGrid.DataSource = DBManager.SelectAllFromOrderTable(string.Empty);//SelectAllFromCustomerTable(string.Empty);//SelectAllFromEmployeeTable(string.Empty);//SelectAllFromShippingTable(string.Empty);
            base.FormLoading();
        }
        protected override void CellContentClicked(DataGridViewCellEventArgs e)
        {
            //int ID = int.Parse(dataGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
            //string name = dataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            int ID = int.Parse(dataGrid.Rows[e.RowIndex].Cells[0].Value.ToString());

            DateTime orderDate = DateTime.Parse(dataGrid.Rows[e.RowIndex].Cells[1].Value.ToString());

            int customerID = int.Parse(dataGrid.Rows[e.RowIndex].Cells[2].Value.ToString());
            string customerName = dataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();

            int employeeID = int.Parse(dataGrid.Rows[e.RowIndex].Cells[4].Value.ToString());
            string employeeName = dataGrid.Rows[e.RowIndex].Cells[5].Value.ToString();

            int shipperID = int.Parse(dataGrid.Rows[e.RowIndex].Cells[6].Value.ToString());
            string shipperName = dataGrid.Rows[e.RowIndex].Cells[7].Value.ToString();
            mainForm.UpdateOrderIDInfo(ID, orderDate, customerID, customerName, employeeID, employeeName, shipperID, shipperName);

            mainForm.UpdateOrderDetailsInfoDataTable(DBManager.SelectAllFromOrderDetailsTable(string.Empty,"A.ORDERID = " + ID));

            //mainForm.UpdateParametersToSearch(ID, orderDate, customerID, customerName, employeeID, employeeName, shipperID, shipperName);//UpdateCustomerInfo(ID, name);//UpdateEmployeeInfo(ID, name);//UpdateShipperInfo(ID, name);

        }
        protected override void SearchPressed()
        {
            dataGrid.DataSource = DBManager.SelectAllFromOrderTable(txtBoxSearch.Text);//SelectAllFromEmployeeTable(txtBoxSearch.Text);//SelectAllFromShippingTable(txtBoxSearch.Text);//SelectAllFromSupplierTable(txtBoxSearch.Text);
        }

    }
}
