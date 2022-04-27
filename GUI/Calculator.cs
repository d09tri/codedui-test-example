using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class Calculator
    {
        public float Num1 { get; set; }
        public float Num2 { get; set; }

        public Calculator() { }

        public Calculator(float num1, float num2)
        {
            this.Num1 = num1;
            this.Num2 = num2;
        }

        public float Addition()
        {
            return Num1 + Num2;
        }

        public float Subtraction()
        {
            return Num1 - Num2;
        }

        public float Multiplication()
        {
            return Num1 * Num2;
        }

        public float Division()
        {
            if (Num2 == 0)
                return float.MaxValue;
            else
                return Num1 / Num2;
        }
    }
}
