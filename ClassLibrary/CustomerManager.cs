using System;
using System.Data;
using System.Data.SqlClient;

namespace ClassLibrary
{
    public class CustomerManager
    {
        private readonly string _connectionString;

        public CustomerManager(string connectionString)
        {
            _connectionString = connectionString;
        }

        public DataTable GetAllCustomers()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Customer", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable customerTable = new DataTable();
                adapter.Fill(customerTable);
                return customerTable;
            }
        }

        public void AddCustomer(string firstName, string lastName, string email, string phone, string countryCode, string address, bool isActive, string passwordHash)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Customer (FirstName, LastName, Email, Phone, CountryCode, Address, IsActive, PasswordHash) " +
                    "VALUES (@FirstName, @LastName, @Email, @Phone, @CountryCode, @Address, @IsActive, @PasswordHash)",
                    conn);
                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@CountryCode", countryCode);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@IsActive", isActive);
                cmd.Parameters.AddWithValue("@PasswordHash", passwordHash);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateCustomer(int customerID, string firstName, string lastName, string email, string phone, string countryCode, string address, bool isActive)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Customer SET FirstName=@FirstName, LastName=@LastName, Email=@Email, Phone=@Phone, " +
                    "CountryCode=@CountryCode, Address=@Address, IsActive=@IsActive WHERE CustomerID=@CustomerID",
                    conn);
                cmd.Parameters.AddWithValue("@CustomerID", customerID);
                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@CountryCode", countryCode);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@IsActive", isActive);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteCustomer(int customerID)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Customer WHERE CustomerID=@CustomerID", conn);
                cmd.Parameters.AddWithValue("@CustomerID", customerID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public Customer GetCustomerByID(int customerID)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Customer WHERE CustomerID=@CustomerID", conn);
                cmd.Parameters.AddWithValue("@CustomerID", customerID);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new Customer
                    {
                        CustomerID = (int)reader["CustomerID"],
                        FirstName = (string)reader["FirstName"],
                        LastName = (string)reader["LastName"],
                        Email = (string)reader["Email"],
                        Phone = (string)reader["Phone"],
                        CountryCode = (string)reader["CountryCode"],
                        Address = (string)reader["Address"],
                        IsActive = (bool)reader["IsActive"]
                    };
                }

                return null;
            }
        }

        public class Customer
        {
            public int CustomerID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public string CountryCode { get; set; }
            public string Address { get; set; }
            public bool IsActive { get; set; }
        }
    }
}
