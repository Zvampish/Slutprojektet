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
                bool validAnswer = false;

                //Använder fyra arrayer nedan eftersom det endast ska finnas dessa bestämda föremål, namnen, beskrivningarna och tipsen.

                string[] cellItems = { "The File", "The NrG Drink", "The Teleporter" };

                string[] roomDescriptions = { "You open your eyes and realize you are in a cell." };

                string[] retryTips = { "Tip: Only one integer between 1-3 is a valid answer.", "Tip: Only one integer between 1-2 is a valid answer."
                                      ,"Tip: Only Y or N  is a valid answer." };

                Console.WriteLine(roomDescriptions[0]);
                Console.WriteLine("\nA prison officer comes and visits your cell, what's your name he asks.");
                AskForName(validAnswer, retryTips);
                string x = AskForItem(validAnswer, cellItems, "", retryTips);
                string currentLocation = UsingItems(validAnswer, x, cellItems, location, retryTips);
                string z = RetryMaybe(currentLocation, validAnswer, location, retryTips);
                if (z == "outside"){
                    location = "outside";
                }
                //Skulle kunna lägga detta i en metod under komplettering och sedan returnera "location" variabeln för att se om de är "outside".
                /*if (y == "end")
                {
                    while (validAnswer == false)
                    {
                        Console.WriteLine("Do you want to restart? (Y/N)");

                        string restartOrNot = Console.ReadLine().ToUpper().Trim();

                        if (restartOrNot == "Y")
                        {
                            Console.Clear();
                            Console.Clear();
                            Console.WriteLine("If you have come here there's either no more content or you died and tried to restart(Press ENTER to play again).");
                            Console.ReadLine();
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
                else if (y == "cell")
                {
                    Console.Clear();
                    Console.WriteLine("If you have come here there's either no more content or you died and tried to restart(Press ENTER to play again).");
                    Console.ReadLine();
                    Console.Clear();
                }*/
            }
        }
        static int MakeStringToInt(string userInpt)
        {
            int.TryParse(userInpt, out int userInptInt);
            return userInptInt;
        }
        static void Else(string tip)
        {
            Console.WriteLine("ERROR: False Input");
            Console.WriteLine(tip);
            Console.WriteLine("(Press any key to try again)");
            Console.ReadKey();
            Console.WriteLine();
        }
        static void AskForName(bool validAnswer, string[] retryTips)
        {
            string[] names = { "Bob", "Tom", "Man" };

            string name = "";

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
        static string AskForItem(bool validAnswer, string[] cellItems, string item, string[] retryTips)
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
        static string RetryMaybe(string y, bool validAnswer, string location, string[] retryTips)
        {
            if (y == "end")
            {
                while (validAnswer == false)
                {
                    Console.WriteLine("Do you want to restart? (Y/N)");

                    string restartOrNot = Console.ReadLine().ToUpper().Trim();

                    if (restartOrNot == "Y")
                    {
                        Console.Clear();
                        Console.Clear();
                        Console.WriteLine("If you have come here there's either no more content or you died and tried to restart(Press ENTER to play again).");
                        Console.ReadLine();
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
            else if (y == "cell")
            {
                Console.Clear();
                Console.WriteLine("If you have come here there's either no more content or you died and tried to restart(Press ENTER to play again).");
                Console.Clear();
            }
            return location;
        }
    }
}