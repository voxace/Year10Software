﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 1000; i++)
            {
                if(i%3==0 && i%5==0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fizz Buzz");
                    Console.Beep(1000, 100);
                }
                else if (i % 3 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Fizz");
                    Console.Beep(2000, 100);
                }
                else if (i % 5 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Buzz");
                    Console.Beep(3000, 100);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
