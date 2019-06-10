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
            Random random = new Random();
            int x = 0;
            while (x < 40)
            {
                for (int i = 0; i < 20; i++)
                {
                    Thread.Sleep(50);
                    Console.Write(".");
                }
                Console.WriteLine();
                x = random.Next(0, 50);
            }
        }
    }
}

