using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class PepperoniPizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Preparing Pepperoni Pizza with tomato, mozzarella, and pepperoni.");
        }
    }
}
