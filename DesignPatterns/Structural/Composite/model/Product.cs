using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite.model
{
    public class Product : Sale
    {

        public string Name { get; set; }
        public float Price { get; set; }
        public Product(string name, float price)
        {
            Name = name;
            Price = price;
        }

        public override float GetPrice()
        {
            return Price;
        }

        public override void AddItem(Sale item)
        {
            throw new NotImplementedException();
        }

        public override void RemoveItem(Sale item)
        {
            throw new NotImplementedException();
        }

        public override Sale GetChild(int index)
        {
            throw new NotImplementedException();
        }
    }
}
