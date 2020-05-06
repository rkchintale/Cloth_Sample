using E_Com_Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Com_Database
{
    public  class DbContextData:DbContext,IDisposable
    {
        public DbContextData() : base("E-Com")
        {

        }


        public DbSet<Product> products { get; set; }
        public DbSet<Category> categories { get; set; }
    }
}
