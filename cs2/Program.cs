//Задано n троек целых чисел (ai,bi,ci).Определить, сколько троек может быть использовано для построения треугольника со сторонами a_i, b_i, c_i.

using System;

namespace Triangle
{
    public class TriangleCalculator
    {
        public int Count(int[] a, int[] b, int[] c, int n)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] + b[i] > c[i] && a[i] + c[i] > b[i] && b[i] + c[i] > a[i])
                {
                    count++;
                }
            }
            return count;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //взаимодействие с юзеоом
            Console.WriteLine("Введите переменную n (количество троек чисел):");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[n];
            int[] b = new int[n];
            int[] c = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите три числа для тройки {i + 1} через Enter:");
                a[i] = Convert.ToInt32(Console.ReadLine());
                b[i] = Convert.ToInt32(Console.ReadLine());
                c[i] = Convert.ToInt32(Console.ReadLine());
            }


            // логика тут
            TriangleCalculator calculator = new TriangleCalculator();

            int count = calculator.Count(a, b, c, n);

            string outMessage = $"Количество троек, из которых можно сделать треугольник: {count}";

            //вывод
            Console.WriteLine(outMessage);
        }
    }
}