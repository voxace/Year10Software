using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age:");
            int age = int.Parse(Console.ReadLine());

            if (age < 13)
            {
                Console.WriteLine("You are a Child!");
            }
            else if(age < 20)
            {
                Console.WriteLine("You are a Teenager!");
            }
            else
            {
                Console.WriteLine("You are an Adult");
            }
            Console.ReadKey();
        }
    }
}
