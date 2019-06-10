using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Grandmother : People
    {
        private bool flour;
        public Grandmother()
        {
            Name = "Старуха";
        }
        public override void Speak()
        {
            Console.WriteLine("Из чего печь-то? Муки нету.");
        }

        public void FindFlour()
        {
            Console.WriteLine("Взяла старуха крылышко, по коробу поскребла, по сусеку помела, и набралось муки пригоршни с две.");
        }

        public void BakeBun()
        {
            Console.WriteLine("Замесила на сметане, изжарила в масле и положила на окошечко постудить.");
        }
    }
}
