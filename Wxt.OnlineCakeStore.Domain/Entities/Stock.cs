namespace Wxt.OnlineCakeStore.Domain
{
    using System.ComponentModel.DataAnnotations;

    public class Stock
    {
        [Key]
        public int CakeId { get; set; }
        public int StockNumber { get; set; }
    }
}
