using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter First Number ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second number ");
            double  num2 = Convert.ToDouble(Console.ReadLine());
            double  num3 = num1 + num2;

            Console.WriteLine(num1+ " + "+ num2 + " = " + num3 );

            Console.ReadLine();

        }
    }
}
