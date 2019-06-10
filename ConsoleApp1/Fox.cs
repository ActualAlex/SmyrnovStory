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
        private bool mouthIsEmpty = true;

        public Fox()
        {
            Name = "Лиса";
        }
        public void FindSolution()
        {
            if (noseIsEmpty && mouthIsEmpty)
            {
                Console.WriteLine("Какая славная песенка! — сказала лиса.");
                Console.WriteLine("Но ведь я, колобок, стара стала, плохо слышу; сядь-ка на мой ноcик да пропой еще разок погромче");
                noseIsEmpty = false;
            }
            else if (!noseIsEmpty)
            {
                Console.WriteLine("Спасибо, колобок! Славная песенка, еще бы послушала! Сядь-ка на мой язычок да пропой в последний разок  — сказала лиса и высунула свой язык");
                noseIsEmpty = true;
                mouthIsEmpty = false;
            }
            else if (!mouthIsEmpty)
            {
                Console.WriteLine("Колобок прыг ей на язык, а лиса — ам его! и скушала");
            }
        }

        public override void Speak()
        {
            Console.WriteLine("Здравствуй, колобок! Какой ты хорошенький");
        }
    }
}
