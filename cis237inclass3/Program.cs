using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
    class Program
    {
        static void Main(string[] args)
        {
            SalaryEmployee sEmployee = new SalaryEmployee("Matt", "Murdoch", new DateTime(2014, 10, 31), 537.36m);
            SalaryEmployee sEmployee2 = new SalaryEmployee();
            Console.WriteLine(sEmployee.ToString());
            Console.WriteLine(sEmployee2.ToString());

            HourlyEmployee hEmployee = new HourlyEmployee("Jessica", "Jones", new DateTime(2013, 10, 01), 12.43m, 36m);
            Console.WriteLine(hEmployee.ToString());
            Console.WriteLine(hEmployee.GetYearlySalary());
            Console.WriteLine(hEmployee.GetAllEmployeeInformation());

            // Declare a new collection
            IEmployeeCollection employeeCollection;
            // Instantiate the collection with the concrete class even though it is going into 
            // an interface container
            employeeCollection = new EmployeeCollection();
            // Call the method below to add the employees to the collection
            AddNewEmployees(employeeCollection);

            PrintEmployees(employeeCollection);
            
        }

        static void AddNewEmployees(IEmployeeCollection employeeCollection)
        {
            // Add a couple of Salary Employees
            employeeCollection.add("Matt", "Murdoch", new DateTime(2016, 4, 4), 549m);
            employeeCollection.add("Jessica", "Jones", new DateTime(2016, 5, 14), 609m);
            // Add a couple of Hourly Employees
            employeeCollection.add("Luke", "Cage", new DateTime(2016, 4, 4), 49m, 40);
            employeeCollection.add("Barry", "Allen", new DateTime(2016, 4, 4), 54m, 20);
        }

        static void PrintEmployees(IEmployeeCollection employeeCollection)
        {
            Console.WriteLine();
            Console.WriteLine(employeeCollection.GetPrintString());
        }
    }
}
