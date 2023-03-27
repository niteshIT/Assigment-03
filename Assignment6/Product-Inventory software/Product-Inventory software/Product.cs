using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Inventory_software
{
    class Product : IEquatable<Product>
    {
        public int Id { get; set; }
        private float price;
        public float Price
        {
            get { return price; }
            set
            {
                if (price != value)
                {
                    //priceChangedEventArgs e = new PriceChangedEventArgs(value - price);
                    price = value;
                    //ChangePrice(this, e);
                    
                    OnPriceChanged();
                }
            }
        }

        public Product(int id, float price)
        {
            Id = id;
            this.price = price;
        }

        public bool Equals(Product other)
        {
            if (other == null)
            {
                return false;
            }
            return (this.Id == other.Id);
        }

        public delegate void PriceChangedEventHandler(object sender, EventArgs e);
        public event PriceChangedEventHandler PriceChanged;
        public delegate void DefectiveEventHandler(object sender, EventArgs e);
        public event DefectiveEventHandler Defective;

        protected virtual void OnPriceChanged()
        {
            PriceChanged?.Invoke(this, EventArgs.Empty);
        }
        protected virtual void OnDefective()
        {
            Defective?.Invoke(this, EventArgs.Empty);
        }
    }

}
