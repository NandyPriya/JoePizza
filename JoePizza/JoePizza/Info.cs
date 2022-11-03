using JoePizza.Models;

namespace JoePizza
{
    public class Info
    {
        public List<PizzaDetails> pizzaDetails;
        public Info()
        {
            pizzaDetails = new List<PizzaDetails>();
        }
        public void InsertData()
        {
            pizzaDetails.Add(new PizzaDetails() { Id = 1, Name = "CornandCheesePizza", Price = 179, Rating = 4.5 });
            pizzaDetails.Add(new PizzaDetails() { Id = 2, Name = "PannerParathaPizza", Price = 209, Rating = 4.6 });
            pizzaDetails.Add(new PizzaDetails() { Id = 3, Name = "VeggieParadise", Price = 459, Rating = 4.8 });
            //pizzaDetails.Add(new PizzaDetails() { Id = 4, Name = "Pizza4", Price = 400, Rating = 4.4 });
            //pizzaDetails.Add(new PizzaDetails() { Id = 5, Name = "Pizza5", Price = 500, Rating = 4.4 });
        }
        public bool ans()
        {
            return true;
        }
    }
}
