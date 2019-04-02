namespace Wxt.OnlineCakeStore.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Receipt
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public DateTimeOffset TransactionTime { get; set; }

        public List<ShoppingItem> ShoppingItems { get; set; } = new List<ShoppingItem>();

        public decimal TotalPrice { get => ShoppingItems.Sum(i => i.PriceSum); }
    }
}
