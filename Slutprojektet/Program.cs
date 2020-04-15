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
            string location = "cell";

            while (location == "cell")
            {
                string name = "";

                bool validAnswer = false;

                //Använder fyra arrayer nedan eftersom det endast ska finnas dessa bestämda föremål, namnen, beskrivningarna och tipsen.

                string[] names = { "Bob", "Tom", "Man" };

                string[] cellItems = { "The File", "The NrG Drink", "The Teleporter" };

                string[] roomDescriptions = { "You open your eyes and realize you are in a cell." };

                string[] retryTips = { "Type an integer between 1-3", "Type an integer between 1-2", "Type either Y or N (lower case does not work)" };

                Console.WriteLine(roomDescriptions[0]);
                Console.WriteLine("\nA prison officer comes and visits your cell, what's your name he asks.");
                AskForName(validAnswer, name, names, retryTips);
                string x = AskForItem(validAnswer, cellItems, name, "", retryTips);
                string y = UsingItems(validAnswer, x, cellItems, location, retryTips);
                if (y == "end")
                {
                    while (validAnswer == false)
                    {
                        Console.WriteLine("Do you want to restart? (Y/N)");

                        string restartOrNot = Console.ReadLine().ToUpper().Trim();

                        if (restartOrNot == "Y")
                        {
                            Console.Clear();
                            validAnswer = true;

                        }
                        else if (restartOrNot == "N")
                        {
                            location = "outside";
                            validAnswer = true;
                        }
                        else
                        {
                            Else(retryTips[2]);
                        }

                    }
                }
                Console.Clear();
                Console.WriteLine("Om du har kommit hit är det atingen slut på content eller så har du dött och försökt starta om (Tryck ENTER för att spela igen)");
                Console.ReadLine();
                Console.Clear();
            }
        }
        static int MakeStringToInt(string userInpt)
        {
            int.TryParse(userInpt, out int userInptInt);
            return userInptInt;
        }
        static void Else(string tip)
        {
            Console.WriteLine("\n" + tip);
            Console.WriteLine("\nPress any key to try again");
            Console.ReadKey();
        }
        //Nedan skulle jag kunna kombinera Íntro() och AskForName() eller lägga intro i Main men jag valde att göra såhär så att 
        static void AskForName(bool validAnswer, string name, string[] names, string[] retryTips)
        {
            validAnswer = false;

            while (validAnswer == false)
            {
                Console.WriteLine();

                for (int i = 0; i < names.Length; i++)
                {
                    Console.WriteLine(i + 1 + " " + names[i]);
                }

                Console.WriteLine("\nChoose wich name you want by typing the corresponding number.");

                string userNameInpt = Console.ReadLine();

                if (MakeStringToInt(userNameInpt) == 1)
                {
                    name = names[0];
                    validAnswer = true;
                }
                else if (MakeStringToInt(userNameInpt) == 2)
                {
                    name = names[1];
                    validAnswer = true;
                }
                else if (MakeStringToInt(userNameInpt) == 3)
                {
                    name = names[2];
                    validAnswer = true;
                }
                else
                {
                    Else(retryTips[0]);
                }
            }

            Console.WriteLine("\nYour name is now " + name + ".");
        }
        static string AskForItem(bool validAnswer, string[] cellItems, string name, string item, string[] retryTips)
        {
            validAnswer = false;

            Console.WriteLine("\nYou see six different items spread out on the floor:");

            while (validAnswer == false)
            {
                for (int i = 0; i < cellItems.Length; i++)
                {
                    Console.WriteLine(i + 1 + " " + cellItems[i]);
                }

                Console.WriteLine("\nChoose which item you want to pick up and use by typing the corresponding number.");

                string userTtemInpt = Console.ReadLine().Trim();
                if (MakeStringToInt(userTtemInpt) == 1)
                {
                    item = cellItems[0];
                    validAnswer = true;
                }
                else if (MakeStringToInt(userTtemInpt) == 2)
                {
                    item = cellItems[1];
                    validAnswer = true;
                }
                else if (MakeStringToInt(userTtemInpt) == 3)
                {
                    item = cellItems[2];
                    validAnswer = true;
                }
                else
                {
                    Else(retryTips[0]);
                }
            }
            return item;
        }
        static string UsingItems(bool validAnswer, string item, string[] cellItems, string location, string[] retryTips)
        {
            if (item == cellItems[0])
            {
                Console.WriteLine("\nYour picked up " + item + ".");

                while (validAnswer == false)
                {
                    Console.WriteLine("\nEnter 1 to use The File on the cell window.");
                    Console.WriteLine("\nEnter 2 to use The File on the cell door.");

                    string windowOrDoor = Console.ReadLine();

                    if (MakeStringToInt(windowOrDoor) == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("You filed the window bars for three hours just to jump out of the window and fall 30 meters to a guaranteed death.");
                        location = "end";
                        validAnswer = true;
                    }
                    else if (MakeStringToInt(windowOrDoor) == 2)
                    {
                        Console.Clear();
                        validAnswer = true;
                    }
                    else
                    {
                        Else(retryTips[1]);
                    }
                }
            }
            else if (item == cellItems[1])
            {

            }
            else if (item == cellItems[1])
            {

            }
            else
            {

            }

            return location;
        }
        static bool ExitDoorCode(int one, int two, int three, int four)
        {
            return true;
        }
    }
}