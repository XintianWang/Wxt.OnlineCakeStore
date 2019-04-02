using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wxt.OnlineCakeStore.Domain
{
    public class ShoppingCart
    {
        public int CustomerId { get; set; }
        public List<StockItem> Items { get; set; } = new List<StockItem>();
    }
}
