using System;
namespace Tashoglo42base
{
    class Program
    {
        static void Main()
        {
            int r = 0, N = 0, c = 0, M = 0, s = 0;
            Console.Write("Число строк N:");
            N = Convert.ToInt32(Console.ReadLine());
            Console.Write("Число столбцов M:");
            M = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int[,] n = new int[N, M];
            Random rnd = new Random();
            for (r = 0; r < N; r++)
            {
                for (c = 0; c < M; c++)
                {
                    int Mm = rnd.Next(0, 10);
                    n[r, c] = Mm;
                    s += n[1, c];
                }
            }
            for (r = 0; r < N; r++)
            {
                for (c = 0; c < M; c++)
                {
                    Console.Write(n[r, c].ToString("D2") + " ");

                }

                Console.WriteLine();
            }          
            Console.Write("Сумма 2 строки=");
            Console.WriteLine(s.ToString());                 
        }
    }
}