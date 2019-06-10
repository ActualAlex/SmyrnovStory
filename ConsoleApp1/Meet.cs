using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Meet
    {
        private Bun bun;
        private Animal animal;
        private static int countMeet;

        public static int CountMeet
        {
            get { return countMeet; }
        } 

        public Meet(Bun bun,Animal animal)
        {
            this.bun = bun;
            this.animal = animal;
        }
        

        public void MeetAnimal()
        {
            Console.WriteLine("Катится колобок по дороге, а навстречу ему {0}:", animal.Name);
            animal.Speak();
            Console.WriteLine("Не ешь меня, {0}! Я тебе песенку спою:",animal.Name);
            bun.Sing(countMeet);
            Console.WriteLine("От тебя, {0}, не хитро уйти!", animal.Name);
            countMeet++;
        }

    }
}
