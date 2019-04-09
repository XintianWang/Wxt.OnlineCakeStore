namespace Wxt.OnlineCakeStore.Domain
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class ShoppingCart
    {
        [Key]
        public int CustomerId { get; set; }
        public List<StockItem> Items { get; set; } = new List<StockItem>();
    }
}
