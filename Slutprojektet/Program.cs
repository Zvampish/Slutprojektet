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

            string item;

            string[] names = { "Bob", "Tom", "Man" };

            string[] cellItems = { "File", "NrG Drink", "Teleporter", "Rocket Launcher", "Cellphone", "Drill" };

            //I slutet ska man skriva in en kod som baseras på de valen man väljer. Om man valde det tredje alternativet i den första så ska man 

            string location = "";

            while (location != "outside"){
                Console.WriteLine("You open your eyes and realize you are in a cell");

                Console.WriteLine("\nA prison officer comes and visits your cell, what's your name he asks.");

                bool validAnswer = false;

                while (validAnswer == false){
                    for (int i = 0; i < names.Length; i++){
                        Console.WriteLine(i + 1 + " " + names[i]);
                    }

                    Console.WriteLine("\nChoose wich name you want by typing the corresponding number.");

                    string userInpt = Console.ReadLine();

                    if (MakeStringToInt(userInpt) == 1){
                        name = names[0];
                        validAnswer = true;
                    }
                    else if (MakeStringToInt(userInpt) == 2){
                        name = names[1];
                        validAnswer = true;
                    }
                    else if (MakeStringToInt(userInpt) == 3){
                        name = names[2];
                        validAnswer = true;
                    }
                    else{
                        Console.Write("Type an integer between 1-3");
                        Console.WriteLine("Press any key to try again");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }

                Console.WriteLine();

                Console.WriteLine("Your name is now " + name + ".");

                validAnswer = false;

                while (validAnswer == false){

                    Console.WriteLine("\nYou see six different items spread out on the floor:");

                    for (int i = 0; i < cellItems.Length; i++)
                    {
                        Console.WriteLine(i + 1 + " " + cellItems[i]);
                    }

                    Console.WriteLine("\nChoose which item you want to pick up and use by typing the corresponding number.");

                    string userInpt = Console.ReadLine();

                    if (MakeStringToInt(userInpt) == 1){
                        item = cellItems[0];
                        validAnswer = true;
                    }
                    else if (MakeStringToInt(userInpt) == 2){
                        item = cellItems[1];
                        validAnswer = true;
                    }
                    else if (MakeStringToInt(userInpt) == 3){
                        item = cellItems[2];
                        validAnswer = true;
                    }
                    else if (MakeStringToInt(userInpt) == 4){
                        item = cellItems[3];
                        validAnswer = true;
                    }
                    else if (MakeStringToInt(userInpt) == 5){
                        item = cellItems[4];
                        validAnswer = true;
                    }
                    else if (MakeStringToInt(userInpt) == 6){
                        item = cellItems[5];
                        validAnswer = true;
                    }
                    else{
                        Console.WriteLine("Type an integer between 1-6");
                        Console.WriteLine("Press any key to try again");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
            }
        }
        static int MakeStringToInt(string userInpt)
        {
            int.TryParse(userInpt, out int userInptInt);

            return userInptInt;
        }
    }
}