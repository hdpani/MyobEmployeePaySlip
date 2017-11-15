using EmployeeMonthlyPayslip.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMonthlyPayslip.ChainOfResponsiblity
{

    
    public class TaxSlabThree : TaxSlab
    {
        ///<summary>
        /// Chain of Responsibility Pattern Tax Slab returns Base Tax and Tax unit by matching the slab based on the annual salary.
        ///Taxable income Tax on this income
        ///$37,001 - $80,000 $3,572 plus 32.5c for each $1 over $37,000
        /// </summary>
        
        private int taxSlabThreeRange = 37000;

        public override void ProcessRequest(EmployeeModel employee)
        {
            
            if (employee.AnnualSalary >= 37001 && employee.AnnualSalary <= 80000)
            {
                employee.IncomeTaxUnit = 0.325;
                employee.BaseTax = 3572;
                employee.TaxOverAnnumIncome = employee.AnnualSalary - taxSlabThreeRange;

            }
            else if (successor != null)
            {
                successor.ProcessRequest(employee);
            }
        }
    }
}
