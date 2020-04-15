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
            //Random generator = new Random();

            string name = "";

            string item = "";

            bool validAnswer = false;

            //Använder två arrayer nedan eftersom det endast ska finnas dessa bestämda items och names.

            string[] names = { "Bob", "Tom", "Man" };

            string[] cellItems = { "The File", "The NrG Drink", "The Teleporter" };

            string[] roomDescriptions = { "You open your eyes and realize you are in a cell." };

            string[] retryTips = { "Type an integer between 1-3", "Type an integer between 1-6", "Type an integer between 0-1", "Type either Y or N (lower case does not work)" };

            //I slutet ska man skriva in en kod som baseras på de valen man väljer. Om man valde det tredje alternativet i den första så ska man 

            string location = "cell";



            while (location == "cell")
            {
                validAnswer = false;

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
                            location = "hell";
                            validAnswer = true;
                        }
                        else if (MakeStringToInt(windowOrDoor) == 2)
                        {

                            validAnswer = true;
                        }
                        else
                        {
                            Else(retryTips[2]);
                        }




                        while (location == "hell")
                        {
                            Console.WriteLine("You died");
                            Console.WriteLine("\nGAME OVER");
                            Console.WriteLine("Do you want to restart? (Y/N)");
                            validAnswer = false;
                            string restartOrNot = Console.ReadLine().ToUpper().Trim();

                            while (validAnswer == false)
                            {
                                if (restartOrNot == "Y")
                                {
                                    location = "cell";
                                    validAnswer = true;
                                    Console.Clear();
                                }
                                else if (restartOrNot == "N")
                                {
                                    location = "end";
                                }
                                else
                                {
                                    Else(retryTips[3]);
                                }
                            }
                        }

                        while (location == "end")
                        {
                            Console.Clear();
                            Console.WriteLine("THE GAME TRIAL HAS ENDED.");
                            Console.ReadLine();
                        }


                    }

                    while (location == "outside")
                    {

                    }
                }
            }
        }
        static int MakeStringToInt(string userInpt)
        {
            bool trueOrNot = int.TryParse(userInpt, out int userInptInt);
            int bruh = 403;
            if (trueOrNot == true)
            {
                return userInptInt;
            }
            else
            {
                return bruh;
            }

        }
        static void Else(string tip)
        {
            Console.WriteLine("\n" + tip);
            Console.WriteLine("\nPress any key to try again");
            Console.ReadKey();
        }
        static void Intro(string roomDescriptions)
        {
            Console.WriteLine(roomDescriptions[0]);
            Console.WriteLine("\nA prison officer comes and visits your cell, what's your name he asks.");
        }
        static void AskForName(bool validAnswer, string name, string[] names, string[] retryTips)
        {
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
        }
        static void AskForItem(bool validAnswer, string[] cellItems, string name, string item, string[] retryTips)
        {
            Console.WriteLine("\nYour name is now " + name + ".");

            validAnswer = false;

            while (validAnswer == false)
            {

                Console.WriteLine("\nYou see six different items spread out on the floor:");

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
                    Else(retryTips[1]);
                }
            }
        }  
        static bool ExitDoorCode(int one, int two, int three, int four){
            return true;
        }
        
    }
}