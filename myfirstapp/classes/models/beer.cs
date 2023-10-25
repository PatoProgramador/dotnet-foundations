namespace netfoundations.classes.models
{
    class Beer : Drink
    {
        // Example of herency with default parameters in base constructor
        // public Beer() : base("Cerveza", 500)
        // {
        // }
        public Beer(int Quantity, string Name="Cerveza")
            : base( Name, Quantity )
        {
        }
    }
}