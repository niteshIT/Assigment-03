using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Inventory_software
{
    public class Events : EventArgs
    {
        public float OldPrice { get; set; }
        public float NewPrice { get; set; }
        public Events(float x, float y){
            OldPrice = x;
            NewPrice = y;

        }
    }
}
