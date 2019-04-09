using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wxt.OnlineCakeStore.Domain
{
    public interface IStoreRepository
    {
        IEnumerable<Cake> Cakes { get; }
        IEnumerable<StockItem> Stocks { get; }
    }
}
