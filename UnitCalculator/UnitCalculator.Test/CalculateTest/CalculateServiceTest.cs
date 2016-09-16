using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitCalculator.BLL.Services;

namespace UnitCalculator.Test.CalculateTest
{
    [TestFixture]
    public class CalculateServiceTest
    {
        [TestCase("Pratya","Suree","Pratya Suree")]
        [TestCase("Edogawa", "Conan", "Edogawa Conan")]
        [TestCase("Minami", "Kotaro", "Minami Kotaro")]
        [TestCase("","","")]
        public void ShouldBeGetFullName(string firstName, string lastName, string expected)
        {
            string actual = string.Empty;

            string fullname = ServiceProviders.CalculatorService.GetFullName(firstName, lastName);

            Assert.That(fullname, Is.EqualTo(expected));
        }
    }
}
