using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace cis237inclass1
{
    class CsvProcessor
    {
        //No Variables or properties
        //No Constructor. Default is fime


        public bool ImportCsv(string pathToCsvFile, Employee[] employees)
        {
            //Declare the streamreader
            StreamReader streamReader = null;


            try
            {
                // Declare a string to hold the line
                string line;

                //instanciate the stream reader
                streamReader = new StreamReader(pathToCsvFile);

                int counter = 0;

                while((line = streamReader.ReadLine()) != null)
                    {

                    //Process the line
                    processLine(line, employees, counter++);

                    }
                //Read through the whole file so we can return true.
                return true;

            }
            catch(Exception ex)
            {
                //Output the exception and the stacktrace
                Console.WriteLine(ex.ToString());
                Console.WriteLine();
                Console.WriteLine(ex.StackTrace);

                //Return false since it did not succeed
                return false;

            }
            finally
            {
                //Finally block will always be executed no matter what

                //If the stream reader was instanciated make sure it
                //is closed before exiting the reader
                if(streamReader != null)
                {
                    streamReader.Close();
                }
                
            }

        }

        private void processLine(string line, Employee[] employees, int index)
        {

            //Declare array of parts that will return the result
            //of splitting the read in string
            string[] parts = line.Split(',');

            //Assign each part to variable
            string firstName = parts[0];
            string lastName = parts[1];
            decimal salary = Decimal.Parse(parts[2]);

            //Add a new employee into the array that was passed  in
            employees[index] = new Employee(firstName, lastName, salary);

        

        }



    }
}
