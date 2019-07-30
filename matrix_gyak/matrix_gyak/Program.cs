using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix_gyak
{
    class Program
    {
        static void Main(string[] args)
        {
            const int m = 6;
            const int n = 6;
            int[,] matrix = new int[m, n];
            Random rnd = new Random();

            //feltöltjük a mártixot adatokkal for-ciklust használva
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rnd.Next(99) + 1;
                }
            }
            //itt elkezdjük a mátrix kiíratását
            Console.WriteLine("Az eredeti mátrix: ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.SetCursorPosition(i * 3, 5 + (j * 2));
                    Console.Write(matrix[i, j]);
                }
            }
            //kiíratás után tükrözzük a mátrixot
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int cs = matrix[i, j];
                    matrix[i, j] = matrix[j, i];
                    matrix[j, i] = cs;
                }
            }
            //A tükrözött mátrix kiíratása
            Console.SetCursorPosition(40, 0);
            Console.Write("Tükrözött mátrix: ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.SetCursorPosition(40 + (i * 3), 5 + (j * 2));
                    Console.Write(matrix[i, j]);
                }
            }
            Console.ReadLine();
        }
    }
}
