namespace Wxt.OnlineCakeStore.Domain
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class ShoppingCart
    {
        [Key]
        public int CustomerId { get; set; }
        public List<Stock> Items { get; set; } = new List<Stock>();
    }
}
