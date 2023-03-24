using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17._5
{
    public class Calculator
    {
        public dynamic Add(dynamic num1, dynamic num2)
        {
            return num1 + num2;
        }
        public dynamic Sub(dynamic num1, dynamic num2)
        {
            return num1 - num2;
        }
        public dynamic Mul(dynamic num1, dynamic num2)
        {
            return num1 * num2;
        }
        public dynamic Div(dynamic num1, dynamic num2)
        {
            try
            {
                return num1 / num2;
            }
            catch (Exception e)
            {
                Console.WriteLine("Ділення на 0 неможливе");
            }

            return "Error";
        }
    }
}
