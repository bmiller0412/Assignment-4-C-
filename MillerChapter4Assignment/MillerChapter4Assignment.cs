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
            employeeOne.TotalSales = totalSales;
            Console.WriteLine(employeeOne.ToString());
            Console.ReadKey();
        }
    }
}
