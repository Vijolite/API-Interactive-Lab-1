namespace API_Interactive_Lab_1.Models
{
    public class CoffeeList
    {
        public List  <Coffee> Menu { get; set; }
        public CoffeeList()
        {
            Menu = new List<Coffee>();
            Menu.Add(new Coffee(1, "Black Coffee"));
            Menu.Add(new Coffee(2, "White Coffee"));
            Menu.Add(new Coffee(3, "Capuccino"));
        }
        public Coffee GetCoffee (string? name)
        {
            return name==null ? (new Coffee(-1, "Latte")) : Menu.Where(coffee => coffee.Name == name).First();
        }

    }
}
