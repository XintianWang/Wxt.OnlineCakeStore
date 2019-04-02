namespace Wxt.OnlineCakeStore.Domain
{
    public class Cake
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public string PictureURL { get; set; }

        public string Dimension { get; set; }

        public int CategoryId { get; set; }
    }
}
