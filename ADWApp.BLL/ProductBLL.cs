using System.Data;
using System;
using ADWApp.DAL;

namespace ADWApp.ProductBLL
{
    public class ProductBLL
    {
        private ProductDAL productDal;
        public ProductBLL()
        {
            productDal = new ProductDAL();
        }
            

        public DataTable GetAllItems()
        {
            return productDal.GetAllItems();
            
        }
        public void AddNewItem(int productId, string Name, string productNumber, decimal weight)
        {
            productDal.AddNewItem(productId, Name, productNumber, weight);
        }
        public void DeleteItemById(int productId)
        {
            productDal.DeleteItemById(productId);

        }
        public void UpdateItem(int productId, string Name, string productNumber, decimal weight)
        {

        }
    }
}
