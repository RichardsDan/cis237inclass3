using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
    interface IEmployee
    {
        // Declare all public methods and properties that must be implemented
        // in child classes
        int GetEmploymentDurationInYears();

        string GetAllEmployeeInformation();

        decimal GetYearlySalary();
    }
}
