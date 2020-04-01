﻿using System;
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
            Random generator = new Random();

            string name = "";

            string item = "";

            bool validAnswer = false;

            //Använder två arrayer nedan eftersom det endast ska finnas dessa bestämda items och names.

            string[] names = { "Bob", "Tom", "Man" };

            string[] cellItems = { "The File", "The NrG Drink", "The Teleporter"/*, "The Rocket Launcher", "The Cellphone", "The Drill" */};

            string[] roomDescriptions = { "You open your eyes and realize you are in a cell."};

            string[] cellItemDescriptions = { "Do you want to use " + cellItems[0] + " on the cell window or the cell door?"};

            //I slutet ska man skriva in en kod som baseras på de valen man väljer. Om man valde det tredje alternativet i den första så ska man 

            string location = "cell";

            while (location == "cell"){
                Console.WriteLine(roomDescriptions[0]);

                Console.WriteLine("\nA prison officer comes and visits your cell, what's your name he asks.");

                while (validAnswer == false){
                    for (int i = 0; i < names.Length; i++){
                        Console.WriteLine(i + 1 + " " + names[i]);
                    }

                    Console.WriteLine("\nChoose wich name you want by typing the corresponding number.");

                    string userNameInpt = Console.ReadLine();

                    if (MakeStringToInt(userNameInpt) == 1){
                        name = names[0];
                        validAnswer = true;
                    }
                    else if (MakeStringToInt(userNameInpt) == 2){
                        name = names[1];
                        validAnswer = true;
                    }
                    else if (MakeStringToInt(userNameInpt) == 3){
                        name = names[2];
                        validAnswer = true;
                    }
                    else{
                        Console.Clear();
                        Console.WriteLine("Type an integer between 1-3");
                        Console.WriteLine("\nPress any key to try again");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }

                Console.WriteLine("\nYour name is now " + name + ".");

                validAnswer = false;

                while (validAnswer == false){

                    Console.WriteLine("\nYou see six different items spread out on the floor:");

                    for (int i = 0; i < cellItems.Length; i++){
                        Console.WriteLine(i + 1 + " " + cellItems[i]);
                    }

                    Console.WriteLine("\nChoose which item you want to pick up and use by typing the corresponding number.");

                    string userTtemInpt = Console.ReadLine().Trim();

                    if (MakeStringToInt(userTtemInpt) == 1){
                        item = cellItems[0];
                        validAnswer = true;
                    }
                    else if (MakeStringToInt(userTtemInpt) == 2){
                        item = cellItems[1];
                        validAnswer = true;
                    }
                    else if (MakeStringToInt(userTtemInpt) == 3){
                        item = cellItems[2];
                        validAnswer = true;
                    }
                    /*else if (MakeStringToInt(userTtemInpt) == 4){
                        item = cellItems[3];
                        validAnswer = true;
                    }
                    else if (MakeStringToInt(userTtemInpt) == 5){
                        item = cellItems[4];
                        validAnswer = true;
                    }
                    else if (MakeStringToInt(userTtemInpt) == 6){
                        item = cellItems[5];
                        validAnswer = true;
                    }*/
                    else{
                        Console.WriteLine("Type an integer between 1-6");
                        Console.WriteLine("Press any key to try again");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    if (item == cellItems[0])
                    {
                        Console.WriteLine("\nYour picked up " + item + ".");

                        Console.WriteLine("\n" + cellItemDescriptions[0]);

                        Console.WriteLine("\nAnswer the next two statements with either 1 for true or 0 for false.");

                        Console.WriteLine("\nYou want to use The File on the cell window.");

                        string windowTrueOrFalse = Console.ReadLine();

                        Console.WriteLine("\nYou want to use The File on the cell door.");

                        string doorTrueOrFalse = Console.ReadLine();

                        TrueOrFalse(MakeStringToInt(windowTrueOrFalse), MakeStringToInt(doorTrueOrFalse));
                    }

                    
                    Console.ReadLine();

                    Console.Clear();

                    Console.WriteLine("THE GAME TRIAL HAS ENDED.");

                    Console.ReadLine();

                    location = "outside";
                }
            }
        }
        static int MakeStringToInt(string userInpt){
            int.TryParse(userInpt, out int userInptInt);

            return userInptInt;
        }
        static string TrueOrFalse(int x, int y){
            if (x == y)
            {
                string 
            }}
            else if (x > y){
                string  
            }
            else if (x < y)
            {

            }
        }
    }
}