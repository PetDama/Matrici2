using System;

namespace Matrici2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nr linii:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nr coloane:");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] matrice = new int[n, m];
            int sumar = 0;
            int sumac = 0;

            Console.Write("Elementele matricii :\n");
            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < m; k++)
                {
                    Console.Write($"[{i}],[{k}] : ");
                    matrice[i, k] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write("Randul ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Coloana ");
            int r = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < m; k++)
                    Console.Write(matrice[i, k] + " ");
                Console.Write("\n");
            }


            for (int i = 0; i < n; i++)
            {
                sumac = sumac + matrice[i, r];
            }
            for (int k = 0; k < m; k++)
            {
                sumar = sumar + matrice[c, k];
            }
            Console.WriteLine($"Suma randului {c} este " + sumar);
            Console.WriteLine($"Suma coloanei {r} este " + sumac);
        }
    }

}

