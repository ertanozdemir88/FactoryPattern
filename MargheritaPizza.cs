using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class MargheritaPizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Preparing Margherita Pizza with tomato, mozzarella, and basil.");
        }
    }
}
