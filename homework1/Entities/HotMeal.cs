namespace homework1.Entities
{
    public class HotMeal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public HotMeal()
        {

        }

        public HotMeal(int id, string name, string description, double price)
        {
            Id = id;
            this.Name = name;
            this.Description = description;
            this.Price = price;
        }
    }
}
