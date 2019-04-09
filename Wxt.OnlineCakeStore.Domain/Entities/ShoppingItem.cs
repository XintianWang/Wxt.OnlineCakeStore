namespace Wxt.OnlineCakeStore.Domain
{
    using System.ComponentModel.DataAnnotations;

    public class ShoppingItem
    {
        [Key]
        public int CakeId { get; set; }
        public int CakeCurrentName { get; set; }
        public int ShoppingNumber { get; set; }
        public decimal CakeCurrentPrice { get; set; }
        public decimal PriceSum { get => ShoppingNumber * CakeCurrentPrice; }
    }
}