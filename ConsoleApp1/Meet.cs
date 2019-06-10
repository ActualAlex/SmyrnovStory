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
        private int countMeeting;

        public Meet(Bun bun,Animal animal)
        {
            this.bun = bun;
            this.animal = animal;
        }
        

        public void MeetAnimal()
        {
            Console.WriteLine("Катится колобок по дороге, а навстречу ему {0}", animal.Name);
            animal.Speak();
            if (animal is Hare)
            {
                Console.WriteLine("Не ешь меня, косой зайчик! Я тебе песенку спою");
                bun.Sing();
                Console.WriteLine("От тебя, зайца, не хитро уйти!");
            }
            else if (animal is Wolf)
                Console.WriteLine("Не ешь меня, серый волк! Я тебе песенку спою!");
            else if (animal is Bear)
                Console.WriteLine("Где тебе, косолапому, съесть меня!");
       //     else if (animal is Fox)

        }

    }
}
