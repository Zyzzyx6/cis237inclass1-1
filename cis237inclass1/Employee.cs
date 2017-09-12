using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass1
{
    class Employee
    {
        //******************************
        //Variables / Backing Fields
        //******************************
        private string _firstName;
        private string _lastName;
        private decimal _weeklySalary;

        //*****************************
        //Properties
        //*****************************
        public string FirstName
        {
            get { return _firstName; }
        }

        public string LastName
        {
            get { return _lastName; }
        }

        public decimal WeeklySalary
        {
            get { return _weeklySalary; }
        }

        //*******************************
        //Public Methods
        //*******************************
        public override string ToString()
        {
            //Call the method below to get the first and last name
            //and then append it to the weekly salary.
            //Following DRY (Don't repeat yourself)
            return this.FirstAndLastName() + " " + _weeklySalary;
        }

        public string FirstAndLastName()
        {
            return _firstName + " " + _lastName;
        }
        //*******************************
        //Constructors
        //*******************************
        public Employee(string FirstName, string LastName, decimal WeeklySalary)
        {
            this._firstName = FirstName;
            this._lastName = LastName;
            this._weeklySalary = WeeklySalary;
        }

    }
}
