using System;
using System.Collections.Generic;
using System.Text;

namespace Testy
{
    public class Calculator
    {
        public float add(float a, float b) => a + b;
        public float sub(float a, float b) => a - b;
        public float multi(float a, float b) => a * b;
        public float div(float a, float b)
        {
            try
            {
                return a / b;
            }
            catch (DivideByZeroException)
            {

                throw new Exception("nie dziel przez zero");
            }
        }


    }
}
