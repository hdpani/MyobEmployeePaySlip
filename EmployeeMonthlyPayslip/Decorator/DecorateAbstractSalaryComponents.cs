using EmployeeMonthlyPayslip.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMonthlyPayslip.Decorator
{
    public class DecorateAbstractSalaryComponents : IDecorateAbstractSalaryComponents
    {
        /// <summary>
        /// Decorator pattern used to add pay slip calculation to Employee model. Following calculation used to (Open Closed principle in SOLID)
        ////• Pay period = per calendar month 
        ////• gross income = annual salary / 12 months 
        ////• income tax = based on the tax table provide below 
        ////• net income = gross income - income tax 
        ////• super = gross income x super rate
        /// </summary>
        /// <param name="employee"></param>

        void IDecorateAbstractSalaryComponents.CalculateSalaryComponents(EmployeeModel employee)
        {
           
                //Annual salary divide by 12 get Gross income
                //round down

                employee.GrossIncome = Math.Floor(employee.AnnualSalary / 12);

                //Tax caluclation base fixed value for the range plus unit for each doller
                //round up
                employee.IncomeTax = Math.Ceiling(((employee.IncomeTaxUnit * employee.TaxOverAnnumIncome) + employee.BaseTax) / 12);

                //Gross Income - IncomeTax
                employee.NetIncome = employee.GrossIncome - employee.IncomeTax;

                //Gross Income Multiples of Super 
                //round down
                employee.Super = Math.Floor(employee.GrossIncome / 100 * employee.SuperRate);
            
        }
    }
}
