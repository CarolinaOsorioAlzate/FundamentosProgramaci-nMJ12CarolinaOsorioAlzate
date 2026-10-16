using System;

namespace _20.Programación_Modular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear una matriz de n filas por m columnas, que permita ingresar solamente múltiplos de 5 hasta que se llene la matriz.
            Random rnd = new Random();
            int[,] matriz1 = new int[CapturarFilas(), CapturarColumnas()];
            LlenarMatriz(matriz1);
            MostrarMatriz(matriz1);
        }
        static int[,] LlenarMatriz(int[,] matriz1)
        {
            int numero = 0;
            bool bandera = true;
            Random rnd = new Random();
            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                for (int j = 0; j < matriz1.GetLength(1); j++)
                {

                    do
                    {

                        numero = rnd.Next(1, 100);
                        if (numero % 5 == 0)
                        {
                            matriz1[i, j] = numero;
                            bandera = false;
                        }
                    } while (bandera);
                }
            }
            return matriz1;
        }
        static int CapturarFilas()
        {
            Console.WriteLine("Ingrese el número de filas de la matriz.");
            return int.Parse(Console.ReadLine());
        }
        static int CapturarColumnas()
        {
            Console.WriteLine("Ingrese el número de Columnas de la matriz.");
            return int.Parse(Console.ReadLine());
        }
        static void MostrarMatriz(int[,] matriz1)
        {
            Console.WriteLine("La matriz ingresada es:");
            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                for (int j = 0; j < matriz1.GetLength(1); j++)
                {
                    Console.Write($"| {matriz1[(int)i, j]}");
                }
                Console.WriteLine();
            }

        }
    }
}