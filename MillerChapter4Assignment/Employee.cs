using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MillerChapter4Assignment
{
    //Class Created
    public class Employee
    {
        //Variables Declared
        public decimal Commission = 0.07M;
        public decimal FederalTax = 0.18M;
        public decimal Retirement = 0.10M;
        public decimal SocialSecurity = 0.06M;
        public decimal TotalSales;
        public decimal CommissionTotal;
        public decimal FederalTotal;
        public decimal RetireTotal;
        public decimal SocialSecurityTotal;
        public decimal MoneyOut;
        public decimal TakenPay;
        public string EmployeeName;

        //Default Constructor
        public Employee()
        {
        }

        //Employee
        public Employee(string Name)
        {
            EmployeeName = Name;
        }

        public Employee(string employeeNameIn, decimal employeeSalesIn, decimal employeeCommissionIn,
            decimal employeeFederalIn, decimal employeeReitreIn, decimal employeeSocialIn, decimal employeeMoneyIn,
            decimal employeePayIn)
        {
            EmployeeName = employeeNameIn;
            TotalSales = employeeSalesIn;
            CommissionTotal = employeeCommissionIn;
            FederalTotal = employeeFederalIn;
            SocialSecurityTotal = employeeSocialIn;
            MoneyOut = employeeMoneyIn;
            TakenPay = employeePayIn;
        }

        
        //Get Total Pay
        public decimal GetCommissionTotal()
        {
            return TotalSales * Commission;
        }

        //Federal Taxes
        public decimal GetFederalTaxes()
        {
            return TotalSales * FederalTax;
        }

        //Retirement Investments
        public decimal GetRetirement()
        {
            return TotalSales * Retirement;
        }

        //Social Security
        public decimal GetSocialSecurity()
        {
            return TotalSales * SocialSecurity;
        }

        //Money Taken Out
        public decimal GetMoneyOut()
        {
            return RetireTotal + FederalTotal + SocialSecurityTotal;
        }

        //Take Home Pay
        public decimal GetTakenPay()
        {
            return TotalSales = MoneyOut;
        }

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
