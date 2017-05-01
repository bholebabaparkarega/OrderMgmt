using Order.CoreDAL.DataLayer.DatabaseContext;
using Order.CoreDAL.DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Order.CoreDAL.EntityLayer;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq;

namespace Order.CoreDAL.DataLayer.Repositories
{
    public class ProductRepository:IProductRepository
    {
        private OrderDbContext dbContext;
        private DbSet<Product> productEntity;
        public ProductRepository(OrderDbContext dbContext)
        {
            this.dbContext = dbContext;
            productEntity= dbContext.Set<Product>();
        }

        public void DeleteProduct(int productId)
        {
            var prod = GetProductById(productId);
            productEntity.Remove(prod);
            dbContext.SaveChangesAsync();
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return productEntity.AsEnumerable();
        }

        public Product GetProductById(int productId)
        {
            return productEntity.SingleOrDefault(m => m.ProductId == productId);
        }

        public void SaveProduct(Product product)
        {
           dbContext.Entry(product).State = EntityState.Added;
           dbContext.SaveChangesAsync();
        }

        public void UpdateProduct(Product product)
        {
            dbContext.SaveChangesAsync();
        }
    }
}
