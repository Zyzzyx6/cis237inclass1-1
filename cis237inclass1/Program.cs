using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Let's make a new UI class that we can use below
            UserInterface ui = new UserInterface();

            //Here is a new Employee being created just to make sure
            //that our Employee class works
            Employee myEmployee = new Employee("David", "Barnes", 835.00m);

            Console.WriteLine(myEmployee);
            Console.WriteLine(myEmployee.FirstAndLastName());

            //Let's make an array to hold a bunch of instances of the Employee class
            //We have the new keyword. That means memory allocation.
            //The array is going to be in the Heap.
            Employee[] employees = new Employee[10];

            employees[0] = new Employee("James", "Kirk", 1701.00m);
            employees[1] = new Employee("Jean-Luc", "Picard", 1701.00m);
            employees[2] = new Employee("Benjamin", "Sisko", 587.00m);
            employees[3] = new Employee("Kathryn", "Janeway", 287.00m);
            employees[4] = new Employee("Johnathan", "Archer", 127.00m);


            //Get some input from the user
            int choice = ui.GetUserInput();

            //While the user has chosen something other than 2
            //(Which for us is only 1)
            while (choice != 2)
            {

                //Create a string that can be concated to
                string outputString = "";

                //Print out the employees in the array
                foreach (Employee employee in employees)
                {
                    if (employee != null)
                    {
                        //Concat the employee to the outputString
                        outputString += employee.ToString() +
                            Environment.NewLine;
                    }
                }
                //Output the outputString to the console
                ui.Output(outputString);

                //RE-prompt the user for some new input
                choice = ui.GetUserInput();
            }

        }
    }
}
