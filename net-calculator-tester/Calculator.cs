﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_calculator_tester
{
    public static class Calculator
    {
        public static float Add(float num1, float num2)
        {
            return num1 + num2;
        }
        public static float Substract(float num1, float num2)
        {
            return num1 - num2;
        }
        public static float Divide(float num1, float num2)
        {
            return num1 / num2;
        }
        public static float Multiply(float num1, float num2)
        {
            return num1 * num2;
        }
    }
}
