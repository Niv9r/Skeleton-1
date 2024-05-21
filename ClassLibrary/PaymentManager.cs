using System;
using System.Data;
using System.Data.SqlClient;

namespace ClassLibrary
{
    public class PaymentManager
    {
        private readonly string _connectionString;

        public PaymentManager(string connectionString)
        {
            _connectionString = connectionString;
        }

        public DataTable GetAllPayments()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Payment", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable paymentTable = new DataTable();
                adapter.Fill(paymentTable);
                return paymentTable;
            }
        }

        public void AddPayment(int orderID, DateTime paymentDate, string paymentMethod, decimal amount, string status)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Payment (OrderID, PaymentDate, PaymentMethod, Amount, Status) " +
                    "VALUES (@OrderID, @PaymentDate, @PaymentMethod, @Amount, @Status)",
                    conn);
                cmd.Parameters.AddWithValue("@OrderID", orderID);
                cmd.Parameters.AddWithValue("@PaymentDate", paymentDate);
                cmd.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
                cmd.Parameters.AddWithValue("@Amount", amount);
                cmd.Parameters.AddWithValue("@Status", status);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdatePayment(int paymentID, int orderID, DateTime paymentDate, string paymentMethod, decimal amount, string status)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Payment SET OrderID=@OrderID, PaymentDate=@PaymentDate, PaymentMethod=@PaymentMethod, " +
                    "Amount=@Amount, Status=@Status WHERE PaymentID=@PaymentID",
                    conn);
                cmd.Parameters.AddWithValue("@PaymentID", paymentID);
                cmd.Parameters.AddWithValue("@OrderID", orderID);
                cmd.Parameters.AddWithValue("@PaymentDate", paymentDate);
                cmd.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
                cmd.Parameters.AddWithValue("@Amount", amount);
                cmd.Parameters.AddWithValue("@Status", status);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeletePayment(int paymentID)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Payment WHERE PaymentID=@PaymentID", conn);
                cmd.Parameters.AddWithValue("@PaymentID", paymentID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public Payment GetPaymentByID(int paymentID)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Payment WHERE PaymentID=@PaymentID", conn);
                cmd.Parameters.AddWithValue("@PaymentID", paymentID);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new Payment
                    {
                        PaymentID = (int)reader["PaymentID"],
                        OrderID = (int)reader["OrderID"],
                        PaymentDate = (DateTime)reader["PaymentDate"],
                        PaymentMethod = (string)reader["PaymentMethod"],
                        Amount = (decimal)reader["Amount"],
                        Status = (string)reader["Status"]
                    };
                }

                return null;
            }
        }

        public class Payment
        {
            public int PaymentID { get; set; }
            public int OrderID { get; set; }
            public DateTime PaymentDate { get; set; }
            public string PaymentMethod { get; set; }
            public decimal Amount { get; set; }
            public string Status { get; set; }
        }
    }
}
