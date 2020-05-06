using E_Com_Database;
using E_Com_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Com_Services
{
    public class CategoryService
    {

        DbContextData db = new DbContextData();

        public Category GetCategoryById(int Id)
        {
            var cat = db.categories.Find(Id);
            return cat;
        }


        public void SaveCategory(Category category)
        {

            db.categories.Add(category);
            db.SaveChanges();
        }

        public IList<Category> GetCategory()
        {
            var cat = db.categories.ToList();
            return cat;
        }

        public void UpdateCategory(Category category)
        {
            db.Entry(category).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public void DeleteCategory(Category category)
        {
            db.categories.Remove(category);
            db.SaveChanges();
        }
    }
}

