using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wxt.OnlineCakeStore.Domain.Concret
{
    public class EFDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Cake> Cakes { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Receipt> Receipts { get; set; }
    }
}
