using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Cafe_repo
{
    public class Menu
    {
        //this method Run starts the program
        public void Run()
        {
            Menu();       //inside the method Run above, call Menu
        }

        public void MenuItems()     //first method MenuItems contains all items in the "menu"
        {
            bool keepRunning = true;
            while (keepRunning) ;     //while keepRunning loop is true ...
            {

                //a menu with a list of 5 items to choose from
                Console.WriteLine("Select a menu option:\n" +
                    "1. Meal number\n" +
                    "2. Meal name\n" +
                    "3. Description\n" +
                    "4. List of ingredients\n" +
                    "5. Price\n");

                string input = Console.ReadLine();      //whatever the user types will be read by Console.ReadLine, returned and saved as input string


            }

        }
    }

    public class MenuRepository
    {

    }

    public class Test
    {

    }
}
