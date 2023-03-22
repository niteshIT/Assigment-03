using System;

namespace Duck_Simulation_game_Inventory
{
    public abstract class Duck
    {
        public int NumberOfWings { get; set; } = 0;
        public string Name { get; set; }
        public double Weight { get; set; } = 0;

        public abstract DuckType Type { get; }
        public virtual void ShowDetail()
        {
            Console.WriteLine("Number of wings: " + NumberOfWings);
            Console.WriteLine("Weight: " + Weight);
        }

    }
}
