using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Inventory_software
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory1 = new Inventory();
            Product product1 = new Product(1, 40);
            inventory1.AddProduct(product1, 30);


            Product product2 = new Product(2, 240);
            inventory1.AddProduct(product2, 500);


            Console.WriteLine(inventory1.GetTotalValue());
            inventory1.MarkProductAsDefective(product1);
            Console.WriteLine(inventory1.GetTotalValue());
            product2.Price = 50;
            Console.WriteLine(inventory1.GetTotalValue());
            Console.ReadKey();
        }
    }
}
