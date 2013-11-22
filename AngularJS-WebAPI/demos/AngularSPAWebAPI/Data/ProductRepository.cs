using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Data
{
    public class ProductRepository : IProductRepository
    {
        protected static int currentId = 1;
        protected static Dictionary<int, Product> products = new Dictionary<int, Product>();

        public ProductRepository()
        {
            if (products.Count == 0)
            {
                products.Add(++currentId, new Product { Id = 1, Name = "Product 1", Description = "This is Product 1" });
                products.Add(++currentId, new Product { Id = 2, Name = "Product 2", Description = "This is Product 2" });
                products.Add(++currentId, new Product { Id = 3, Name = "Product 3", Description = "This is Product 3" });
            }
        }

        public IEnumerable<Models.Product> GetAll()
        {
            return products.Values;
        }

        public Models.Product GetById(int id)
        {
            if (products.ContainsKey(id))
            {
                return products[id];
            }
            return null;
        }

        public int Create(Models.Product product)
        {
            int id = ++currentId;
            products.Add(id, product);
            return id;
        }

        public void Save(Models.Product product)
        {
            if (products.ContainsKey(product.Id))
            {
                products[product.Id] = product;
            }
        }

        public void Delete(int id)
        {
            if (products.ContainsKey(id))
            {
                products.Remove(id);
            }
        }
    }
}
