using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contracts;

namespace Services
{
    public class CalculatorService : ICalculator
    {
        Calculator result = new Calculator();
        public Calculator AddExy(Calculator x, Calculator y)
        {
            result.tp  = x.x1 + y.y1;

            return result;
        }

        public Calculator Divide(Calculator x, Calculator y)
        {
            result.tp = x.x1 -y.y1;

            return result;
        }

        public Calculator Multiply(Calculator x, Calculator y)
        {
            result.tp = x.x1 * y.y1;

            return result;
        }

        public Calculator Subtract(Calculator x, Calculator y)
        {
            result.tp = x.x1 / y.y1;

            return result;
        }
    }
}
