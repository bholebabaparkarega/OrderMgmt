using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Order.CoreDAL.DataLayer.Repositories;
using Order.CoreDAL.DataLayer.Interfaces;
using OrderMgmt.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OrderMgmt.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private IProductRepository productRepository;
        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<ProductViewModel> Get()
        {
            
            return productRepository.GetAllProducts().Select(s=> new ProductViewModel
            {
                ProductId = s.ProductId,
                ProductCode = s.ProductCode,
                ProductName = s.ProductName,
                UnitPrice = s.UnitPrice
            }).AsEnumerable();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
