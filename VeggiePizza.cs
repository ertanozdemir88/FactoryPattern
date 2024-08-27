using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class VeggiePizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Preparing Veggie Pizza with tomato, mozzarella, and mixed vegetables.");
        }
    }
}
