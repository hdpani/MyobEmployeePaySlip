using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeeMonthlyPayslip.ChainOfResponsiblity;
using EmployeeMonthlyPayslip.Decorator;
using EmployeeMonthlyPayslip.Model;

namespace UnitTestEmployeeMonthlyPaySlip
{
    [TestClass]
    public class UnitTestTaxSlabCOR
    {

        /// <summary>
        /// 
        /// Unit Test covers Chain of responsiblity to match get the tax slab based on the tax range given 
        /// 
        ///  Case 1 Ouput unit Test
        ///  Tax Slab Tax Unit per $ 0.325 , Tax Slab Base Tax $ 3572 , Tax over Annum 23050
        ///  Case 2 Ouput unit Test
        ///  Tax Slab Tax Unit per $ 0.37 , Tax Slab Base Tax $ 17547 , Tax over Annum 40000
        /// </summary>

        //Intitiate Chain of responsiblity 
        TaxSlab taxSlabOne = new TaxSlabOne();
        TaxSlab taxSlabTwo = new TaxSlabTwo();
        TaxSlab taxSlabThree = new TaxSlabThree();
        TaxSlab taxSlabFour = new TaxSlabFour();
        TaxSlab taxSlabFive = new TaxSlabFive();

     
        [TestMethod]
        public void TestEmployee1TaxSlab()
        {
            //Join the chains to traverse
            taxSlabOne.SetSuccessor(taxSlabTwo);
            taxSlabTwo.SetSuccessor(taxSlabThree);
            taxSlabThree.SetSuccessor(taxSlabFour);
            taxSlabFour.SetSuccessor(taxSlabFive);

            EmployeeModel EmployeeObjOne = new EmployeeModel();//"David", "Rudd", 60050, 9, "01 March 31 March");
            EmployeeObjOne.FirstName = "David";
            EmployeeObjOne.LastName = "Rudd";
            EmployeeObjOne.AnnualSalary = 60050;
            EmployeeObjOne.SuperRate = 9;
            EmployeeObjOne.PayMonth = "01 March 31 March";

            taxSlabOne.ProcessRequest(EmployeeObjOne);


            Assert.AreEqual(EmployeeObjOne.BaseTax, 3572);
            Assert.AreEqual(EmployeeObjOne.IncomeTaxUnit, 0.325);
            Assert.AreEqual(EmployeeObjOne.TaxOverAnnumIncome, 23050);
 
        }

        [TestMethod]
        public void TestEmployee2TaxSlab()
        {

            //Join the chains to traverse
            taxSlabOne.SetSuccessor(taxSlabTwo);
            taxSlabTwo.SetSuccessor(taxSlabThree);
            taxSlabThree.SetSuccessor(taxSlabFour);
            taxSlabFour.SetSuccessor(taxSlabFive);

            EmployeeModel EmployeeObjTwo = new EmployeeModel();//"Ryan", "Chen", 120000, 10, "01 March 31 March");
            EmployeeObjTwo.FirstName = "Rayan";
            EmployeeObjTwo.LastName = "Chen";
            EmployeeObjTwo.SuperRate = 10;
            EmployeeObjTwo.AnnualSalary = 120000;
            EmployeeObjTwo.PayMonth = "01 March 31 March";


            taxSlabOne.ProcessRequest(EmployeeObjTwo);

            Assert.AreEqual(EmployeeObjTwo.BaseTax, 17547);
            Assert.AreEqual(EmployeeObjTwo.IncomeTaxUnit, 0.37);
            Assert.AreEqual(EmployeeObjTwo.TaxOverAnnumIncome, 40000);

        }


    }
}
