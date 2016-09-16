using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitCalculator.BLL.Services.Service;

namespace UnitCalculator.BLL.Services
{
    public static class ServiceProviders
    {
        private static CalculatorService _CalculatorService;
        public static CalculatorService CalculatorService
        {
            get
            {
                if (_CalculatorService == null)
                {
                    _CalculatorService = new CalculatorService();
                }
                return _CalculatorService;
            }
        }
    }
}
