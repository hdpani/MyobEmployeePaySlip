using EmployeeMonthlyPayslip.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMonthlyPayslip.ChainOfResponsiblity
 { 
    public class TaxSlabTwo : TaxSlab
    {
        ///<summary>
        /// Chain of Responsibility Pattern Tax Slab returns Base Tax and Tax unit by matching the slab based on the annual salary.
        ///Taxable income Tax on this income
        ///$18,201 - $37,000 19c for each $1 over $18,200
        /// </summary>
        
        private int taxSlabTwoRange = 18200;

        public override void ProcessRequest(EmployeeModel employee)
        {
            if (employee.AnnualSalary >= 18201 && employee.AnnualSalary <= 37000)
            {
                employee.IncomeTaxUnit = 0.19;
                employee.BaseTax = 0;
                employee.TaxOverAnnumIncome = employee.AnnualSalary - taxSlabTwoRange;

                
            }
            else if (successor != null)
            {
                successor.ProcessRequest(employee);
            }
        }
    }
}
