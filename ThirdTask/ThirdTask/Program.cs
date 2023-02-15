using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ThirdTask
{
    class Program
    {
        delegate int Solution(int sol1, int sol2, int sol3);
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            Console.WriteLine("1-ше число: ");
            int sol1 = Convert.ToInt32(Console.ReadLine());

            Console.OutputEncoding = System.Text.Encoding.Default;
            Console.WriteLine("2-ге число: ");
            int sol2 = Convert.ToInt32(Console.ReadLine());

            Console.OutputEncoding = System.Text.Encoding.Default;
            Console.WriteLine("3-тє число: ");
            int sol3 = Convert.ToInt32(Console.ReadLine());

            int calc = 3;
            Solution solution = delegate (int sol1, int sol2, int sol3)
            {
                return (sol1 + sol2 + sol3) / calc;
            };

            double result = solution(sol1, sol2, sol3);
            Console.WriteLine($"Відповідь: {result}");
            Console.ReadKey();
        }
    }
}