using System;

namespace Duck_Simulation_game_Inventory
{
    class RedheadDuck : Duck, Program.IDuck
    {
        public override DuckType Type => DuckType.RedheadDuck;
        public RedheadDuck(string name, int number_of_wings, double weight)
        {
            Name = name;
            NumberOfWings = number_of_wings;
            Weight = weight;
        }
        public string Fly()
        {
            return "Fly slow";
        }
        public string Quack()
        {
            return "Quack mild";
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
