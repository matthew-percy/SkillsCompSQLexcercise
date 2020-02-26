﻿using SOC.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderSystem
{
    class frmSearchCustomer: frmSearch
    {
        public frmSearchCustomer(frmOrder frm) : base(frm) { }

        protected override void FormLoading()
        {
            dataGrid.DataSource = DBManager.SelectAllFromCustomerTable(string.Empty);//SelectAllFromEmployeeTable(string.Empty);//SelectAllFromShippingTable(string.Empty);
            base.FormLoading();
        }
        protected override void CellContentClicked(DataGridViewCellEventArgs e)
        {
            int ID = int.Parse(dataGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
            string name = dataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();

            mainForm.UpdateCustomerInfo(ID, name);//UpdateEmployeeInfo(ID, name);//UpdateShipperInfo(ID, name);

        }
        protected override void SearchPressed()
        {
            dataGrid.DataSource = DBManager.SelectAllFromEmployeeTable(txtBoxSearch.Text);//SelectAllFromEmployeeTable(txtBoxSearch.Text);//SelectAllFromShippingTable(txtBoxSearch.Text);//SelectAllFromSupplierTable(txtBoxSearch.Text);
        }

    }
}
