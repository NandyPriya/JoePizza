namespace JoePizza.Models
{
    public class Order
    {
        public int ProdId { get; set; }
        public string ProdName { get; set; }

        public int Quantity { get; set; }

        public double Total { get; set; }

    }
}
