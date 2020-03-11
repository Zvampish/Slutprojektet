using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slutprojektet
{
    class Program
    {
        static void Main()
        {
            string[] cellItems = {"File", "NrG Drink","Teleporter","Rocket Launcher","Cellphone","Drill"};

            //string[];

            string location = "";

            while (location != "outside")
            {
                Console.WriteLine("You open your eyes and realize you are in a cell");
                Console.WriteLine("");
                Console.WriteLine("You see six different items spread out on the floor:");
                Console.WriteLine("");

                for (int i = 0; i < cellItems.Length; i++)
                {
                    Console.WriteLine(i + 1 + " " + cellItems[i]);
                }

                Console.WriteLine("Choose wich item you want to use by pressing the corresponding number. (Don't use your numpad, it won't work)");

                if (Console.ReadKey().Key == ConsoleKey.D1)
                {
                    Console.WriteLine("\nbruh");
                }

                Console.ReadLine();
            }
        }
    }
}
