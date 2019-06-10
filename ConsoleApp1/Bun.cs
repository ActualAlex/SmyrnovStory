using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Bun
    { 
        private string Name { get; }

        public Bun()
        {
            Name = "Колобок";
        }

        public void RunAway()
        {
            Console.WriteLine("Колобок полежал-полежал, да вдруг и покатился — с окна на лавку, с лавки на пол, по полу да к дверям, перепрыгнул через порог в сени, из сеней на крыльцо, с крыльца на двор, со двора за ворота, дальше и дальше.");
        }

        public void Run()
        {
            Random random = new Random();
            int x = 0;
            while (x < 50)
            {
                for (int i = 0; i < 50; i++)
                {
                    Thread.Sleep(30);
                    Console.Write(".");
                }
                Console.WriteLine();
                x = random.Next(0, 100);
            }
        }

        public void Sing(int countMeet)
        {
            Console.WriteLine("Я по коробу скребён");
            Console.WriteLine("По сусеку метён,");
            Console.WriteLine("На сметане мешон,");
            Console.WriteLine("Да в масле пряжон.");
            Console.WriteLine("На окошке стужон;");
            Console.WriteLine("Я от дедушки ушёл,");
            Console.WriteLine("Я от бабушки ушёл,");
            if(countMeet > 0)
                Console.WriteLine("Я от зайца ушел,");
            if(countMeet > 1)
                Console.WriteLine("Я от волка ушёл,");
            if (countMeet > 2)
                Console.WriteLine("От медведя ушёл,");
        }
    }
}
