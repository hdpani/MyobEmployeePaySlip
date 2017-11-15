using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeMonthlyPayslip.ChainOfResponsiblity;
using EmployeeMonthlyPayslip.Decorator;
using EmployeeMonthlyPayslip.Model;

namespace EmployeeMonthlyPayslip
{
    class MainProgramToExecutePayCalculation
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            TaxSlab taxSlabOne = new TaxSlabOne();
            TaxSlab taxSlabTwo = new TaxSlabTwo();
            TaxSlab taxSlabThree = new TaxSlabThree();
            TaxSlab taxSlabFour = new TaxSlabFour();
            TaxSlab taxSlabFive = new TaxSlabFive();

            IDecorateAbstractSalaryComponents employeePayCalucation = new DecorateAbstractSalaryComponents();

            taxSlabOne.SetSuccessor(taxSlabTwo);
            taxSlabTwo.SetSuccessor(taxSlabThree);
            taxSlabThree.SetSuccessor(taxSlabFour);
            taxSlabFour.SetSuccessor(taxSlabFive);


            EmployeeModel slabOneEmployee = new EmployeeModel();// "David", "Rudd", 60050, 9, "01 March 31 March");
            slabOneEmployee.FirstName = "David";
            slabOneEmployee.LastName = "Rudd";
            slabOneEmployee.AnnualSalary = 60050;
            slabOneEmployee.SuperRate =9;
            slabOneEmployee.PayMonth = "01 March 31 March";

            taxSlabOne.ProcessRequest(slabOneEmployee);

            //Console.WriteLine("Tax Slab Tax Unit per $ {0} , Tax Slab Base Tax $ {1} , Tax over Annum {2}", slabOneEmployee.IncomeTaxUnit, slabOneEmployee.BaseTax,slabOneEmployee.TaxOverAnnumIncome);

            employeePayCalucation.CalculateSalaryComponents(slabOneEmployee);

            Console.WriteLine(" Name :{0}, Month: {1}, Gross: {2}, Tax:{3},Net: {4}, Super: {5}", slabOneEmployee.FirstName + " " + slabOneEmployee.LastName, slabOneEmployee.PayMonth, slabOneEmployee.GrossIncome, slabOneEmployee.IncomeTax, slabOneEmployee.NetIncome, slabOneEmployee.Super);




            EmployeeModel slabTwoEmployee = new EmployeeModel();// "Ryan", "Chen", 120000, 10, "01 March 31 March");
            slabTwoEmployee.FirstName = "Rayan";
            slabTwoEmployee.LastName = "Chen";
            slabTwoEmployee.SuperRate = 10;
            slabTwoEmployee.AnnualSalary = 120000;
            slabTwoEmployee.PayMonth = "01 March 31 March";
            

            taxSlabOne.ProcessRequest(slabTwoEmployee);
           // Console.WriteLine("Tax Slab Tax Unit per $ {0} , Tax Slab Base Tax $ {1} , Tax over Annum {2}", slabTwoEmployee.IncomeTaxUnit, slabTwoEmployee.BaseTax, slabTwoEmployee.TaxOverAnnumIncome);

            employeePayCalucation.CalculateSalaryComponents(slabTwoEmployee);

            Console.WriteLine(" Name :{0}, Month: {1}, Gross: {2}, Tax:{3},Net: {4}, Super: {5}", slabTwoEmployee.FirstName + " " + slabTwoEmployee.LastName, slabTwoEmployee.PayMonth, slabTwoEmployee.GrossIncome, slabTwoEmployee.IncomeTax, slabTwoEmployee.NetIncome, slabTwoEmployee.Super);


            Console.ReadLine();
                



        }
    }
}
