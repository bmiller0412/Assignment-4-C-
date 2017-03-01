using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MillerChapter4Assignment
{
    //Class Created
    public class Employee
    {
        //Variables Declared
        public decimal Commission { get; set; } = 0.07M;
        public decimal FederalTax { get; set; } = 0.18M;
        public decimal Retirement { get; set; } = 0.10M;
        public decimal SocialSecurity { get; set; } = 0.06M;
        public decimal TotalSales { get; set; }
        public decimal CommissionTotal { get; set; }
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
            return
                string.Format(
                    "Employee: {0} \nTotal Sales: {1} \nCommission: {2} \nFederal Tax: {3} \nRetirement: {4} \nSocial Security: {5} \nTake Home: {6}",
                    EmployeeName, TotalSales, CommissionTotal, FederalTotal, RetireTotal, SocialSecurityTotal);
        }
    }
}
