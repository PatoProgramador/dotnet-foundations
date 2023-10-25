using netfoundations.classes.models;

namespace netfoundations.classes
{
    internal class ClassMain
    {
        public void ClassExample()
        {
            Drink drink = new Drink("Coca-cola", 1000);
            drink.toDrink(500);
            Console.WriteLine(drink.Name);
            Console.WriteLine(drink.Quantity);
            Console.WriteLine("--Inheritance--");
            Beer beer = new Beer(500);
            beer.toDrink(200);
            Console.WriteLine(beer.Name);
            Console.WriteLine(beer.Quantity);
        }
    }
}