using Microsoft.Data.SqlClient;
using StockMasterApp.Models.ProductModels;
using StockMasterApp.Models.SupplierModels;
using System;
using System.Collections.Generic;

namespace StockMasterApp.Data.Dal
{
    internal class ProductDal
    {
        public bool Create(AddProductModel model)
        {
            string query = @"
                INSERT INTO Products(Name, QuantityPerUnit, UnitPrice, UnitsInStock, Discounted, ReorderLevel, CategoryId, SupplierId)
                VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8)";

            Db.Open();
            using (SqlCommand sqlCommand = new SqlCommand(query, Db.Connection))
            {
                sqlCommand.Parameters.AddWithValue("@p1", model.Name);
                sqlCommand.Parameters.AddWithValue("@p2", model.QuantityPerUnit);
                sqlCommand.Parameters.AddWithValue("@p3", model.UnitPrice);
                sqlCommand.Parameters.AddWithValue("@p4", model.UnitsInStock);
                sqlCommand.Parameters.AddWithValue("@p5", model.Discounted);
                sqlCommand.Parameters.AddWithValue("@p6", model.ReorderLevel);
                sqlCommand.Parameters.AddWithValue("@p7", model.CategoryId);
                sqlCommand.Parameters.AddWithValue("@p8", model.SupplierId);

                var rowsAffected = sqlCommand.ExecuteNonQuery();
                Db.Close();
                return rowsAffected > 0;
            }
        }

        public bool Update(AddProductModel model)
        {
            string query = @"
                UPDATE Products SET
                Name = @p1,
                QuantityPerUnit = @p2,
                UnitPrice = @p3,
                UnitsInStock = @p4,
                Discounted = @p5,
                ReorderLevel = @p6,
                CategoryId = @p7,
                SupplierId = @p8
                WHERE Id = @p9"; // WHERE clause ekleyin

            Db.Open();
            using (SqlCommand sqlCommand = new SqlCommand(query, Db.Connection))
            {
                sqlCommand.Parameters.AddWithValue("@p1", model.Name);
                sqlCommand.Parameters.AddWithValue("@p2", model.QuantityPerUnit);
                sqlCommand.Parameters.AddWithValue("@p3", model.UnitPrice);
                sqlCommand.Parameters.AddWithValue("@p4", model.UnitsInStock);
                sqlCommand.Parameters.AddWithValue("@p5", model.Discounted);
                sqlCommand.Parameters.AddWithValue("@p6", model.ReorderLevel);
                sqlCommand.Parameters.AddWithValue("@p7", model.CategoryId);
                sqlCommand.Parameters.AddWithValue("@p8", model.SupplierId);
                sqlCommand.Parameters.AddWithValue("@p9", model.WhereId); // WhereId'nin tanımlı olduğundan emin olun

                var rowsAffected = sqlCommand.ExecuteNonQuery();
                Db.Close();
                return rowsAffected > 0;
            }
        }

        public bool Delete(int id)
        {
            string query = "DELETE FROM Products WHERE Id = @p1"; // Suppliers yerine Products kullanın
            Db.Open();
            using (SqlCommand sqlCommand = new SqlCommand(query, Db.Connection))
            {
                sqlCommand.Parameters.AddWithValue("@p1", id);
                var rowsAffected = sqlCommand.ExecuteNonQuery();
                Db.Close();
                return rowsAffected > 0;
            }
        }

        public ProductModel GetById(int id)
        {
            string query = "SELECT * FROM Products WHERE Id = @p1";
            Db.Open();
            using (SqlCommand sqlCommand = new SqlCommand(query, Db.Connection))
            {
                sqlCommand.Parameters.AddWithValue("@p1", id);
                SqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.Read())
                {
                    ProductModel productModel = new ProductModel
                    {
                        Id = (int)reader["Id"],
                        Name = (string)reader["Name"],
                        QuantityPerUnit = (string)reader["QuantityPerUnit"],
                        UnitPrice = (decimal)reader["UnitPrice"],
                        UnitsInStock = (int)reader["UnitsInStock"],
                        Discounted = (bool)reader["Discounted"],
                        ReOrderLevel = (int)reader["ReorderLevel"],
                        CategoryId = (int)reader["CategoryId"],
                        SupplierId = (int)reader["SupplierId"],
                    };
                    Db.Close();
                    return productModel;
                }
                Db.Close();
                return null; // Ürün bulunamadığında null döndür
            }
        }

        public List<ProductForGridModel> GetAll()
        {
            string query = "SELECT Id, Name, UnitPrice, CategoryId, SupplierId FROM Products";
            Db.Open();
            using (SqlCommand sqlCommand = new SqlCommand(query, Db.Connection))
            {
                SqlDataReader reader = sqlCommand.ExecuteReader();
                List<ProductForGridModel> productList = new List<ProductForGridModel>(); // Listeyi başlat
                while (reader.Read())
                {
                    ProductForGridModel productModel = new ProductForGridModel
                    {
                        Id = (int)reader["Id"],
                        Name = (string)reader["Name"],
                        UnitPrice = (decimal)reader["UnitPrice"],
                        CategoryId = (int)reader["CategoryId"],
                        SupplierId = (int)reader["SupplierId"],
                    };
                    productList.Add(productModel);
                }
                Db.Close();
                return productList;
            }
        }
    }
}
