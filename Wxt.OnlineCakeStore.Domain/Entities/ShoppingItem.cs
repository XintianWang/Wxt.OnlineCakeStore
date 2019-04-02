namespace Wxt.OnlineCakeStore.Domain
{
    public class ShoppingItem
    {
        public int CakeId { get; set; }
        public int CakeCurrentName { get; set; }
        public int ShoppingNumber { get; set; }
        public decimal CakeCurrentPrice { get; set; }
        public decimal PriceSum { get => ShoppingNumber * CakeCurrentPrice; }
    }
}