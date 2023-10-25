namespace netfoundations.classes.models
{
    class Drink
    {
        // to private only can access the same class, protected only devirated classes
        public string Name { get; set; }

        public int Quantity { get; set; }

        public void toDrink(int HowMuchDrink)
        {
            this.Quantity -= HowMuchDrink;
        }
        // constructor
        public Drink(string Name, int Quantity)
        {
            this.Name = Name;
            this.Quantity = Quantity;
        }
    }
}