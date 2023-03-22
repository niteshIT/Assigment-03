using System;
using System.Collections.Generic;

namespace Duck_Simulation_game_Inventory
{
    public enum DuckType
    {
        RubberDuck,
        MallardDuck,
        RedheadDuck
    }
    partial class Program
    {
        static void Main(string[] args)
        {
            var duckmanagement = new DuckManagement();
            bool exit = true;
            while (exit)
            {
                Console.WriteLine("1.Add a duck\n" +
                                  "2.Remove a duck\n" +
                                  "3.Remove all ducks\n" +
                                  "4.Iterate the duck collection in increasing order of their weights\n" +
                                  "5.Iterate the duck collection in increasing order of number of wings\n" +
                                  "6. Exit");

                int choice = GetInput();
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\nEnter the Type of Duck you want to add\n" +
                                          "1.RubberDuck\n" +
                                          "2.Mallardduck\n" +
                                          "3.RedheadDuck");
                        int duckType = GetInput();
                        Console.WriteLine("\nEnter name");
                        string name = GetStringInput();
                        Console.WriteLine("Enter the number of wings");
                        int wings = GetInput();
                        Console.WriteLine("Enter the weight");
                        double weight = double.Parse(Console.ReadLine());
                        switch (duckType)
                        {
                            case 1:
                                var rubberduck = new RubberDuck(name, wings, weight);
                                duckmanagement.AddDuck(rubberduck);
                                break;
                            case 2:
                                var mallardduck = new RubberDuck(name, wings, weight);
                                duckmanagement.AddDuck(mallardduck);
                                break;
                            case 3:
                                var redheadduck = new RubberDuck(name, wings, weight);
                                duckmanagement.AddDuck(redheadduck);
                                break;
                        }
                        Console.WriteLine("\nDuck Added!\n");
                        break;
                    case 2:
                        Console.WriteLine("Enter the name of the duck");
                        string duckName = GetStringInput();
                        duckmanagement.Deleteduck(duckName);
                        Console.WriteLine("\"{0}\"Duck name deleted!",duckName);
                        break;
                    case 3:
                        duckmanagement.DeleteAll();
                        Console.WriteLine("\nAll Ducks are Deleted!");
                        break;
                    case 4:
                        List<Duck> SortedByWeight = duckmanagement.SortByWeight();
                        foreach (Duck item in SortedByWeight)
                        {
                            Console.WriteLine("Name: {0} Weight: {1} Number of wings: {2}", item.Name, item.Weight, item.NumberOfWings);
                        }
                        break;
                    case 5:
                        List<Duck> SortedByWings = duckmanagement.SortByWings();
                        foreach (Duck item in SortedByWings)
                        {
                            Console.WriteLine("Name: {0} Weight: {1} Number of wings: {2}", item.Name, item.Weight, item.NumberOfWings);
                        }
                        break;
                    case 6:
                        exit = false;
                        break;
                    default:
                        Console.WriteLine("No match found");
                        break;
                }
            }
        }
        public static int GetInput()
        {
            int input = 0;
            try
            {
                input = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Please Enter a valid number.");
                input = GetInput();
            }
            return input;
        }
        static string GetStringInput()
        {
            string input = "";
            try
            {
                input = Console.ReadLine();
                int result;
                if (int.TryParse(input, out result))
                {
                    throw new FormatException(); // If input is an integer, throw an exception
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Please Enter a valid string.");
                input = GetStringInput();
            }
            return input;
        }
    }
}
