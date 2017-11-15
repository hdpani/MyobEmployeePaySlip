using EmployeeMonthlyPayslip.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMonthlyPayslip.ChainOfResponsiblity
{

      
    public class TaxSlabFour : TaxSlab
    {
        ///<summary>
        /// Chain of Responsibility Pattern Tax Slab returns Base Tax and Tax unit by matching the slab based on the annual salary.
        ///Taxable income Tax on this income
        ///$80,001 - $180,000 $17,547 plus 37c for each $1 over $80,000 
        /// </summary>

        private int taxSlabFourRange = 80000;

        public override void ProcessRequest(EmployeeModel employee)
        {
            if (employee.AnnualSalary >= 80001 && employee.AnnualSalary <= 180000)
            {
                employee.IncomeTaxUnit = 0.37;
                employee.BaseTax = 17547;
                employee.TaxOverAnnumIncome = employee.AnnualSalary - taxSlabFourRange;

            }
            else if (successor != null)
            {
                successor.ProcessRequest(employee);
            }
        }
    }
}
