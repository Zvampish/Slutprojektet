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
            string name = "dummy";

            string[] names = { "Bob", "Tom", "Man" };

            string[] cellItems = { "File", "NrG Drink", "Teleporter", "Rocket Launcher", "Cellphone", "Drill" };

            //string[];

            string location = "";

            while (location != "outside")
            {
                Console.WriteLine("You open your eyes and realize you are in a cell");

                Console.WriteLine("\nA prison officer comes and visits your cell, what's your name he asks.");

                for (int i = 0; i < names.Length; i++)
                {
                    Console.WriteLine(i + 1 + " " + names[i]);
                }

                Console.WriteLine("\nChoose wich name you want by typing the corresponding number.");
                
                string userInpt = Console.ReadLine();

                Console.WriteLine();
                
                if (MakeStringToInt(userInpt) == 1)
                {
                    name = names[0];
                    Console.Clear();
                }
                else if (MakeStringToInt(userInpt) == 2)
                {
                    name = names[1];
                    Console.Clear();
                }
                else if (MakeStringToInt(userInpt) == 3)
                {
                    name = names[2];
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    Console.Write("Since you didn't type a whole number between 1 and 3: ");
                }

                Console.WriteLine("Your name is now " + name + ".");

                Console.WriteLine("\nYou see six different items spread out on the floor:");

                for (int i = 0; i < cellItems.Length; i++)
                {
                    Console.WriteLine(i + 1 + " " + cellItems[i]);
                }
                    
                Console.WriteLine("Choose wich item you want to pick up and use by typing the corresponding number.");
            }
        }
        static int MakeStringToInt(string userInpt)
        {
            int.TryParse(userInpt, out int userInptInt);

            return userInptInt;
        }
    }
}