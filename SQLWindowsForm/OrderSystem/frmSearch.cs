using System;
using System.Windows.Forms;
using System.Data;
using SOC.Core;

namespace OrderSystem
{
    public partial class frmSearch : Form
    {

        protected frmOrder mainForm;

        public frmSearch(frmOrder frm)//, Table table)
        {
            InitializeComponent();
            mainForm = frm;
            //tableToSearch = table;
        }

        protected virtual void FormLoading()
        {
            txtBoxSearch.Focus();
        }

        private void frmSearchEmployee_Load(object sender, EventArgs e)
        {
            try
            {
                FormLoading();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected virtual void CellContentClicked(DataGridViewCellEventArgs e) { }


        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                CellContentClicked(e);
            }
            catch (Exception ex)
            {
                return; //Do nothing, we were unable to retrieve a valid value
            }
            this.Close();
        }

        protected virtual void SearchPressed() { }


        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //dataGrid.DataSource = DBManager.SelectAllFromEmployeeTable(txtBoxSearch.Text);
            //dataGrid.DataSource = DBManager.SelectAllFromProductTable(txtBoxSearch.Text);
            SearchPressed();
            if (((DataTable)dataGrid.DataSource).Rows.Count == 0)
                dataGrid.Enabled = false;
            else
                dataGrid.Enabled = true;
        }
    }
}
