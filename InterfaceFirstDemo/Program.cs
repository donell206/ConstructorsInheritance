using InterfaceFirstDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculate calculate = new ICalculate();

            int result;
            result = calculate.Add(26, 54);
            Console.WriteLine(result);

            result = calculate.Div(26, 54);
            Console.WriteLine(result);

            result = calculate.Sub(26, 54);
            Console.WriteLine(result);

            result = calculate.Div(26, 54);

            Console.WriteLine(result);
        }
    }
}
