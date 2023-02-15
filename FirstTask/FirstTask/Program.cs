using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FirstTask
{
    class Program
    {
        public delegate int solution(int x, int y);
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            Console.WriteLine("Введіть дiю: ");
            string solution = Console.ReadLine();
            Console.WriteLine("Введiть 1-ше число: ");
            int sol1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введiть 2-ге число: ");
            int sol2 = Convert.ToInt32(Console.ReadLine());
            switch (solution)
            {
                case "+":
                    solution solution1 = Add;
                    int Add(int a, int b) => a + b;
                    Console.WriteLine($"Відповідь: {solution1(sol1, sol2)}");
                    break;

                case "-":
                    solution solution2 = Sub;
                    int Sub(int a, int b) => a - b;
                    Console.WriteLine($"Відповідь: {solution2(sol1, sol2)}");
                    break;

                case "*":
                    solution solution3 = Mul;
                    int Mul(int a, int b) => a * b;
                    Console.WriteLine($"Відповідь: {solution3(sol1, sol2)}");
                    break;

                case "/":
                    solution solution4 = Div;
                    int Div(int a, int b) => b == 0 ? 0 : a / b;
                    Console.WriteLine($"Відповідь: {solution4(sol1, sol2)}");
                    break;

                default:
                    Console.WriteLine("Виникла помилка! Спробуйте ще раз!");
                    break;
            }
            Console.ReadKey();
        }
    }
}