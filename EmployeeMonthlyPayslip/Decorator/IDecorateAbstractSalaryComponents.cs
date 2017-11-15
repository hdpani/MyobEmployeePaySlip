using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeMonthlyPayslip.ChainOfResponsiblity;
using EmployeeMonthlyPayslip.Model;

namespace EmployeeMonthlyPayslip.Decorator
{
    public  interface IDecorateAbstractSalaryComponents
    {
        /// <summary>
        /// /// Decorator pattern used to add pay slip calculation to Employee model. Following calculation used to (Open Closed principle in SOLID)
        /// </summary>
        /// <param name="employee"></param>

        void CalculateSalaryComponents(EmployeeModel employee);
  
    }
}
