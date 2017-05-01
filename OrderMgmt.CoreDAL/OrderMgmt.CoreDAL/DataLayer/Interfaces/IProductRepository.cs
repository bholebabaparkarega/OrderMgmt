using Order.CoreDAL.EntityLayer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Order.CoreDAL.DataLayer.Interfaces
{
    public interface IProductRepository
    {
        void SaveProduct(Product product);
        IEnumerable<Product> GetAllProducts();
        Product GetProductById(int productId);
        void DeleteProduct(int productId);
        void UpdateProduct(Product product);
    }
}
