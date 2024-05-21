using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

public class ProductManager
{
    private string _connectionString;

    public ProductManager(string connectionString)
    {
        _connectionString = connectionString;
    }

    public int AddProduct(Product product)
    {
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            const string query = "INSERT INTO Products (ProductName, Category, Price, StockQuantity, Brand) OUTPUT INSERTED.ProductID VALUES (@ProductName, @Category, @Price, @StockQuantity, @Brand)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ProductName", product.ProductName);
            command.Parameters.AddWithValue("@Category", product.Category);
            command.Parameters.AddWithValue("@Price", product.Price);
            command.Parameters.AddWithValue("@StockQuantity", product.StockQuantity);
            command.Parameters.AddWithValue("@Brand", product.Brand);

            connection.Open();
            int productId = (int)command.ExecuteScalar();
            return productId;
        }
    }

    public Product GetProductById(int productId)
    {
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            const string query = "SELECT * FROM Products WHERE ProductID = @ProductID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ProductID", productId);

            connection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    return new Product
                    {
                        ProductID = (int)reader["ProductID"],
                        ProductName = (string)reader["ProductName"],
                        Category = (string)reader["Category"],
                        Price = (decimal)reader["Price"],
                        StockQuantity = (int)reader["StockQuantity"],
                        Brand = (string)reader["Brand"]
                    };
                }
            }
        }

        return null;
    }

    public bool UpdateProduct(Product product)
    {
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            const string query = "UPDATE Products SET ProductName = @ProductName, Category = @Category, Price = @Price, StockQuantity = @StockQuantity, Brand = @Brand WHERE ProductID = @ProductID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ProductID", product.ProductID);
            command.Parameters.AddWithValue("@ProductName", product.ProductName);
            command.Parameters.AddWithValue("@Category", product.Category);
            command.Parameters.AddWithValue("@Price", product.Price);
            command.Parameters.AddWithValue("@StockQuantity", product.StockQuantity);
            command.Parameters.AddWithValue("@Brand", product.Brand);

            connection.Open();
            int result = command.ExecuteNonQuery();
            return result > 0;
        }
    }

    public bool DeleteProduct(int productId)
    {
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            const string query = "DELETE FROM Products WHERE ProductID = @ProductID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ProductID", productId);

            connection.Open();
            int result = command.ExecuteNonQuery();
            return result > 0;
        }
    }
}
