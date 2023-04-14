using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Models;

namespace WpfApp1.Contexts
{
    class ProductContext : DbContext
    {
        public ProductContext()
          : base("DbConnection") { }

        public DbSet<Product> Products { get; set; }
    }
}
