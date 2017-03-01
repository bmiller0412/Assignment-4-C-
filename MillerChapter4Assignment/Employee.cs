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
        public decimal commission = 0.07M;
        public decimal federalTax = 0.18M;
        public decimal retirement = 0.10M;
        public decimal socialSecurity = 0.06M;
        public decimal totalSales;
        public decimal commissionTotal;
        public decimal federalTotal;
        public decimal retireTotal;
        public decimal socialSecurityTotal;
        public decimal moneyOut;
        public decimal takenPay;
        public string employeeName;

        //Default Constructor
        public Employee()
        {
        }

        //Employee
        public Employee(string Name)
        {
            employeeName = Name;
        }

        public Employee(string employeeNameIn, decimal employeeSalesIn, decimal employeeCommissionIn,
            decimal employeeFederalIn, decimal employeeReitreIn, decimal employeeSocialIn, decimal employeeMoneyIn,
            decimal employeePayIn)
        {
            employeeName = employeeNameIn;
            totalSales = employeeSalesIn;
            commissionTotal = employeeCommissionIn;
            federalTotal = employeeFederalIn;
            socialSecurityTotal = employeeSocialIn;
            moneyOut = employeeMoneyIn;
            takenPay = employeePayIn;
        }

        //Get and Set
        public string EmployeeName
        {
            get
            {
                return employeeName;
            }
            set
            {
                employeeName = value;
            }
        }

        public decimal TotalSales
        {
            get
            {
                return totalSales;
            }
            set
            {
                totalSales = value;
            }
        }

        public decimal CommissionTotal
        {
            get
            {
                return commissionTotal;
            }
            set
            {
                commissionTotal = value;
            }
        }

        public decimal FederalTotal
        {
            get
            {
                return federalTotal;
            }
            set
            {
                federalTotal = value;
            }
        }

        public decimal RetireTotal
        {
            get
            {
                return retireTotal;
            }
            set
            {
                retireTotal = value;
            }
        }

        public decimal SocialSecurityTotal
        {
            get
            {
                return socialSecurityTotal;
            }
            set
            {
                socialSecurityTotal = value;
            }
        }

        public decimal MoneyOut
        {
            get
            {
                return moneyOut;
            }
            set
            {
                moneyOut = value;
            }
        }

        public decimal TakenPay
        {
            get
            {
                return takenPay;
            }
            set
            {
                takenPay = value;
            }
        }
        //Get Total Pay
        public decimal GetCommissionTotal()
        {
            return totalSales * Commission;
        }

        //Federal Taxes
        public decimal GetFederalTaxes()
        {
            return totalSales * FederalTax;
        }

        //Retirement Investments
        public decimal GetRetirement()
        {
            return totalSales * Retirement;
        }

        //Social Security
        public decimal GetSocialSecurity()
        {
            return totalSales * SocialSecurity;
        }

        //Money Taken Out
        public decimal GetMoneyOut()
        {
            return retireTotal + federalTotal + socialSecurityTotal;
        }

        //Take Home Pay
        public decimal GetTakenPay()
        {
            return TotalSales = moneyOut;
        }

        //Override string
        public override string ToString()
        {
            return
                string.Format(
                    "Employee: {0} \nTotal Sales: {1} \nCommission: {2} \nFederal Tax: {3} \nRetirement: {4} \nSocial Security: {5} \nTake Home: {6}",
                    employeeName, totalSales, commissionTotal, federalTotal, retireTotal, socialSecurityTotal);
        }
    }
}
