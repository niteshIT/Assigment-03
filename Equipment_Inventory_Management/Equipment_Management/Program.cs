using System;
using System.Collections.Generic;

namespace Equipment_Management
{
    public enum EquipmentType
    {
        Mobile,
        Immobile
    }
    class Program
    {
        static void Main(string[] args)
        {

            var Equipment = new EquipmentManager();
            bool exit = true;

            while (exit)
            {
                Console.WriteLine("\nPlease choose an operation:\n" +
                              "01. Create an equipment\n" +
                              "02. Delete an equipment\n" +
                              "03. List all equipments\n" +
                              "04. Show details of an equipment\n" +
                              "05. List all mobile equipment\n" +
                              "06. List all immobile equipment\n" +
                              "07. List all equipment that have not been moved till now\n" +
                              "08. Delete all equipment\n" +
                              "09. Delete all immobile equipment\n" +
                              "10. Delete all mobile equipment\n" +
                              "11. Move Equipment\n" +
                              "12. Exit\n");

                int choice;
                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 12)
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 12.");
                }

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("1. Mobile equipment\n" +
                                          "2. Immobile equipment\n" +
                                          "3. Back\n");

                        int input;
                        while (!int.TryParse(Console.ReadLine(), out input) || (input >0 && input >4))
                        {
                            Console.WriteLine("Invalid input. Please enter a number between 0 and 4.");
                        }
                        switch (input)
                        {
                            case 1:
                                var mobileObject = new MobileEquipment();
                                Console.WriteLine("Enter Name");
                                mobileObject.Name = Console.ReadLine();
                                Console.WriteLine("Enter Description");
                                mobileObject.Description = Console.ReadLine();
                                Console.WriteLine("Enter Number of wheels");
                                mobileObject.NumberOfWheels = int.Parse(Console.ReadLine());
                                Equipment.AddEquipment(mobileObject);
                                Console.WriteLine("\nMobile Equipment Added successfully!");
                                break;
                            case 2:
                                var ImmobileObject = new ImmobileEquipment();
                                Console.WriteLine("Enter Name");
                                ImmobileObject.Name = Console.ReadLine();
                                Console.WriteLine("Enter Description");
                                ImmobileObject.Description = Console.ReadLine();
                                Console.WriteLine("Enter Weight");
                                ImmobileObject.Weight = int.Parse(Console.ReadLine());
                                Equipment.AddEquipment(ImmobileObject);
                                Console.WriteLine("\nImmobile Equipment Added successfully!");
                                break;
                            case 3:
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter the name of the Equipment");
                        string deleteName = Console.ReadLine();
                        Equipment.DeleteEquipment(deleteName);
                        Console.WriteLine("Equipment Deleted successfully");
                        break;
                    case 3:
                        List<Equipment> AllEquipment = Equipment.GetAllEquipment();
                        foreach (Equipment Element in AllEquipment)
                        {
                            Element.PrintDetails();
                        }
                        break;
                    case 4:
                        Console.WriteLine("Enter name of the Equipment:");
                        Equipment.ShowEquipmentDetails(Console.ReadLine());
                        break;
                    case 5:
                        List<Equipment> MobileEquipment = Equipment.GetAllMobileEquipment();
                        foreach (Equipment Element in MobileEquipment)
                        {
                            Console.WriteLine(Element.Name);
                        }
                        break;
                    case 6:
                        List<Equipment> immobileEquipment = Equipment.GetAllImmobileEquipment();
                        foreach (Equipment Element in immobileEquipment)
                        {
                            Console.WriteLine(Element.Name);
                        }
                        break;
                    case 7:
                        List<Equipment> ZeroDistance = Equipment.dontmove();
                        foreach (Equipment Element in ZeroDistance)
                        {
                            Console.WriteLine(Element.Name);
                        }
                        break;
                    case 8:
                        Equipment.DeleteAll();
                        break;

                    case 9:
                        Equipment.DeleteAllImmobile();
                        break;
                    case 10:
                        Equipment.DeleteAllMobile();
                        break;
                    case 11:
                        Console.WriteLine("Enter the name of the Equipment you want to move:");
                        var name = Console.ReadLine();
                        Equipment eq = Equipment.returnequip(name);
                        Console.WriteLine("Enter the distance you want to move:");
                        double dist = int.Parse(Console.ReadLine());
                        Equipment.MoveEquipment(eq, dist);
                        break;
                    case 12:
                        exit = false;
                        break;
                }
            }
        }
    }
}
