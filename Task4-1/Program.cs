using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_1
{
    class Program
    {
        // Метод находит квадрат числа, используя для его вычисления следующую формулу: N2=1 + 3 + 5 + ... + (2*N – 1) 
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число N>0");
            int n=Convert.ToInt32(Console.ReadLine());
            for (int i = 1, j = 0; i <= n; i++)
            {
                Console.WriteLine("Квадрат числа {0} равен {1}", i, j += 2 * i - 1);
            }
            Console.ReadKey();
        }
    }
}
