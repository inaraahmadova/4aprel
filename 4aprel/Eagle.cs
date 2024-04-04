using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4aprel
{
    internal class Eagle : Bird
    {
        public override void Eat()
        {
            Console.WriteLine("Eat as Eagle");
        }

        public override void Fly()
        {
            Console.WriteLine("Fly as Eagle");
        }
    }
}


