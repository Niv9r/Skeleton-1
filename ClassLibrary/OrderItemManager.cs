using System;
using System.Data;
using System.Data.SqlClient;

namespace ClassLibrary
{
    public class OrderItemManager
    {
        private readonly string _connectionString;

        public OrderItemManager(string connectionString)
        {
            _connectionString = connectionString;
        }

        public DataTable GetAllOrderItems()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM OrderItem", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable orderItemTable = new DataTable();
                adapter.Fill(orderItemTable);
                return orderItemTable;
            }
        }

        public void AddOrderItem(int orderID, int productID, int quantity, decimal unitPrice, decimal totalPrice)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO OrderItem (OrderID, ProductID, Quantity, UnitPrice, TotalPrice) " +
                    "VALUES (@OrderID, @ProductID, @Quantity, @UnitPrice, @TotalPrice)",
                    conn);
                cmd.Parameters.AddWithValue("@OrderID", orderID);
                cmd.Parameters.AddWithValue("@ProductID", productID);
                cmd.Parameters.AddWithValue("@Quantity", quantity);
                cmd.Parameters.AddWithValue("@UnitPrice", unitPrice);
                cmd.Parameters.AddWithValue("@TotalPrice", totalPrice);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateOrderItem(int orderItemID, int orderID, int productID, int quantity, decimal unitPrice, decimal totalPrice)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand(
                    "UPDATE OrderItem SET OrderID=@OrderID, ProductID=@ProductID, Quantity=@Quantity, " +
                    "UnitPrice=@UnitPrice, TotalPrice=@TotalPrice WHERE OrderItemID=@OrderItemID",
                    conn);
                cmd.Parameters.AddWithValue("@OrderItemID", orderItemID);
                cmd.Parameters.AddWithValue("@OrderID", orderID);
                cmd.Parameters.AddWithValue("@ProductID", productID);
                cmd.Parameters.AddWithValue("@Quantity", quantity);
                cmd.Parameters.AddWithValue("@UnitPrice", unitPrice);
                cmd.Parameters.AddWithValue("@TotalPrice", totalPrice);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteOrderItem(int orderItemID)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM OrderItem WHERE OrderItemID=@OrderItemID", conn);
                cmd.Parameters.AddWithValue("@OrderItemID", orderItemID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public OrderItem GetOrderItemByID(int orderItemID)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM OrderItem WHERE OrderItemID=@OrderItemID", conn);
                cmd.Parameters.AddWithValue("@OrderItemID", orderItemID);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new OrderItem
                    {
                        OrderItemID = (int)reader["OrderItemID"],
                        OrderID = (int)reader["OrderID"],
                        ProductID = (int)reader["ProductID"],
                        Quantity = (int)reader["Quantity"],
                        UnitPrice = (decimal)reader["UnitPrice"],
                        TotalPrice = (decimal)reader["TotalPrice"]
                    };
                }

                return null;
            }
        }

        public class OrderItem
        {
            public int OrderItemID { get; set; }
            public int OrderID { get; set; }
            public int ProductID { get; set; }
            public int Quantity { get; set; }
            public decimal UnitPrice { get; set; }
            public decimal TotalPrice { get; set; }
        }
    }
}
