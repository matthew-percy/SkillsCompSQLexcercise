using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLWindowsForm
{
    public partial class Form1 : Form
    {
        //insert,delete,update,add new employees

        public Form1()
        {
            InitializeComponent();
        }


        void UpdateTable()
        {
            string connectionString = "data source=DESKTOP-K25CGEP\\SQLEXPRESS;initial catalog = SOC; persist security info = True;Integrated Security = True; ";

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            SqlCommand command;
            SqlDataReader dataReader;
            string sql, Output = "";

            sql = " SELECT * FROM Employees";

            command = new SqlCommand(sql, conn);

            DataTable table = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(command);

            da.Fill(table);

            dataGrid.DataSource = table;


            conn.Close();

            dataBaseFirstNameTxtbox.ResetText();
            dataBaseLastNameTxtbox.ResetText();
            dataBaseDatePicker.Value = DateTime.Now;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateTable();

        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //firstNameTxtbox.Text = dataGrid.Rows[e.ColumnIndex].Cells[1].Value.ToString();
            dataBaseFirstNameTxtbox.Text = dataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            dataBaseLastNameTxtbox.Text = dataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();

            string[] birthdate = dataGrid.Rows[e.RowIndex].Cells[3].Value.ToString().Split('-',' ');

            //foreach (var d in birthdate)
            //{
            //    MessageBox.Show(d);
            //}

            //MessageBox.Show(

            dataBaseDatePicker.Value = new DateTime(int.Parse(birthdate[0]), int.Parse(birthdate[1]), int.Parse(birthdate[2]));

        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            string connectionString = "data source=DESKTOP-K25CGEP\\SQLEXPRESS;initial catalog = SOC; persist security info = True;Integrated Security = True; ";

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            SqlCommand command;
            SqlDataReader dataReader;
            string sql, Output = "";

            sql = "INSERT INTO Employees(FirstName, LastName,BirthDate) VALUES('" + firstNameTxtbox.Text + "', '" + lastNameTxtbox.Text + "','" + datePicker.Value.Year + '-' + datePicker.Value.Month + '-' + +datePicker.Value.Day +    "');";

            command = new SqlCommand(sql, conn);

            command.ExecuteNonQuery();

            conn.Close();

            UpdateTable();
        }

        private void buttonUpdateEmployee_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(dataBaseDatePicker.Value.Date.ToString());

            //UPDATE CustomersSET ContactName = 'Alfred Schmidt', City = 'Frankfurt'WHERE CustomerID = 1;


            string connectionString = "data source=DESKTOP-K25CGEP\\SQLEXPRESS;initial catalog = SOC; persist security info = True;Integrated Security = True; ";

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            SqlCommand command;
            SqlDataReader dataReader;
            string sql, Output = "";

            sql = "UPDATE Employees SET LastName = '" + lastNameTxtbox.Text + "', FirstName = '" + firstNameTxtbox.Text + "' WHERE LastName = '" + dataBaseLastNameTxtbox.Text + "' AND FirstName = '" + dataBaseFirstNameTxtbox.Text + "';";//"DELETE FROM Employees WHERE LastName = '" + dataBaseLastNameTxtbox.Text + "' AND FirstName='" + dataBaseFirstNameTxtbox.Text + "';";//"INSERT INTO Employees(FirstName, LastName,BirthDate) VALUES('" + firstNameTxtbox.Text + "', '" + lastNameTxtbox.Text + "','" + datePicker.Value.Year + '-' + datePicker.Value.Month + '-' + +datePicker.Value.Day + "');";

            command = new SqlCommand(sql, conn);

            command.ExecuteNonQuery();

            conn.Close();

            UpdateTable();
        }

        private void buttonRemoveEmployee_Click(object sender, EventArgs e)
        {
            //DELETE FROM Customers WHERE CustomerName = 'Alfreds Futterkiste';

            string connectionString = "data source=DESKTOP-K25CGEP\\SQLEXPRESS;initial catalog = SOC; persist security info = True;Integrated Security = True; ";

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            SqlCommand command;
            SqlDataReader dataReader;
            string sql, Output = "";

            sql = "DELETE FROM Employees WHERE LastName = '" + dataBaseLastNameTxtbox.Text + "' AND FirstName='" + dataBaseFirstNameTxtbox.Text +"';";//"INSERT INTO Employees(FirstName, LastName,BirthDate) VALUES('" + firstNameTxtbox.Text + "', '" + lastNameTxtbox.Text + "','" + datePicker.Value.Year + '-' + datePicker.Value.Month + '-' + +datePicker.Value.Day + "');";

            command = new SqlCommand(sql, conn);

            command.ExecuteNonQuery();

            conn.Close();

            UpdateTable();

        }
    }
}
