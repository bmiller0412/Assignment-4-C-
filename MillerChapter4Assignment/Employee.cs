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
        public decimal FederalTotal { get; set; }
        public decimal RetireTotal { get; set; }
        public decimal SocialSecurityTotal { get; set; }
        public decimal MoneyOut { get; set; }
        public decimal TakenPay { get; set; }
        public string EmployeeName { get; set; }

        //Default Constructor
        public Employee()
        {
        }

        //Get Total Pay
        public decimal GetCommissionTotal() => TotalSales * (decimal) Commission;
       
        //Federal Taxes
        public decimal GetFederalTaxes() => TotalSales * (decimal)FederalTax;

        //Retirement Investments
        public decimal GetRetirement() => TotalSales * (decimal) Retirement;

        //Social Security
        public decimal GetSocialSecurity() => TotalSales * (decimal)SocialSecurity;

        //Money Taken Out
        public decimal GetMoneyOut() => RetireTotal + FederalTotal + SocialSecurityTotal;

        //Take Home Pay
        public decimal GetTakenPay() => TotalSales = MoneyOut;
        //Override string
        public override string ToString()
        {
            StringBuilder stringbuilder = new StringBuilder();
            stringbuilder.AppendLine($"Employee: {EmployeeName}");
            stringbuilder.AppendLine($"Total Sale: {TotalSales}");
            stringbuilder.AppendLine($"")
            return
                string.Format(
                    "Employee: {0} \nTotal Sales: {1} \nCommission: {2} \nFederal Tax: {3} \nRetirement: {4} \nSocial Security: {5} \nTake Home: {6}",
                    EmployeeName, TotalSales, CommissionTotal, FederalTotal, RetireTotal, SocialSecurityTotal);
        }
    }
}
