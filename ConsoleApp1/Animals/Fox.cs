using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Fox : Animal, IInventive
    {
        private bool noseIsEmpty = true;

        public Fox()
        {
            Name = "Лиса";
        }
        public void FindSolution()
        {
            if (noseIsEmpty)
            {
                Console.WriteLine("Какая славная песенка! — сказала лиса.");
                Console.WriteLine("Но ведь я, колобок, стара стала, плохо слышу; сядь-ка на мой ноcик да пропой еще разок погромче");
                Console.WriteLine("Колобок вскочил лисе на мордочку и запел ту же песню:");
                noseIsEmpty = false;
            }
            else 
            {
                Console.WriteLine("Спасибо, колобок! Славная песенка, еще бы послушала! Сядь-ка на мой язычок да пропой в последний разок  — сказала лиса и высунула свой язык");
                Console.WriteLine("Колобок прыг ей на язык, а лиса — ам его! и скушала");
                noseIsEmpty = true;
            }

        }

        public override void Speak()
        {
            Console.WriteLine("Здравствуй, колобок! Какой ты хорошенький");
        }
    }
}
