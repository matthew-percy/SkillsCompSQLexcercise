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
            command.CommandText = @"
                                    DECLARE @SEARCH_INFO AS TABLE ( SupplierID INT
                              , SupplierName  NVARCHAR(255)
							  , ContactName NVARCHAR(255)
							  , ContactAddress NVARCHAR(255)
							  , City NVARCHAR(255)
							  , PostalCode NVARCHAR(255)
							  , Country  NVARCHAR(255)
							  , Phone      NVARCHAR(255)
							  , Search     VARCHAR(999)
							  )

INSERT INTO @SEARCH_INFO ( A.SupplierID
						 , A.SupplierName
					     , A.ContactName
						 , A.ContactAddress
					     , A.City
					     , A.PostalCode
					   	 , A.Country
						 , A.Phone   
						 , Search
						 )
						 
SELECT  A.SupplierID
      , A.SupplierName
      , A.ContactName
	  , A.ContactAddress
	  , A.City
	  , A.PostalCode
	  , A.Country
	  , A.Phone
	  , CONVERT(VARCHAR(20), A.SupplierID) 
	  + A.SupplierName
	  + A.ContactName
	  + A.ContactAddress
	  + A.City
	  + A.PostalCode
	  + A.Country
	  + A.Phone AS [SEARCH]
  FROM Suppliers A
	 
