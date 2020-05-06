using E_Com_Database;
using E_Com_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Com_Services
{
    public class ProductService
    {
        DbContextData db = new DbContextData();

        public Product GetProductById(int Id)
        {
            var cat = db.products.Find(Id);
            return cat;
        }


        public void SaveProduct(Product product)
        {

            db.products.Add(product);
            db.SaveChanges();
        }

        public IList<Product> GetProduct()
        {
            var cat = db.products.ToList();
            return cat;
        }

        public void UpdateProduct(Product product)
        {
            db.Entry(product).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public void DeleteCategory(Product product)
        {
            db.products.Remove(product);
            db.SaveChanges();
        }
    }
}
