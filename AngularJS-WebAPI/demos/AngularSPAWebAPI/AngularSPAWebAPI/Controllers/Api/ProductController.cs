using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Data;
using Models;

namespace AngularSPAWebAPI.Controllers.Api
{
    public class ProductController : BaseApiController
    {
        protected IProductRepository productRepository;

        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        // GET api/product
        public IEnumerable<Product> Get()
        {
            return productRepository.GetAll();
        }

        // GET api/product/5
        public Product Get(int id)
        {
            return productRepository.GetById(id);
        }

        // POST api/product
        public Product Post([FromBody]Product product)
        {
            int id = productRepository.Create(product);
            return productRepository.GetById(id);
        }

        // PUT api/product/5
        public Product Put(int id, [FromBody]Product product)
        {
            productRepository.Save(product);
            return productRepository.GetById(id);
        }

        // DELETE api/product/5
        public void Delete(int id)
        {
            productRepository.Delete(id);
        }
    }
}
