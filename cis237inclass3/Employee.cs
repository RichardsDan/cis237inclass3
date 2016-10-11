using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
    // Make this class abstract. This way it can not be instanciated on it's own, but will
    // provide a good base for the other two types of employees.
    abstract class Employee : IEmployee
    {
        // Variables
        protected string _firstName;
        protected string _lastName;
        protected DateTime _startDate;

        // Properties
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public DateTime StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }

        // Methods
        public override string ToString()
        {
            return _firstName + " " + _lastName;
        }

        public int GetEmploymentDurationInYears()
        {
            // Subtract the ticks of the start date from today, and then get the days and divide it by 364
            return new TimeSpan(DateTime.Now.Ticks - this._startDate.Ticks).Days / 365;
        }

        // Take all of the properties for the employee and concat them together.
        public virtual string GetAllEmployeeInformation()
        {
            return this._firstName + " " + this._lastName + " " + this.GetEmploymentDurationInYears();
        }

        // Get the Yearly Salary of the employee
        // Make the method abstract because we want the subclasses to implement it, but 
        // at this level we don't know how to implement it
        public abstract decimal GetYearlySalary();

        //Constructors
        public Employee(string FirstName, string LastName, DateTime StartDate)
        {
            this._firstName = FirstName;
            this._lastName = LastName;
            this._startDate = StartDate;
        }

        public Employee() { }
    }
}
