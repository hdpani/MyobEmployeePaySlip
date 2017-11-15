using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeMonthlyPayslip;
using EmployeeMonthlyPayslip.Model;

namespace EmployeeMonthlyPayslip.ChainOfResponsiblity
{


    public class TaxSlabOne : TaxSlab
    {
        /// <summary>
        /// Chain of Responsibility Pattern Tax Slab returns Base Tax and Tax unit by matching the slab based on the annual salary.
        ///Taxable income Tax on this income
        ///0 - $18,200 Nil
        /// </summary>

        private int taxSlabOneRange = 0;

        public override void ProcessRequest(EmployeeModel employee)
        {
            
            if (employee.AnnualSalary <= 18200)
            {
                employee.IncomeTaxUnit = 0;
                employee.BaseTax = 0;
                employee.TaxOverAnnumIncome = employee.AnnualSalary - taxSlabOneRange;

            }
            else if(successor !=null)
            {
                successor.ProcessRequest(employee);

            }
        }

        public float SuperRate()
        {
            throw new NotImplementedException();
        }
    }
}
