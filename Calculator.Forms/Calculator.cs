using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator.Forms
{
    class Calculator
    {
        double firstValue, secondValue, result;
        string sign;
        public double Add()
        {
            return firstValue + secondValue;
        }
        public double Substract()
        {
            return firstValue - secondValue;
        }
        public double Multiply()
        {
            return firstValue * secondValue;
        }
        public double Divide()
        {
            return firstValue / secondValue;
        }
    }
}
