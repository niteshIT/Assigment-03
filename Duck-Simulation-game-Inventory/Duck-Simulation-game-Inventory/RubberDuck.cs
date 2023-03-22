using System;

namespace Duck_Simulation_game_Inventory
{
    class RubberDuck : Duck, Program.IDuck
    {
        public override DuckType Type => DuckType.RubberDuck;
        public RubberDuck(string name, int number_of_wings, double weight)
        {
            Name = name;
            NumberOfWings = number_of_wings;
            Weight = weight;
        }
        public string Fly()
        {
            return "Don't fly";
        }
        public string Quack()
        {
            return "Squeak";
        }
        public override void ShowDetail()
        {
            Console.WriteLine("Type: " + Type);
            Console.WriteLine("Number of wings: " + NumberOfWings);
            Console.WriteLine("Weight: " + Weight);
            Console.WriteLine(Fly());
            Console.WriteLine(Quack());
        }
    }
}
