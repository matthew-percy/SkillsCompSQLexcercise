using SOC.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductSystem
{
    class frmSearchSupplier : frmSearch
    {
        public frmSearchSupplier(frmProduct frm) : base(frm) { }

        protected override void FormLoading()
        {
            dataGrid.DataSource = DBManager.SelectAllFromSupplierTable(string.Empty);
            base.FormLoading();
        }
        protected override void CellContentClicked(DataGridViewCellEventArgs e)
        {
            int ID = int.Parse(dataGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
            string name = dataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();

            mainForm.UpdateSupplierInfo(ID, name);

        }
        protected override void SearchPressed()
        {
            dataGrid.DataSource = DBManager.SelectAllFromSupplierTable(txtBoxSearch.Text);
        }
    }
    class frmSearchCategory : frmSearch
    {
        public frmSearchCategory(frmProduct frm) : base(frm) { }

        protected override void FormLoading()
        {
            dataGrid.DataSource = DBManager.SelectAllFromCategoryTable(string.Empty);
            base.FormLoading();
        }
        protected override void CellContentClicked(DataGridViewCellEventArgs e)
        {
            int ID = int.Parse(dataGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
            string name = dataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();

            mainForm.UpdateCategoryInfo(ID, name);
        }
        protected override void SearchPressed()
        {
            dataGrid.DataSource = DBManager.SelectAllFromCategoryTable(txtBoxSearch.Text);
        }
    }
    class frmSearchProducts : frmSearch
    {
        public frmSearchProducts(frmProduct frm) : base(frm) { }

        protected override void FormLoading()
        {
            dataGrid.DataSource = DBManager.SelectAllFromProductTable(string.Empty);
            base.FormLoading();
        }
        protected override void CellContentClicked(DataGridViewCellEventArgs e)
        {
            int ID = int.Parse(dataGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
            string productname = dataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();

            int supplierID = int.Parse(dataGrid.Rows[e.RowIndex].Cells[2].Value.ToString());
            string supplierName = dataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();

            int categoryID = int.Parse(dataGrid.Rows[e.RowIndex].Cells[4].Value.ToString());
            string categoryName = dataGrid.Rows[e.RowIndex].Cells[5].Value.ToString();

            string unit = dataGrid.Rows[e.RowIndex].Cells[6].Value.ToString();

            float price = float.Parse(dataGrid.Rows[e.RowIndex].Cells[7].Value.ToString());

            mainForm.UpdateParametersToSearch(ID, productname, supplierID, supplierName, categoryID, categoryName, unit, price);
        }
        protected override void SearchPressed()
        {
            //base.SearchPressed();
            dataGrid.DataSource = DBManager.SelectAllFromProductTable(txtBoxSearch.Text);
        }

    }


}
