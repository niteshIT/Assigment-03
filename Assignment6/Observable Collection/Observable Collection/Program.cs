using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observable_Collection
{
    public enum CollectionChangeAction
    {
        Add,
        Remove
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.Add("Apple");
            myClass.Add("Banana");
            myClass.Remove("Apple");
            Console.ReadLine();
        }
    }


}
