using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Threading;

namespace ConsoleApp1
{
   
    static class Extensions
    {
       
    }

    class Program 
    {
        static void Main(string[] args)
        {
            Grandfather grandfather = new Grandfather();
            Grandmother grandmother = new Grandmother();
            Bun bun = new Bun();
            Animal[] animals = { new Hare(), new Wolf(), new Bear(), new Fox()};
            Meet meeting;

            Console.WriteLine("Жил-был старик со старухою. Просит старик:");
            grandfather.Speak();
            grandmother.Speak();
            grandfather.FindSolution();
            grandmother.FindFlour();
            grandmother.BakeBun();
            bun.RunAway();
            bun.Run();
            meeting = new Meet(bun, animals[0]);
            meeting.MeetAnimal();
        }
    }
}

