using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Program
    {
       

        public delegate int CalculateDelegate(int num1, int num2);
        public static int Addition(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        public static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the num1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the num2");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Menu");
            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Subtraction");
            Console.WriteLine("3.Multiplication");
            Console.WriteLine("4.Division");
            int chk = Convert.ToInt32(Console.ReadLine());
            if (chk == 1)
            {
                CalculateDelegate d1 = new CalculateDelegate(Addition);

                Console.WriteLine("Addition of {0} and {1} is {2}", num1, num2, d1(num1, num2));
            }
            else if (chk == 2)
            {
                CalculateDelegate d1 = new CalculateDelegate(Subtract);
                Console.WriteLine("Subtraction of {0} and {1} is {2}", num1, num2, d1(num1, num2));

            }
            else if (chk == 3)
            {
                CalculateDelegate d1 = new CalculateDelegate(Multiply);
                Console.WriteLine("Multiplication of {0} and {1} is {2}", num1, num2, d1(num1, num2));

            }
            else if (chk == 4)
            {
                CalculateDelegate d1 = new CalculateDelegate(Divide);
                Console.WriteLine("Division of {0} and {1} is {2}", num1, num2, d1(num1, num2));

            }
            Console.Read();
        }
    }
}