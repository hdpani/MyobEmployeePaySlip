using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeeMonthlyPayslip.ChainOfResponsiblity;
using EmployeeMonthlyPayslip.Decorator;
using EmployeeMonthlyPayslip.Model;

namespace UnitTestEmployeeMonthlyPaySlip
{
    [TestClass]
    public class UnitTestDecaratePayCalculation
    {


        /// <summary>
        /// 
        /// Unit Test covers only Decorator pay calculation for given two scaniro 
        /// 
        ///  Case 1 Ouput unit Test
        ///  Name :David Rudd, Month: 01 March 31 March, Gross: 5004, Tax:922,Net: 4082, Super: 450
        ///  Case 2 Ouput unit Test
        ///  Name :Rayan Chen, Month: 01 March 31 March, Gross: 10000, Tax:2696,Net: 7304, Super: 1000
        /// </summary>

        //Instatiate the Decorator
        IDecorateAbstractSalaryComponents employeePayCalucation = new DecorateAbstractSalaryComponents();



        [TestMethod]
        public void TestEmployee1SalaryComponents()
        {
            EmployeeModel EmployeeObjOne = new EmployeeModel();//"David", "Rudd", 60050, 9, "01 March 31 March");
            EmployeeObjOne.FirstName = "David";
            EmployeeObjOne.LastName = "Rudd";
            EmployeeObjOne.AnnualSalary = 60050;
            EmployeeObjOne.SuperRate = 9;
            EmployeeObjOne.PayMonth = "01 March 31 March";
         

            EmployeeObjOne.BaseTax = 3572;
            EmployeeObjOne.IncomeTaxUnit = 0.325;
            EmployeeObjOne.TaxOverAnnumIncome = 23050;

            employeePayCalucation.CalculateSalaryComponents(EmployeeObjOne);

            Assert.AreEqual(EmployeeObjOne.GrossIncome, 5004);
            Assert.AreEqual(EmployeeObjOne.IncomeTax, 922);
            Assert.AreEqual(EmployeeObjOne.NetIncome, 4082);
            Assert.AreEqual(EmployeeObjOne.Super, 450);
        }

        [TestMethod]
        public void TestEmployee1SalaryComponents1()
        {
            EmployeeModel EmployeeObjTwo = new EmployeeModel();//"Ryan", "Chen", 120000, 10, "01 March 31 March");
            EmployeeObjTwo.FirstName = "Rayan";
            EmployeeObjTwo.LastName = "Chen";
            EmployeeObjTwo.SuperRate = 10;
            EmployeeObjTwo.AnnualSalary = 120000;
            EmployeeObjTwo.PayMonth = "01 March 31 March";

            EmployeeObjTwo.IncomeTaxUnit = 0.37;
            EmployeeObjTwo.BaseTax = 17547;
            EmployeeObjTwo.TaxOverAnnumIncome = 40000;

            employeePayCalucation.CalculateSalaryComponents(EmployeeObjTwo);

            Assert.AreEqual(EmployeeObjTwo.GrossIncome, 10000);
            Assert.AreEqual(EmployeeObjTwo.IncomeTax, 2696);
            Assert.AreEqual(EmployeeObjTwo.NetIncome, 7304);
            Assert.AreEqual(EmployeeObjTwo.Super, 1000);

        }
    }
}
