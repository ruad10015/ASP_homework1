namespace homework1.Entities
{
    public class Drink
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public Drink()
        {

        }

        public Drink(int id, string name, string description, double price)
        {
            Id = id;
            this.Name = name;
            this.Description = description;
            this.Price = price;
        }

    }
}
