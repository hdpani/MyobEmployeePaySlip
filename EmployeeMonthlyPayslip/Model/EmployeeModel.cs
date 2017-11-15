using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace EmployeeMonthlyPayslip.Model
{
    /// <summary>
    /// EmployeeDTO to object hold the data for employees
    /// Takes employee basic input such as Name and Annual Salary
    /// It get Tax unit from COR abstract class
    /// Input value validation included positive value for Annual salary and Super Rate range 0 to 50
    /// As Retrospective change: using ASP.Net MVC or WEB API project type, Data annotation for validation

    /// </summary>

    public class EmployeeModel
    {
        private string _firstName;
        private string _lastName;
        private double _annualSalary;
        private double _incomeTaxUnit;
        private double _super;
        private double _superRate;
        private double _grossIncome;
        private double _baseTax;
        private double _incomeTax;
        private string _payMonth;

        public string PayMonth
        {
            get { return _payMonth; }
            set { _payMonth = value; }
        }

        public double IncomeTax
        {
            get { return _incomeTax; }
            set { _incomeTax = value; }
        }

        public double BaseTax
        {
            get { return _baseTax; }
            set { _baseTax = value; }
        }

        private double _taxOverAnnumIncome;

        public double TaxOverAnnumIncome
        {
            get { return _taxOverAnnumIncome; }
            set { _taxOverAnnumIncome = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public double AnnualSalary
        {
            get { return _annualSalary; }
            set {
                if (value <= 0 ) throw new ArgumentOutOfRangeException("value",
                  "AnnualSalary must be positive value");
                _annualSalary = value; }
        }

        public double IncomeTaxUnit
        {
            get { return _incomeTaxUnit; }
            set { _incomeTaxUnit = value; }
        }

        public double GrossIncome
        {
            get { return _grossIncome; }
            set { _grossIncome = value; }
        }

        
        private double _netincome;

        public double NetIncome
        {
            get { return _netincome; }
            set { _netincome = value; }
        }

        
        public double SuperRate
        {
            get { return _superRate; }
            set
            {
                if (value <= 0 || value > 51) throw new ArgumentOutOfRangeException("value",
                   "Super must be positive value. Value Range 0 to 50");
                _superRate = value;
            }
        }

        public double Super
        {
            get { return _super; }
            set { _super = value; }
        }


    }
}
