//DiegoAlbertoMitaChungara
using System.Data.Common;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz;
            int[] sumaFilas;
            int[] sumaColumnas;
            int fils, col;

            Inicializa(out matriz, out sumaFilas, out sumaColumnas, out fils, out col);
            Sumador(matriz, sumaFilas, sumaColumnas, fils, col);

            Console.WriteLine("La suma de las filas de la matriz son: " +sumaFilas[0]+ " " + sumaFilas[1]);
            Console.Write("La suma de las columnas de la matriz son: " + sumaColumnas[0]+ " " + sumaColumnas[1]);
        }
        static void Inicializa(out int[,] matriz, out int[]sumaFilas, out int[] sumaColumnas, out int fils, out int col)
        {
            matriz = new int[2, 3];
            sumaColumnas = new int[3];
            sumaFilas = new int[2];

            matriz[0, 0] = new Random().Next(0,10);
            matriz[0, 1] = new Random().Next(0, 10);
            matriz[0, 2] = new Random().Next(0, 10);
            matriz[1, 0] = new Random().Next(0, 10);
            matriz[1,1] = new Random().Next(0, 10);
            matriz[1, 2] = new Random().Next(0, 10);

            fils = matriz.GetLength(0);
            col = matriz.GetLength(1);
        }
        static void Sumador(int[,]matriz, int[]sumaFilas, int[]sumaColumnas, int fils, int col)
        {
            for (int i = 0; i < fils; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    sumaFilas[i] += matriz[i, j];
                }
            }
            for (int i = 0; i < fils; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    sumaColumnas[j] += matriz[i, j];
                }
            }
        }
    }
}