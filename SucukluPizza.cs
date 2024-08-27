using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class SucukluPizza : Pizza
    {
        public override void Prepare()
        {
            Console.WriteLine("Preparing Sucuklu Pizza with sucuk.");
        }
    }
}
