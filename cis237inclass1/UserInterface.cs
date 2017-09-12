using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass1
{
    class UserInterface
    {
        //No Variables
        //No Properties
        //No Constructors. We will just use the default

        //******************************
        //Public Methods
        //******************************
        public int GetUserInput()
        {
            //Print out a menu
            this.PrintMenu();

            //Get the input from the user
            String input = Console.ReadLine();

            //While the input is not valid re-get the input
            while(input != "1" && input != "2")
            {
                //Print Error message
                this.PrintErrorMessage();

                //Re-Print the menu
                this.PrintMenu();

                //Get the input from the console again.
                input = Console.ReadLine();
            }

            //At this point, I KNOW the input is a valid number of either
            //a 1 or a 2.
            return Int32.Parse(input);
        }

        //I realize this looks silly, but now I KNOW that
        //any interaction that uses the Console will be in
        //this file. I won't have to look through my code
        //to find it anywhere else
        public void Output(string outputString)
        {
            Console.WriteLine(outputString);
        }

        //*******************************
        //Private Methods
        //*******************************
        private void PrintMenu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Print List");
            Console.WriteLine("2. Exit");
        }

        private void PrintErrorMessage()
        {
            Console.WriteLine("That is not a valid entry");
            Console.WriteLine("Please make a valid choice");
            Console.WriteLine();
        }


    }
}
