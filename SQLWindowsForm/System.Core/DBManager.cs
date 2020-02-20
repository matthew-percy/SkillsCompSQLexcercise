using System;
using System.Data;
using System.Data.SqlClient;

namespace SOC.Core
{
    public static class DBManager
    {
        private const string ConnectionString = "data source=DESKTOP-K25CGEP\\SQLEXPRESS;initial catalog = SOC; persist security info = True;Integrated Security = True;";

        private static SqlConnection Connection { get; set; }

        static DBManager()
        {
            Connection = new SqlConnection(ConnectionString);
        }

        public static DataTable SelectAllFromProductTable(string condition)
        {
            Connection.Open();

            SqlCommand command = new SqlCommand();
            command.CommandText = @"
                                    DECLARE @SEARCH_INFO AS TABLE ( ProductID INT
                                    , ProductName  NVARCHAR(255)
							        , SupplierID INT
							        , SupplierName NVARCHAR(255)
							        , CategoryID INT
							        , CategoryName NVARCHAR(255)
							        , Unit   NVARCHAR(255)
						            , Price     FLOAT
							        , Search     VARCHAR(999)
						            )

                                    INSERT INTO @SEARCH_INFO ( ProductID 
                                     , ProductName  
						             , SupplierID 
						             , SupplierName 
					                 , CategoryID  
					            	 , CategoryName
					            	 , Unit
					            	 , Price   
					            	 , Search
					            	 )
						 
SELECT  A.ProductID
      , A.ProductName
      , A.SupplierID
	  , B.SupplierName
	  , A.CategoryID
	  , C.CategoryName
	  , A.Unit
	  , A.Price
	  , CONVERT(VARCHAR(20), A.ProductID) 
	  + A.ProductName
	  + CONVERT(VARCHAR(20), A.SupplierID)
	  + B.SupplierName
	  + CONVERT(VARCHAR(20), A.CategoryID)  
	  + C.CategoryName
	  + A.Unit
	  + CONVERT(VARCHAR(20), A.Price) AS [SEARCH]
  FROM Products A
       INNER JOIN Suppliers  B ON A.SupplierID = B.SupplierID
	   INNER JOIN Categories C ON A.CategoryID = C.CategoryID
	 
SELECT ProductID 
                         , ProductName  
						 , SupplierID 
						 , SupplierName 
						 , CategoryID  
						 , CategoryName
						 , Unit
						 , Price   
						 --, Search
  FROM @SEARCH_INFO
 where Search like ('%' + @SEARCH + '%')";

            command.Parameters.Add(new SqlParameter("SEARCH", condition));
            command.Connection = Connection;

            DataTable table = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(command);

            da.Fill(table);

            Connection.Close();

            return table;
        }

        public static DataTable SelectAllFromSupplierTable(string condition)
        {
            Connection.Open();

            SqlCommand command = new SqlCommand();
            command.CommandText = @"SELECT * FROM Suppliers";

            command.Parameters.Add(new SqlParameter("SEARCH", condition));
            command.Connection = Connection;

            DataTable table = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(command);

            da.Fill(table);

            Connection.Close();

            return table;
        }
        public static DataTable SelectAllFromCategoryTable(string condition)
        {
            Connection.Open();

            SqlCommand command = new SqlCommand();
            command.CommandText = @"SELECT * FROM Categories";

            command.Parameters.Add(new SqlParameter("SEARCH", condition));
            command.Connection = Connection;

            DataTable table = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(command);

            da.Fill(table);

            Connection.Close();

            return table;
        }


        public static void AddProduct(string productName,int supplierID, int categoryID, string unit, float price)//string lastName, string firstName, DateTime birth)
        {
            Connection.Open();

            SqlCommand command = new SqlCommand();
            command.CommandText = @" INSERT INTO[dbo].[Products]   ( [ProductName]
                                                                   , [SupplierID]
                                                                   , [CategoryID]
                                                                   , [Unit]
                                                                   , [Price])
                                                            VALUES ( @ProductName
                                                                   , @SupplierID
                                                                   , @CategoryID
                                                                   , @Unit
                                                                   , @Price
                                                                   )";
            command.Parameters.Add(new SqlParameter("ProductName", productName));
            command.Parameters.Add(new SqlParameter("SupplierID", supplierID));
            command.Parameters.Add(new SqlParameter("CategoryID", categoryID));
            command.Parameters.Add(new SqlParameter("Unit", unit));
            command.Parameters.Add(new SqlParameter("Price", price));
            //command.Parameters.Add(new SqlParameter("LastName", lastName));
            //command.Parameters.Add(new SqlParameter("FirstName", firstName));
            //command.Parameters.Add(new SqlParameter("BirthDate", birth));
            command.Connection = Connection;

