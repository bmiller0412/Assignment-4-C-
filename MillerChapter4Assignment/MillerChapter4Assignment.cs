using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MillerChapter4Assignment
{
    class MillerChapter4Assignment
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter employee name: ");
            string employeeName = Console.ReadLine();
            Console.WriteLine("Total Sales: ");
            decimal totalSales = Convert.ToDecimal(Console.ReadLine());
            Employee employeeOne = new Employee();
            Console.WriteLine("\nAmount on Commission: {0}", employeeOne.CommissionTotal);
            Console.WriteLine("\nFederal Tax: {0}", employeeOne.FederalTotal);
            Console.WriteLine("\nRetirement: {0}", employeeOne.RetireTotal);
            Console.WriteLine("\nSocial Security: {0}", employeeOne.SocialSecurityTotal); 
            Console.WriteLine("\nAmount Taken Out: {0}", employeeOne.MoneyOut);
            Console.ReadKey();
        }
    }
}
