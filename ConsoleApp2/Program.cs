using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }

        private static int Square(int c)
        {
            return c * c;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Введите первое число для сложения:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число для сложения:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            int sum = Sum(firstNumber, secondNumber);
            Console.WriteLine($"Сумма {firstNumber} и {secondNumber} равна: {sum}");

            Console.WriteLine("Введите число для вычисления квадрата:");
            int Squarenumb = Convert.ToInt32(Console.ReadLine());

            int square = Square(Squarenumb);
            Console.WriteLine($"Квадрат числа {Squarenumb} равен: {square}");
            Console.ReadLine();
        }
    }
}
