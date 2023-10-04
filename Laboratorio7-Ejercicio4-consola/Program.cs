using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio7_Ejercicio4_consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa un numero: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int num2 = num1 * 4;
            int i = 0;
            do
            {
                for (int i2 = 0; i2 < num2; i2++)
                {
                    Console.Write("*");
                    i2++;
                }
                Console.WriteLine();
                i++;
            } while (i < num1);

            Console.WriteLine();
            Console.Write("Ingresa un numero: ");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int num4 = num3 * 4;
            int i3 = 0;
            do
            {
                for (int i4 = 0; i4 < num4; i4++)
                {
                    Console.Write("*");
                    i4++;
                }
                Console.WriteLine();
                i3++;
            } while (i3 < num3);

            Console.WriteLine();
            Console.Write("Ingresa un numero: ");
            int num5 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int num6 = num5 * 4;
            int i5 = 0;
            do
            {
                for (int i6 = 0; i6 < num6; i6++)
                {
                    Console.Write("*");
                    i6++;
                }
                Console.WriteLine();
                i5++;
            } while (i5 < num5);

            Console.ReadKey();
        }
    }
}
