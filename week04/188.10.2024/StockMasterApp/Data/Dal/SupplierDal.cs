using Microsoft.Data.SqlClient;
using StockMasterApp.Models.SupplierModels;
using System;
using System.Collections.Generic;

namespace StockMasterApp.Data.Dal
{
    internal class SupplierDal
    {
        public bool Create(AddSupplierModel model)
        {
            string query = @"
                INSERT INTO Suppliers(Name, ContactName, Address, Phone)
                VALUES (@p1, @p2, @p3, @p4)
            ";
            Db.Open();
            SqlCommand sqlCommand = new SqlCommand(query, Db.Connection);

            sqlCommand.Parameters.AddWithValue("@p1", model.Name);
            sqlCommand.Parameters.AddWithValue("@p2", model.ContactName);
            sqlCommand.Parameters.AddWithValue("@p3", model.Address);
            sqlCommand.Parameters.AddWithValue("@p4", model.Phone);

            var rowsAffected = sqlCommand.ExecuteNonQuery();
            Db.Close();
            return rowsAffected > 0;
        }

        public bool Update(UpdateSupplierModel model)
        {
            string query = @"
                UPDATE Suppliers SET
                    Name = @p1,
                    ContactName = @p2,
                    Address = @p3,
                    Phone = @p4
                WHERE Id = @p5
            ";
            Db.Open();
            SqlCommand sqlCommand = new SqlCommand(query, Db.Connection);

            sqlCommand.Parameters.AddWithValue("@p1", model.Name);
            sqlCommand.Parameters.AddWithValue("@p2", model.ContactName);
            sqlCommand.Parameters.AddWithValue("@p3", model.Address);
            sqlCommand.Parameters.AddWithValue("@p4", model.Phone);
            sqlCommand.Parameters.AddWithValue("@p5", model.Id);

            var rowsAffected = sqlCommand.ExecuteNonQuery();
            Db.Close();
            return rowsAffected > 0;
        }

        public bool Delete(int id)
        {
            string query = $"DELETE FROM Suppliers WHERE Id=@p1";
            Db.Open();
            SqlCommand sqlCommand = new SqlCommand(query, Db.Connection);
            sqlCommand.Parameters.AddWithValue("@p1", id);
            var rowsAffected = sqlCommand.ExecuteNonQuery();
            Db.Close();
            return rowsAffected > 0;
        }

        public SupplierModel GetById(int Id)
        {
            string query = $"SELECT * FROM Suppliers WHERE Id=@p1";
            Db.Open();
            SqlCommand sqlCommand = new SqlCommand(query, Db.Connection);
            sqlCommand.Parameters.AddWithValue("@p1", Id);

            SqlDataReader reader = sqlCommand.ExecuteReader();
            reader.Read();
            SupplierModel supplierModel = new SupplierModel
            {
                Id = (int)reader["Id"],
                Name = (string)reader["Name"],
                ContactName = (string)reader["ContactName"],
                Address = (string)reader["Address"],
                Phone = (string)reader["Phone"],
            };
            Db.Close();
            return supplierModel;
        }

        public List<SupplierModel> GetAll()
        {
            string query = "SELECT * FROM Suppliers";
            Db.Open();
            SqlCommand sqlCommand = new SqlCommand(query, Db.Connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();

            List<SupplierModel> supplierList = new List<SupplierModel>();
            while (reader.Read())
            {
                SupplierModel supplierModel = new SupplierModel
                {
                    Id = (int)reader["Id"],
                    Name = (string)reader["Name"],
                    ContactName = (string)reader["ContactName"],
                    Address = (string)reader["Address"],
                    Phone = (string)reader["Phone"],
                };
                supplierList.Add(supplierModel);
            }
            Db.Close();
            return supplierList;
        }
    }
}
