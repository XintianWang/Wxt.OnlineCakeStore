using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wxt.OnlineCakeStore.Domain
{
    public interface IStoreRepository
    {
        IEnumerable<Category> Categories { get; }
        IEnumerable<Cake> Cakes { get; }
        IEnumerable<Stock> Stocks { get; }
        IEnumerable<Receipt> Receipts { get; }
    }
}
