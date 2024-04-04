using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace _4aprel
{
    internal class Shark : Fish
    {
        public override void Eat()
        {
            Console.WriteLine("Eat as Shark");
        }
    }
}
