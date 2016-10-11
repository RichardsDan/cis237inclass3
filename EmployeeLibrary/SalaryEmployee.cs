using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class SalaryEmployee : Employee
    {
        // Variables
        private decimal _weeklySalary;

        // Properties
        public decimal WeeklySalary
        {
            get { return _weeklySalary; }
            set { _weeklySalary = value; }
        }

        // Methods
        public string NameAndSalary()
        {
            return base.ToString() + " " + _weeklySalary.ToString("C");
        }

        // Override the ToString method that is in the parent class Employee
        public override string ToString()
        {
            // Take the string the Parent's ToString method will return, and concat the weeklySalary to it.
            return base.ToString() + " " + this._weeklySalary;
        }

        public override string GetAllEmployeeInformation()
        {
            return base.GetAllEmployeeInformation() + " " + this._weeklySalary;
        }

        // Override the abstract method in the Employee class. Because the Employee class declares the
        // method as abstract, this class MUST implement it.
        public override decimal GetYearlySalary()
        {
            return this._weeklySalary * 52;
        }

        // Constructor
        public SalaryEmployee(string firstName, string lastName, 
            DateTime startDate, decimal weeklySalary) 
            // Calls base constructor
            : base(firstName, lastName, startDate)
        {
            _weeklySalary = weeklySalary;
        }

        public SalaryEmployee() : base()
        {

        }
    }
}
