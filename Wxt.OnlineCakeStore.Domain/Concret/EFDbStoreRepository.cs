using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wxt.OnlineCakeStore.Domain.Concret
{
    public class EFDbStoreRepository : IStoreRepository
    {
        private EFDbContext ctx = new EFDbContext();

        public IEnumerable<Category> Categories => ctx.Categories;

        public IEnumerable<Cake> Cakes => ctx.Cakes;

        public IEnumerable<Stock> Stocks => ctx.Stocks;

        public IEnumerable<Receipt> Receipts => ctx.Receipts;
    }
}
