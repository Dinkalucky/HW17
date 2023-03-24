using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Calculator calculator = new Calculator();
            int num1, num2;
            while (true)
            {
                Console.WriteLine("Введіть перше число");
                int.TryParse(Console.ReadLine(),out num1);
                Console.WriteLine("Введіть друге число");
                int.TryParse(Console.ReadLine(), out num2);

                Console.WriteLine($"{num1} + {num2} = {calculator.Add(num1,num2)}");
                Console.WriteLine($"{num1} - {num2} = {calculator.Sub(num1, num2)}");
                Console.WriteLine($"{num1} * {num2} = {calculator.Mul(num1, num2)}");
                Console.WriteLine($"{num1} / {num2} = {calculator.Div(num1, num2)}");
            }
        }
    }
}
