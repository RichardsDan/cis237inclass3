using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class HourlyEmployee : Employee
    {
        // Variables
        private decimal _hourlyRate;
        private decimal _hoursPerWeek;

        // Properties
        // Properties don't have to be direct relationship to a single variable.
        // Here I am using 2 variables to get the value of a single property.
        public decimal WeeklySalary
        {
            get { return this._hourlyRate * this._hoursPerWeek; }
        }

        // Methods
        public override string ToString()
        {
            // Use the weekly salary property declared above to make up this ToString.
            // This way it will return the same string as SalaryEmployee even though
            // this employee is hourly.
            return base.ToString() +" " + this.WeeklySalary;
        }

        public override decimal GetYearlySalary()
        {
            return this.WeeklySalary * 52;
        }

        public override string GetAllEmployeeInformation()
        {
            return base.GetAllEmployeeInformation() + " " + this.WeeklySalary;
        }

        // Constructors
        public HourlyEmployee(string firstName, string lastName, DateTime startDate, 
            decimal hourlyRate, decimal hoursPerWeek)
            : base(firstName, lastName, startDate)
        {
            this._hourlyRate = hourlyRate;
            this._hoursPerWeek = hoursPerWeek;
        }
    }
}
