using System;
using System.Data;
using System.Data.SqlClient;

namespace ClassLibrary
{
    public class StaffManager
    {
        private readonly string _connectionString;

        public StaffManager(string connectionString)
        {
            _connectionString = connectionString;
        }

        public DataTable GetAllStaff()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Staff", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable staffTable = new DataTable();
                adapter.Fill(staffTable);
                return staffTable;
            }
        }

        public void AddStaff(string firstName, string lastName, string email, string phone, string countryCode, string role, DateTime hireDate, bool isActive, string passwordHash)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Staff (FirstName, LastName, Email, Phone, CountryCode, Role, HireDate, IsActive, PasswordHash) " +
                    "VALUES (@FirstName, @LastName, @Email, @Phone, @CountryCode, @Role, @HireDate, @IsActive, @PasswordHash)",
                    conn);
                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@CountryCode", countryCode);
                cmd.Parameters.AddWithValue("@Role", role);
                cmd.Parameters.AddWithValue("@HireDate", hireDate);
                cmd.Parameters.AddWithValue("@IsActive", isActive);
                cmd.Parameters.AddWithValue("@PasswordHash", passwordHash);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateStaff(int staffID, string firstName, string lastName, string email, string phone, string countryCode, string role, DateTime hireDate, bool isActive)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Staff SET FirstName=@FirstName, LastName=@LastName, Email=@Email, Phone=@Phone, " +
                    "CountryCode=@CountryCode, Role=@Role, HireDate=@HireDate, IsActive=@IsActive WHERE StaffID=@StaffID",
                    conn);
                cmd.Parameters.AddWithValue("@StaffID", staffID);
                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@CountryCode", countryCode);
                cmd.Parameters.AddWithValue("@Role", role);
                cmd.Parameters.AddWithValue("@HireDate", hireDate);
                cmd.Parameters.AddWithValue("@IsActive", isActive);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteStaff(int staffID)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Staff WHERE StaffID=@StaffID", conn);
                cmd.Parameters.AddWithValue("@StaffID", staffID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public Staff GetStaffByID(int staffID)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Staff WHERE StaffID=@StaffID", conn);
                cmd.Parameters.AddWithValue("@StaffID", staffID);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new Staff
                    {
                        StaffID = (int)reader["StaffID"],
                        FirstName = (string)reader["FirstName"],
                        LastName = (string)reader["LastName"],
                        Email = (string)reader["Email"],
                        Phone = (string)reader["Phone"],
                        CountryCode = (string)reader["CountryCode"],
                        Role = (string)reader["Role"],
                        HireDate = (DateTime)reader["HireDate"],
                        IsActive = (bool)reader["IsActive"]
                    };
                }

                return null;
            }
        }

        public class Staff
        {
            public int StaffID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public string CountryCode { get; set; }
            public string Role { get; set; }
            public DateTime HireDate { get; set; }
            public bool IsActive { get; set; }
        }
    }
}
