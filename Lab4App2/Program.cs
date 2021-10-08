using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4App2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Осуществить ввод последовательности целых чисел и сравнить, что больше, количество положительных или количество отрицательных.
            // Последовательность потенциально не ограничена, окончанием последовательности служит число 0.
            Console.WriteLine("Введите число N:");
            int p = 0; //положительные
            int o = 0; //отрицательные
            int n = 0;
            do
            {
                n = Convert.ToInt32(Console.ReadLine());
                if (n > 0)
                {
                    p = p + 1;
                }
                else if (n < 0)
                {
                    o = o + 1;
                }
                else
                {
                    Console.WriteLine("Ввод окончен");
                }
            } while (n != 0);

            Console.WriteLine($"Положительные числа={p}\tОтрицательные числа={o}");
            if (p > o)
            {
                Console.WriteLine($"Положительные числа={p}>{o}=Отрицательные числа");
            }
            else if (p < o)
            {
                Console.WriteLine($"Положительные числа={p}<{o}=Отрицательные числа");
            }
            else
            {
                Console.WriteLine($"Количество равно:\nПоложительные числа:{p}=Отрицательные числа:{o}");
            }
            Console.ReadKey();
        }
    }
}
