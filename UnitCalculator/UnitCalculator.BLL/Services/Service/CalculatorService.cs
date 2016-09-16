using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitCalculator.BLL.Services.Service
{
    public class CalculatorService
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Sub(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Mul(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Div(int num1, int num2)
        {
            return num1 / num2;
        }

        public string GetFullName(string firstName, string lastName)
        {
            string getFullName = string.Empty;
            if(!string.IsNullOrWhiteSpace(firstName) && !string.IsNullOrWhiteSpace(lastName))
            {
                getFullName = firstName + " " + lastName;
            }
            else
            {
                getFullName = "";
            }
            return getFullName;
        }
    }
}
