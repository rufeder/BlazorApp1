namespace BlazorApp1
{
    public class Product
    {
        public int Id { get; set; }
        public int amount { get; set; } = 1;
        public string? productname { get; set; }
        public double price { get; set; }

        public double totalprice { get; set; }
    }
}
