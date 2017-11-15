using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeeMonthlyPayslip.ChainOfResponsiblity;
using EmployeeMonthlyPayslip.Decorator;
using EmployeeMonthlyPayslip.Model;

namespace UnitTestEmployeeMonthlyPaySlip
{
    [TestClass]
    public class UnitTestEmployeeDTOModelValidation
    {


        /// <summary>
        /// 
        /// Unit Test covers only employee model data validation for Super and Annual Salary 
        /// 
        ///  Case 1 Ouput unit Test
        ///  Name : Annual Salary in zero or less not accepted
        ///  Case 2 Ouput unit Test
        ///  Name :Super rate is have range creteria between 0 t0 50
        /// </summary>




        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestAnnualSalaryValueException()
        {
            EmployeeModel EmployeeObjOne = new EmployeeModel();//"David", "Rudd", 60050, 9, "01 March 31 March");
            EmployeeObjOne.FirstName = "David";
            EmployeeObjOne.LastName = "Rudd";
            EmployeeObjOne.AnnualSalary = -1;
            EmployeeObjOne.SuperRate = 9;
            EmployeeObjOne.PayMonth = "01 March 31 March";
         
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestSuperValueRangeException()
        {
            EmployeeModel EmployeeObjTwo = new EmployeeModel();//"Ryan", "Chen", 120000, 10, "01 March 31 March");
            EmployeeObjTwo.FirstName = "Rayan";
            EmployeeObjTwo.LastName = "Chen";
            EmployeeObjTwo.SuperRate = 60;
            EmployeeObjTwo.AnnualSalary = 120000;
            EmployeeObjTwo.PayMonth = "01 March 31 March";
           
        }
    }
}