SELECT  
                           SupplierID 
						 , SupplierName 
						 , ContactName
						 , ContactAddress 
						 , City
						 , PostalCode
						 , Country
						 , Phone  
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
        public static DataTable SelectAllFromCategoryTable(string condition)
        {
            Connection.Open();
             
            SqlCommand command = new SqlCommand();
            command.CommandText = @"
                                    DECLARE @SEARCH_INFO AS TABLE ( CategoryID INT
                              , CategoryName  NVARCHAR(255)
							  , CategoryDesc NVARCHAR(255)
							  , Search     VARCHAR(999)
							  )

INSERT INTO @SEARCH_INFO ( A.CategoryID
						 , A.CategoryName
					     , A.CategoryDesc   
						 , Search
						 )
						 
SELECT  A.CategoryID
      , A.CategoryName
      , A.CategoryDesc
	  , CONVERT(VARCHAR(20), A.CategoryID) 
	  + A.CategoryName
	  + A.CategoryDesc AS [SEARCH]
  FROM Categories A
	 
SELECT  
                           CategoryID 
						 , CategoryName
						 , CategoryDesc
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

        public static DataTable SelectAllFromCustomerTable(string condition)
        {
            Connection.Open();

            SqlCommand command = new SqlCommand();
            command.CommandText = @"
                                   DECLARE @SEARCH_INFO AS TABLE ( CustomerID INT
                              , CustomerName  NVARCHAR(255)
							  , ContactName NVARCHAR(255)
							  , ContactAddress NVARCHAR(255)
							  , City  NVARCHAR(255)
							  , PostalCode NVARCHAR(255)
							  , Country NVARCHAR(255)
							  , Search     VARCHAR(999)
							  )

INSERT INTO @SEARCH_INFO ( A.CustomerID
      , A.CustomerName
      , A.ContactName
	  , A.ContactAddress
	  , A.City
	  , A.PostalCode
	  , A.Country 
						 , Search
						 )
						 
SELECT  A.CustomerID
      , A.CustomerName
      , A.ContactName
	  , A.ContactAddress
	  , A.City
	  , A.PostalCode
	  , A.Country
	  , CONVERT(VARCHAR(20), A.CustomerID) 
	  + A.CustomerName
	  + A.ContactName
	  + A.ContactAddress
	  + A.City
	  + A.PostalCode
	  + A.Country AS [SEARCH]
  FROM Customers A
	 
SELECT  
                           CustomerID
					   	 , CustomerName
					   , ContactName
					  , ContactAddress
					  , City
					  , PostalCode
					  , Country
						 , Search
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
        public static DataTable SelectAllFromShippingTable(string condition)
        {
            Connection.Open();

            SqlCommand command = new SqlCommand();
            command.CommandText = @"
                                   DECLARE @SEARCH_INFO AS TABLE ( ShipperID INT
                              , ShipperName  NVARCHAR(255)
							  , Phone NVARCHAR(255)
							  , Search     VARCHAR(999)
							  )

INSERT INTO @SEARCH_INFO ( A.ShipperID
						 , A.ShipperName
					     , A.Phone  
						 , Search
						 )
						 
SELECT  A.ShipperID
      , A.ShipperName
      , A.Phone
	  , CONVERT(VARCHAR(20), A.ShipperID) 
	  + A.ShipperName
	  + A.Phone AS [SEARCH]
  FROM Shippers A
	 
SELECT  
                           ShipperID
						 , ShipperName
						 , Phone
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
        public static DataTable SelectAllFromOrderTable(string condition)
        {
            Connection.Open();

            SqlCommand command = new SqlCommand();
            command.CommandText = @"
                                    SELECT A.OrderID,A.OrderDate, B.CustomerID,B.CustomerName, C.EmployeeID, C.FirstName + ' ' + C.LastName AS EmployeeName,D.ShipperID,D.ShipperName FROM Orders A
			  INNER JOIN Customers B ON A.CustomerID = B.CustomerID
			  INNER JOIN Employees C ON A.EmployeeID = C.EmployeeID
			  INNER JOIN Shippers D ON A.ShipperID = D.ShipperID
							  ";

            command.Parameters.Add(new SqlParameter("SEARCH", condition));
            command.Connection = Connection;

            DataTable table = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(command);

            da.Fill(table);

            Connection.Close();

            return table;
        }

        public static DataTable SelectAllFromOrderDetailsTable(string likeCondition = "", string whereCondition = null)
        {
            Connection.Open();


            SqlCommand command = new SqlCommand();
            /*command.CommandText = @"
                                    SELECT A.OrderDetailID,F.ProductID,F.ProductName,A.Quantity,B.OrderID,B.OrderDate,C.CustomerID,C.CustomerName,D.EmployeeID,D.FirstName + ' ' + D.LastName AS EmployeeName, E.ShipperID, E.ShipperName FROM--A.OrderDetailID,A.OrderID,B.CustomerID,B.EmployeeID,B.ShipperID,A.ProductID,A.Quantity FROM 
 
 
 
			   OrderDetails A INNER JOIN Orders B ON A.OrderID = B.OrderID
							  INNER JOIN Customers C ON B.CustomerID = C.CustomerID
							  INNER JOIN Employees D ON B.EmployeeID = D.EmployeeID
							  INNER JOIN Shippers E ON B.ShipperID = E.ShipperID
							  INNER JOIN Products F ON A.ProductID = F.ProductID
							  WHERE";*/

            string sqlCommand = @"
                                    SELECT A.OrderDetailID,F.ProductID,F.ProductName,A.Quantity,B.OrderID,B.OrderDate,C.CustomerID,C.CustomerName,D.EmployeeID,D.FirstName + ' ' + D.LastName AS EmployeeName, E.ShipperID, E.ShipperName FROM--A.OrderDetailID,A.OrderID,B.CustomerID,B.EmployeeID,B.ShipperID,A.ProductID,A.Quantity FROM 
 
 
 
			   OrderDetails A INNER JOIN Orders B ON A.OrderID = B.OrderID
							  INNER JOIN Customers C ON B.CustomerID = C.CustomerID
							  INNER JOIN Employees D ON B.EmployeeID = D.EmployeeID
							  INNER JOIN Shippers E ON B.ShipperID = E.ShipperID
							  INNER JOIN Products F ON A.ProductID = F.ProductID
							  ";

            if (!string.IsNullOrWhiteSpace(whereCondition))
            {
                sqlCommand += " WHERE " + whereCondition;
            }

            command.CommandText = sqlCommand;

            command.Parameters.Add(new SqlParameter("SEARCH", likeCondition));
            command.Connection = Connection;

            DataTable table = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(command);

            da.Fill(table);

            Connection.Close();

            return table;
        }
        public static DataTable SelectProductAndQuantiyFromOrderDetailsTable(int id)
        {
            Connection.Open();


            SqlCommand command = new SqlCommand();
            command.CommandText = @"
                                    SELECT C.ProductName as Name, A.Quantity as Quantity FROM OrderDetails A INNER JOIN Orders B ON A.OrderID = B.OrderID 
												   INNER JOIN Products C ON A.ProductID = C.ProductID
                                                    WHERE A.OrderID = @SEARCH
							  ";


            //   command.CommandText = @"
            //                           SELECT A.ProductID,C.ProductName, A.Quantity FROM OrderDetails A INNER JOIN Orders B ON A.OrderID = B.OrderID 
            //			   INNER JOIN Products C ON A.ProductID = C.ProductID
            //                                           WHERE A.OrderID = @SEARCH
            //";

            command.Parameters.Add(new SqlParameter("SEARCH", id));
            command.Connection = Connection;

            DataTable table = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(command);

            da.Fill(table);

            Connection.Close();

            return table;
        }

        public static string ReturnMostRecentlyGeneratedID()
        {
            Connection.Open();


            SqlCommand command = new SqlCommand();
            command.CommandText = @"SELECT @@IDENTITY";

            //command.Parameters.Add(new SqlParameter("SEARCH", condition));
            command.Connection = Connection;

            //DataTable table = new DataTable();

            SqlDataReader rd = command.ExecuteReader();//new SqlDataAdapter(command);

            string test = "";
            int id = -1;
            if (rd.HasRows)
            {
                rd.Read();
                test = rd.GetString(-1);
                //id =  rd.GetInt32(0);
            }

            //da.Fill(table);

            Connection.Close();

            //return table.Rows[0].Field(0);

            //return table;
            return test;// id;
        }

        public static int AddOrder(int customerID,int employeeID,DateTime orderDate, int shipperID)
        {
            Connection.Open();

            SqlCommand command = new SqlCommand();
            command.CommandText = @"
INSERT INTO [dbo].[Orders]
           ([CustomerID]
           ,[EmployeeID]
           ,[OrderDate]
           ,[ShipperID])
     VALUES
           (@CustomerID
           ,@EmployeeID
           ,@OrderDate
           ,@ShipperID)


";//SELECT @@IDENTITY
            command.Parameters.Add(new SqlParameter("CustomerID", customerID));
            command.Parameters.Add(new SqlParameter("EmployeeID", employeeID));
            command.Parameters.Add(new SqlParameter("OrderDate", orderDate));
            command.Parameters.Add(new SqlParameter("ShipperID", shipperID));

            //SqlParameter param =  command.Parameters.Add("@Identity", SqlDbType.Int, 0, "OrderID");
            //param.Direction = ParameterDirection.Output;


            command.Connection = Connection;
            command.ExecuteNonQuery();


            SqlCommand command2 = new SqlCommand();
            command2.CommandText = @"SELECT @@IDENTITY";

            //command2.Parameters.Add(new SqlParameter("SEARCH", condition));
            command2.Connection = Connection;

            DataTable table = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter(command2);

            da.Fill(table);



            Connection.Close();


            return int.Parse(table.Rows[0][0].ToString());//-1;
        }
        public static void AddOrderDetail(int orderID,int productID,int quantity)
        {

            Connection.Open();

        SqlCommand command = new SqlCommand();
        command.CommandText = @"
INSERT INTO[dbo].[OrderDetails]
           ([OrderID]
           ,[ProductID]
           ,[Quantity])
     VALUES
           (@OrderID
           ,@ProductID
           ,@Quantity
)";
            command.Parameters.Add(new SqlParameter("OrderID", orderID));
            command.Parameters.Add(new SqlParameter("ProductID", productID));
            command.Parameters.Add(new SqlParameter("Quantity", quantity));

            command.Connection = Connection;
            command.ExecuteNonQuery();
            Connection.Close();
    }

        public static void DeleteOrder(int orderID)
        {

             Connection.Open();

            SqlCommand command2 = new SqlCommand();
            command2.CommandText = @"DELETE FROM[dbo].[OrderDetails]
                                    WHERE ORDERID = @OrderID";
            command2.Parameters.Add(new SqlParameter("OrderID", orderID));
            command2.Connection = Connection;
            command2.ExecuteNonQuery();


            SqlCommand command = new SqlCommand();
            command.CommandText = @"DELETE FROM[dbo].[Orders]
                                    WHERE ORDERID = @OrderID";
            command.Parameters.Add(new SqlParameter("OrderID", orderID));
            command.Connection = Connection;
            command.ExecuteNonQuery();
            Connection.Close();

        }
        public static void DeleteOrderDetail(int orderDetailID)
        {

            Connection.Open();

            SqlCommand command = new SqlCommand();
            command.CommandText = @"DELETE FROM [dbo].[OrderDetails]
                                    WHERE OrderDetailID = @OrderDetailID
";
            command.Parameters.Add(new SqlParameter("OrderDetailID", orderDetailID));

            command.Connection = Connection;
            command.ExecuteNonQuery();
            Connection.Close();
        }

        public static void UpdateOrder(int orderID, int customerID, int employeeID, DateTime orderDate, int shipperID)
        {
            Connection.Open();

            SqlCommand command = new SqlCommand();
            command.CommandText = @"UPDATE [dbo].[Orders]
                                    SET [CustomerID] = @customerID
                                       ,[EmployeeID] = @employeeID
                                       ,[OrderDate] = @orderDate
                                       ,[ShipperID] = @shipperID
                                                    WHERE OrderID = @orderID

";
            command.Parameters.Add(new SqlParameter("orderID", orderID));
            command.Parameters.Add(new SqlParameter("customerID", customerID));
            command.Parameters.Add(new SqlParameter("employeeID", employeeID));
            command.Parameters.Add(new SqlParameter("orderDate", orderDate));
            command.Parameters.Add(new SqlParameter("shipperID", shipperID));

            command.Connection = Connection;
            command.ExecuteNonQuery();
            Connection.Close();
        }
        public static void UpdateOrderDetail(int orderDetailID,int orderID,int productID,int quantity)
        {

            Connection.Open();

            SqlCommand command = new SqlCommand();
            command.CommandText = @"UPDATE [dbo].[OrderDetails]
                                    SET [OrderID] = @orderID
                                       ,[ProductID] = @productID
                                       ,[Quantity] = @quantity
                             WHERE OrderDetailID = @orderDetailID

";
            command.Parameters.Add(new SqlParameter("orderDetailID", orderDetailID));
            command.Parameters.Add(new SqlParameter("orderID", orderID));
            command.Parameters.Add(new SqlParameter("productID", productID));
            command.Parameters.Add(new SqlParameter("quantity", quantity));

            command.Connection = Connection;
            command.ExecuteNonQuery();
            Connection.Close();




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
        public static void DeleteProduct(int productID)
        {
            Connection.Open();

            SqlCommand command = new SqlCommand();
            command.CommandText = @"DELETE FROM [dbo].[Products]
                                           WHERE ProductID = @ProductID";
            command.Parameters.Add(new SqlParameter("ProductID", productID));
            command.Connection = Connection;

            command.ExecuteNonQuery();

            Connection.Close();
        }
        public static void UpdateProduct(int productID, string productName, int supplierID, int categoryID,string unit, float price)
        {
            Connection.Open();

            SqlCommand command = new SqlCommand();
            command.CommandText = @" UPDATE [dbo].[Products]
                                    SET [ProductName] = @ProductName
                                       ,[SupplierID] = @SupplierID
                                       ,[CategoryID] = @CategoryID
                                       ,[Unit] = @Unit
                                       ,[Price] = @Price
                                       WHERE ProductID = @ProductID

";
            command.Parameters.Add(new SqlParameter("ProductID", productID));
            command.Parameters.Add(new SqlParameter("ProductName", productName));
            command.Parameters.Add(new SqlParameter("SupplierID", supplierID));
            command.Parameters.Add(new SqlParameter("CategoryID", categoryID));
            command.Parameters.Add(new SqlParameter("Unit", unit));
            command.Parameters.Add(new SqlParameter("Price", price));
            command.Connection = Connection;

            command.ExecuteNonQuery();

            Connection.Close();
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