            command.ExecuteNonQuery();

            Connection.Close();
        }
        public static void DeleteProduct(int employee)
        {

        }
        public static void UpdateProduct(int employee, string lastName, string firstName, DateTime birth)
        {

        }




        public static DataTable SelectAllFromEmployeeTable(string condition)
        {
            Connection.Open();


            SqlCommand command = new SqlCommand();
            command.CommandText = @"
                                    DECLARE @SEARCH_INFO AS TABLE ( EmployeeID INT
                                                                  , FirstName  VARCHAR(255)
							                                      , LastName   VARCHAR(255)
							                                      , BirthDate  DATE
							                                      , Search     VARCHAR(999)
							                                      )

                                   INSERT INTO @SEARCH_INFO ( EmployeeID 
                                                            , FirstName  
						                                    , LastName  
						                                    , BirthDate  
						                                    , Search     
						                                    )
                                            SELECT EmployeeID
                                                  , FirstName
                                                  , LastName
	                                              , BirthDate
	                                              , CONVERT(VARCHAR(20), EmployeeID) 
	                                              + FirstName
	                                              + LastName
	                                              + CONVERT(VARCHAR(20),BirthDate,101) AS [SEARCH]
                                              FROM Employees
	 
                                            SELECT EmployeeID
                                                 , LastName
                                                 , FirstName
	                                             , BirthDate
                                              FROM @SEARCH_INFO
                                             where Search like ('%' + @SEARCH + '%')";

            command.Parameters.Add(new SqlParameter("SEARCH", condition));
            command.Connection = Connection;

            DataTable table = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(command);

            da.Fill(table);

            Connection.Close();

            return table;
        }

        public static void AddEmployee(string lastName, string firstName, DateTime birth)
        {
            Connection.Open();

            SqlCommand command = new SqlCommand();
            command.CommandText = @" INSERT INTO [dbo].[Employees] ( [LastName]
                                                                   , [FirstName]
                                                                   , [BirthDate])
                                                            VALUES ( @LastName
                                                                   , @FirstName
                                                                   , @BirthDate
                                                                   )";
            command.Parameters.Add(new SqlParameter("LastName", lastName));
            command.Parameters.Add(new SqlParameter("FirstName", firstName));
            command.Parameters.Add(new SqlParameter("BirthDate", birth));
            command.Connection = Connection;

            command.ExecuteNonQuery();

            Connection.Close();
        }

        public static void DeleteEmployee(int employee)
        {
            Connection.Open();

            SqlCommand command = new SqlCommand();
            command.CommandText = @"DELETE FROM [dbo].[Employees]
                                           WHERE EmployeeID = @EmployeeID";
            command.Parameters.Add(new SqlParameter("EmployeeID", employee));
            command.Connection = Connection;

            command.ExecuteNonQuery();

            Connection.Close();
        }

        public static void UpdateEmployee(int employee, string lastName, string firstName, DateTime birth)
        {
            Connection.Open();

            SqlCommand command = new SqlCommand();
            command.CommandText = @"UPDATE [dbo].[Employees]
                                           SET [LastName] = @LastName
                                              ,[FirstName] = @FirstName
                                              ,[BirthDate] = @BirthDate
                                                          WHERE EmployeeID = @EmployeeID";

            command.Parameters.Add(new SqlParameter("LastName", lastName));
            command.Parameters.Add(new SqlParameter("FirstName", firstName));
            command.Parameters.Add(new SqlParameter("BirthDate", birth));
            command.Parameters.Add(new SqlParameter("EmployeeID", employee));
            command.Connection = Connection;

            command.ExecuteNonQuery();

            Connection.Close();
        }

    }
}
