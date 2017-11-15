using EmployeeMonthlyPayslip.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMonthlyPayslip.ChainOfResponsiblity
{

    public class TaxSlabFive : TaxSlab
    {
        ///<summary>
        /// Chain of Responsibility Pattern Tax Slab returns Base Tax and Tax unit by matching the slab based on the annual salary.
        ///Taxable income Tax on this income
        ///$180,001 and over $54,547 plus 45c for each $1 over $180,000
        /// </summary>

        private int taxSlabFiveRange = 180000;

        public override void ProcessRequest(EmployeeModel employee)
        {
            if (employee.AnnualSalary > 180001)
            {
                employee.IncomeTaxUnit = 0.45;

                employee.BaseTax = 54547;

                employee.TaxOverAnnumIncome = employee.AnnualSalary - taxSlabFiveRange;


            }
            //else if (successor != null)
            //{
            //    successor.ProcessRequest(employee);
            //}
        }
    }
}
