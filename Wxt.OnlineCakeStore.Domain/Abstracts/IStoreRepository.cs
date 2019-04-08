using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wxt.OnlineCakeStore.Domain
{
    public interface IStoreRepository
    {
        List<Cake> Cakes { get; }
        List<StockItem> Stocks { get; }
    }
}
