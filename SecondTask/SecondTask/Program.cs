using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SecondTask
{
    class Program
    {
        delegate int Solution();
        delegate double MySol(Solution[] components);
        static int GetRandom()
        {
            Random random = new Random();
            int number = random.Next(1, 25);
            Console.WriteLine(number);
            return number;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Кiлькiсть елементiв масива: ");
            Console.OutputEncoding = System.Text.Encoding.Default;
            int count = Convert.ToInt32(Console.ReadLine());
            MySol mysol = delegate (Solution[] components)
            {
                int arithmetic = 0;
                for (int i = 0; i < components.Length; i++)
                {
                    arithmetic += components[i]();
                }
                return arithmetic / components.Length;
            };
            Solution[] components = new Solution[count];
            for (int i = 0; i < components.Length; i++)
            {
                components[i] = () => new Solution(GetRandom)();
            }
            Console.WriteLine($"Середнє арифметичне чисел: {mysol(components)}");
            Console.ReadKey();
        }
    }
}