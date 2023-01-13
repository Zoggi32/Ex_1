using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("The first number is greater than the second");
            }
            else if (num1 < num2)
            {
                Console.WriteLine("The first number is less than the second");
            }
            else
            {
                Console.WriteLine("Both numbers are equal");
            }
            Console.ReadKey();
        }
    }
}