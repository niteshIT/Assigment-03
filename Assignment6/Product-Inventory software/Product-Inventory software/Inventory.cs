using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Inventory_software
{
    class Inventory
    {
        private Dictionary<Product, int> products = new Dictionary<Product, int>();
        private float totalValue = 0;

        public void AddProduct(Product product, int quantity)
        {
            if (products.ContainsKey(product))
            {
                products[product] += quantity;
            }
            else
            {
                products[product] = quantity;
                product.PriceChanged += Product_PriceChanged;
            }
            totalValue += product.Price * quantity;
        }

        private void Product_PriceChanged(object sender, EventArgs e)
        {
            Product product = (Product)sender;
            int quantity = products[product];
            //totalValue -= product.Price * quantity;
            totalValue += product.Price * quantity;
        }
        private void Product_Defective(object sender, EventArgs e)
        {
            Product product = sender as Product;
            int quantity = products[product];
            products.Remove(product);
            totalValue -= product.Price * quantity;
        }

        public void RemoveProduct(Product product, int quantity)
        {
            if (products.ContainsKey(product))
            {
                if (products[product] > quantity)
                {
                    products[product] -= quantity;
                    totalValue -= product.Price * quantity;
                }
                else
                {
                    products.Remove(product);
                    totalValue -= product.Price * products[product];
                    product.PriceChanged -= Product_PriceChanged;
                }
            }
        }

        public void UpdateProductQuantity(Product product, int quantity)
        {
            if (products.ContainsKey(product))
            {
                int oldQuantity = products[product];
                products[product] = quantity;
                totalValue += product.Price * (quantity - oldQuantity);
            }
        }

        public void MarkProductAsDefective(Product product)
        {
            if (products.ContainsKey(product))
            {
                totalValue -= product.Price * products[product];
                products.Remove(product);
                product.Defective -= Product_Defective;
            }
        }

        public float GetTotalValue()
        {
            return totalValue;
        }
    }

}
