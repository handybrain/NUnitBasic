using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitCalculator.BLL.Services;

namespace UnitCalculator
{
    public class Program
    {
        protected static void Main(string[] args)
        {
            PreparePrintName();
            //PrepareAdd(5, 3);
            Console.ReadKey();
        }

        protected static void PreparePrintName()
        {
            string firstName = string.Empty;
            string lastName = string.Empty;
            string fullName = string.Empty;

            Console.WriteLine("Hello Sir !!!, What's Your Name ? ");
            Console.Write("First Name : ");
            firstName = Console.ReadLine();
            Console.Write("Last Name : ");
            lastName = Console.ReadLine();

            fullName = ServiceProviders.CalculatorService.GetFullName(firstName, lastName);
            Console.Write("\n");
            Console.WriteLine("Hello " + fullName);
            Console.Write("\n");
        }

        protected static void PrepareAdd(int num1, int num2)
        {
            int sum = ServiceProviders.CalculatorService.Add(num1, num2);
            Console.WriteLine(string.Format("Summary of {0} and {1} is {2}", num1 + "", num2 + "", sum));
           
        }
    }
}
