using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha7
{
    class Program
    {
        public static IEnumerable<int[]> Combinations(int n, int m)// метод посчёта комбинаций
        {
            int[] result = new int[m]; // массив в который заносим результат
            Stack<int> stack = new Stack<int>();//контеньер для выкидания элементов повторых и поставноки чисел в верном порядке
            stack.Push(0);// ставим объек в контеньер

            while (stack.Count > 0)
            {
                int index = stack.Count - 1;
                int value = stack.Pop();// удалим из конца контенера 

                while (value < n)
                {
                    result[index++] = ++value;
                    stack.Push(value);

                    if (index == m)
                    {
                        yield return result;// определяем возвращаемый элемент
                        break;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("N = "); a = int.Parse(Console.ReadLine());
            Console.Write("M = "); b = int.Parse(Console.ReadLine());
            foreach (int[] c in Combinations(b, a))
            {
                Console.WriteLine(string.Join(",", c));
                Console.WriteLine();
            }
        }
    }
}
