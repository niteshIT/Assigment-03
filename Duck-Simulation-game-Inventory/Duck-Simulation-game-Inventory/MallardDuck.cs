using System;

namespace Duck_Simulation_game_Inventory
{
    class MallardDuck : Duck, Program.IDuck
    {
        public override DuckType Type => DuckType.MallardDuck;
        public MallardDuck(string name, int number_of_wings, double weight)
        {
            Name = name;
            NumberOfWings = number_of_wings;
            Weight = weight;
        }
        public string Fly()
        {
            return "Fly fast";
        }
        public string Quack()
        {
            return "Quack loud";
        }
        public override void ShowDetail()
        {
            Console.WriteLine("Type: " + Type);
            Console.WriteLine("Number of wings: " + NumberOfWings);
            Console.WriteLine("Weight: " + Weight);
            Console.WriteLine(this.Fly());
            Console.WriteLine(this.Quack());
        }
    }
}
