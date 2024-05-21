using System;
using System.Data;
using System.Data.SqlClient;

namespace ClassLibrary
{
    public class OrderManager
    {
        private readonly string _connectionString;

        public OrderManager(string connectionString)
        {
            _connectionString = connectionString;
        }

        public DataTable GetAllOrders()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM [Order]", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable orderTable = new DataTable();
                adapter.Fill(orderTable);
                return orderTable;
            }
        }

        public void AddOrder(int customerID, DateTime orderDate, string status, decimal totalAmount, bool orderStatus)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO [Order] (CustomerID, OrderDate, Status, TotalAmount, OrderStatus) " +
                    "VALUES (@CustomerID, @OrderDate, @Status, @TotalAmount, @OrderStatus)",
                    conn);
                cmd.Parameters.AddWithValue("@CustomerID", customerID);
                cmd.Parameters.AddWithValue("@OrderDate", orderDate);
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.Parameters.AddWithValue("@TotalAmount", totalAmount);
                cmd.Parameters.AddWithValue("@OrderStatus", orderStatus);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateOrder(int orderID, int customerID, DateTime orderDate, string status, decimal totalAmount, bool orderStatus)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand(
                    "UPDATE [Order] SET CustomerID=@CustomerID, OrderDate=@OrderDate, Status=@Status, " +
                    "TotalAmount=@TotalAmount, OrderStatus=@OrderStatus WHERE OrderID=@OrderID",
                    conn);
                cmd.Parameters.AddWithValue("@OrderID", orderID);
                cmd.Parameters.AddWithValue("@CustomerID", customerID);
                cmd.Parameters.AddWithValue("@OrderDate", orderDate);
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.Parameters.AddWithValue("@TotalAmount", totalAmount);
                cmd.Parameters.AddWithValue("@OrderStatus", orderStatus);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteOrder(int orderID)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM [Order] WHERE OrderID=@OrderID", conn);
                cmd.Parameters.AddWithValue("@OrderID", orderID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public Order GetOrderByID(int orderID)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM [Order] WHERE OrderID=@OrderID", conn);
                cmd.Parameters.AddWithValue("@OrderID", orderID);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new Order
                    {
                        OrderID = (int)reader["OrderID"],
                        CustomerID = (int)reader["CustomerID"],
                        OrderDate = (DateTime)reader["OrderDate"],
                        Status = (string)reader["Status"],
                        TotalAmount = (decimal)reader["TotalAmount"],
                        OrderStatus = (bool)reader["OrderStatus"]
                    };
                }

                return null;
            }
        }

        public class Order
        {
            public int OrderID { get; set; }
            public int CustomerID { get; set; }
            public DateTime OrderDate { get; set; }
            public string Status { get; set; }
            public decimal TotalAmount { get; set; }
            public bool OrderStatus { get; set; }
        }
    }
}
