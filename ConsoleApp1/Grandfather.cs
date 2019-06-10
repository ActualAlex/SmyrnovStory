using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Grandfather : People, IInventive
    {
        public Grandfather()
        {
            Name = "Старик";
        }

        public void FindSolution()
        {
            Console.WriteLine("Э-эх, старуха! По коробу поскреби, по сусекам помети, авось муки и наберется.");
        }

        public override void Speak()
        {
            Console.WriteLine("Испеки, старуха, колобок.");
        }
    }
}
