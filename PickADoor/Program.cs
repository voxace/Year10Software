using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickADoor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a door");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Behind door 1 is Bo Browning");
            }
            else if (choice == "2")
            {
                Console.WriteLine("Behind door 2 is Bo again");
            }
            else if (choice == "3")
            {
                Console.WriteLine("Behind door 3 is Mr. Bo Browning");
            }
            else
            {
                Console.WriteLine("Bo's not happy");
            }

            Console.ReadKey();

        }
    }
}
