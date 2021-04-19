using System;

namespace Fibonachi_Lite
{
    class Program
    {
        static void Main(string[] args)
        {

            FibonLite();

        }
        static void FibonLite()
        {
            Console.Write("ВВедите число: ");
            int f = Convert.ToInt32(Console.ReadLine());
            f = f + 1;
            int[] fibArra = new int[f];
            fibArra[0] = 0;
            fibArra[1] = 1;
            Console.WriteLine($"Число Фибоначчи: {fibArra[0]}");
            Console.WriteLine($"Число Фибоначчи: {fibArra[1]}");
            for (int i = 2; i < f; i++)
            {
                fibArra[i] = fibArra[i - 2] + fibArra[i - 1];
                Console.WriteLine($"Число Фибоначчи: {fibArra[i]}");
            }
            FibonLite();
        }
    }
}
