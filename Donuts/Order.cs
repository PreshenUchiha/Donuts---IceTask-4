using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donuts
{
    class Order
    {
        public Order(string name, int donuts, int coffee)
        {
            Name = name;
            Donuts = donuts;
            Coffee = coffee;
        }

        public string Name { get; set; }
       
        public int Donuts { get; set; }

       public int Coffee { get; set; }

        public override string ToString()
        {
            return this.Name + " : " + this.Coffee + this.Donuts + "donuts &" + this.Coffee + "coffee";
        }
    }
}
