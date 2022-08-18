using System;
using System.Data;
using System.Data.SqlClient;

namespace ADWApp.DAL
{
    public class ProductDAL
    {
        private DbConnection dbConnection;

        public ProductDAL()
        {
            dbConnection = new DbConnection();

        }
        public DataTable GetAllItems()
        {
            SqlCommand cmd = dbConnection.GetSqlCommand();
            cmd.CommandText = "Select * From dbo.DimProduct";
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            return dt;

        }
        public void AddNewItem(int productId, string Name, string productNumber, decimal weight)
        {
            string cmdText =
                "INSERT INTO [Production].[Product] ([Name],[ProductNumber],[Weight])";
            cmdText += String.Format("Values('{0}',{1},{2}')",Name,productNumber,weight);
            SqlCommand cmd = dbConnection.GetSqlCommand();
            cmd.CommandText = cmdText;

            cmd.ExecuteNonQuery();
        }
        public void DeleteItemById(int productId)
        {
            SqlCommand cmd = dbConnection.GetSqlCommand();
            cmd.CommandText = String.Format("Delete from Production.Product Where ProductId = {0}", productId);
            cmd.ExecuteNonQuery();

        }
        public void UpdateItem(int productId, string Name, string productNumber, decimal weight)
        {
            

        }
    }
}
