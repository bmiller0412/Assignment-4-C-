using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MillerChapter4Assignment
{
    /// <summary>
    /// Class Created
    /// </summary>
    public class Employee
    {
        //Variables Declared
        public const double Commission = 0.07;
        public const double FederalTax = 0.18;
        public const double Retirement = 0.10;
        public const double SocialSecurity = 0.06;
        public decimal TotalSales { get; set; }
        /// <summary>
        /// => for CommissionTotal means get only
        /// </summary>
        public decimal CommissionTotal => TotalSales * (decimal) Commission;
        public decimal FederalTotal => TotalSales * (decimal) FederalTax;
        public decimal RetireTotal => TotalSales * (decimal) Retirement;
        public decimal SocialSecurityTotal => TotalSales * (decimal) SocialSecurity;
        public decimal MoneyOut => RetireTotal + FederalTotal + SocialSecurityTotal;
        public string EmployeeName { get; set; }

        //Default Constructor
        public Employee()
        {
        }


        //Override string
        public override string ToString()
        {
            StringBuilder stringbuilder = new StringBuilder();
            stringbuilder.AppendLine($"Employee: {EmployeeName}");
            stringbuilder.AppendLine($"Total Sale: {TotalSales}");
            stringbuilder.AppendLine($"Commission: {CommissionTotal}");
            stringbuilder.AppendLine($"Federal Tax: {FederalTotal}");
            stringbuilder.AppendLine($"Retirement: {RetireTotal}");
            stringbuilder.AppendLine($"Social Security: {SocialSecurityTotal}");
            return stringbuilder.ToString();
        }
    }
}
