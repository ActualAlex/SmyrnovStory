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
                for (int i = 0; i < 30; i++)
                {
                    Thread.Sleep(50);
                    Console.Write(".");
                }
                Console.WriteLine();
                x = random.Next(0, 100);
            }
        }

     /*   public void MeetAnimal(Animal animal)
        {
            Console.WriteLine("Катится колобок по дороге, а навстречу ему {0}", animal.Name);
            animal.Speak();
            if (animal is Hare)
                Console.WriteLine("Не ешь меня, косой зайчик! Я тебе песенку спою");
            else if (animal is Wolf)
                Console.WriteLine("Не ешь меня, серый волк! Я тебе песенку спою!");
            else if (animal is Bear)
                Console.WriteLine("Где тебе, косолапому, съесть меня!");


        } */

        public void Sing()
        {
            Console.WriteLine("Я по коробу скребён");
            Console.WriteLine("По сусеку метён,");
            Console.WriteLine("На сметане мешон,");
            Console.WriteLine("Да в масле пряжон.");
            Console.WriteLine("На окошке стужон;");
            Console.WriteLine("Я от дедушки ушёл,");
            Console.WriteLine("Я от бабушки ушёл,");
            Console.WriteLine("И от тебя уйду.");
        }
    }
}
