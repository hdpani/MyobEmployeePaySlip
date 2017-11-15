using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeMonthlyPayslip;
using System.Configuration;
using EmployeeMonthlyPayslip.Model;

namespace EmployeeMonthlyPayslip.ChainOfResponsiblity
{
    /// <summary>
    /// The 'Handler' abstract class to get Matching tax for the annum salary range
    /// Chain of Responsibility Pattern Tax Slab returns Base Tax and Tax unit by matching the slab based on the annual salary.
    ///Taxable income Tax on this income
    ///0 - $18,200 Nil
    ///$18,201 - $37,000 19c for each $1 over $18,200
    ///$37,001 - $80,000 $3,572 plus 32.5c for each $1 over $37,000
    ///$80,001 - $180,000 $17,547 plus 37c for each $1 over $80,000 
    ///$180,001 and over $54,547 plus 45c for each $1 over $180,000
    ///As a Retrospective change this Taxable income tax range can be updated Specification pattern with Generic COR pattern.Which would make this is a generic reusable solution where if required.
    /// </summary>
    public abstract class TaxSlab 
    {
        protected TaxSlab successor;

        

        public void SetSuccessor(TaxSlab successor)
        {
            this.successor = successor;
        }

        //Find the maching chain traverse
        public abstract void ProcessRequest(EmployeeModel employee);

    }
}



