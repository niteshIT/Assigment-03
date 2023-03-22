using System;
using System.Collections.Generic;
using System.Linq;

namespace Equipment_Management
{
    class EquipmentManager
    {
        private List<Equipment> Inventory = new List<Equipment>();

        public Equipment returnequip(string name)
        {
            return Inventory.FirstOrDefault(e => e.Name == name);
        }
        public void AddEquipment(Equipment equipment)
        {
            Inventory.Add(equipment);
        }

        public void MoveEquipment(Equipment equipment, double distance)
        {
            equipment.MoveBy(distance);
        }
        public void DeleteEquipment(string name)
        {
            Equipment equipment = Inventory.FirstOrDefault(e => e.Name == name);
            if (equipment != null)
            {
                Inventory.Remove(equipment);
            }
        }
        public List<Equipment> GetAllEquipment()
        {
            return Inventory;
        }
        public List<Equipment> GetAllMobileEquipment()
        {
            return Inventory.Where(e => e.Type == EquipmentType.Mobile).ToList();
        }
        public List<Equipment> GetAllImmobileEquipment()
        {
            return Inventory.Where(e => e.Type == EquipmentType.Immobile).ToList();
        }
        public List<Equipment> dontmove()
        {
            return Inventory.Where(e => e.DistanceMoved == 0).ToList();
        }
        public void DeleteAll()
        {
            Inventory.Clear();
        }
        public void DeleteAllMobile()
        {
            List<Equipment> e1 = Inventory.Where(e => e.Type == EquipmentType.Mobile).ToList();
            foreach (Equipment E in e1)
            {
                Inventory.Remove(E);
            }
        }
        public void DeleteAllImmobile()
        {
            List<Equipment> e1 = Inventory.Where(e => e.Type == EquipmentType.Immobile).ToList();
            foreach (Equipment E in e1)
            {
                Inventory.Remove(E);
            }
        }


        public void ShowEquipmentDetails(string name)
        {
            Equipment equipment = Inventory.FirstOrDefault(e => e.Name == name);
            Console.WriteLine("Name: " + equipment.Name);
            Console.WriteLine("Description: " + equipment.Description);
            Console.WriteLine("Distance Moved: " + equipment.DistanceMoved + " km");
            Console.WriteLine("Maintenance Cost: $" + equipment.MaintenanceCost);
            Console.WriteLine("Type: " + equipment.Type);
            if (equipment is MobileEquipment)
            {
                Console.WriteLine("Number of Wheels: " + ((MobileEquipment)equipment).NumberOfWheels);
            }
            else if (equipment is ImmobileEquipment)
            {
                Console.WriteLine("Weight: " + ((ImmobileEquipment)equipment).Weight);
            }
        }
    }
}
