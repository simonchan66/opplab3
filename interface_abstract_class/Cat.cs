using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_abstract_class
{
    public class Cat : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Cats eat mice.");
        }
    }
}
