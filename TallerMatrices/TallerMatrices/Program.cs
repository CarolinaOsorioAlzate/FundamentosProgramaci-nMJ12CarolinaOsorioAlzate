using System;
using System.Diagnostics.CodeAnalysis;
using System.Security.Policy;

namespace TallerMatrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Desarrollar un programa que crea una matriz de 10 filas y 20 columnas y muestre por pantalla la suma de los elementos de cada columna.
            /*int[,] matris = new int[10,20];
            Random rnd = new Random();
            

            for (int i = 0; i < matris.GetLength(0); i++)
            {
                
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    int numeros = rnd.Next(1, 20);
                    matris[i, j] = numeros;
                }
                
            }
            
            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    Console.Write($"{matris[i, j]} |");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int suma = 0;
            for (int i = 0; i < matris.GetLength(1); i++)
            {
                
                for (int j = 0; j < matris.GetLength(0); j++)
                {
                    
                    suma = suma + matris[j, i];
                    
                }
                Console.WriteLine($"la suma de la columna{i} ={suma} ");
                suma = 0;
            }*/

            /*Desarrollar un programa que crea una matriz de n filas *m columnas, el usuario ingresa
            caracteres en cada posición de la matriz hasta llenarla. El programa debe intercambiar la
            primera fila con la última fila de la matriz. Al final se debe imprimir la matriz original, y la
            matriz con el intercambio de filas. */

            int filas;
            int columnas;

            Console.WriteLine("Ingrese el número de filas para la matriz");
            filas = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número de columnas para la matriz");
            columnas = int.Parse(Console.ReadLine());

            char[,] matriz1 = new char[filas, columnas];
            char[,] matriz2 = new char[filas, columnas];

            // Llenar la matriz
            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                for (int j = 0; j < matriz1.GetLength(1); j++)
                {
                    Console.WriteLine($"Ingrese el caracter para la matriz en [{i}, {j}].");

                    matriz1[i, j] = char.Parse(Console.ReadLine());
                    matriz2[i, j] = matriz1[i, j];
                }
            }

            // Intercambiar la primera fila con la última fila
            for (int j = 0; j < columnas; j++)
            {
                matriz2[0, j] = matriz1[filas - 1, j];
                matriz2[filas - 1, j] = matriz1[0, j];
            }

            // Mostrar la matriz original
            Console.WriteLine("\nMatriz original:");

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz1[i, j] + " ");
                }

                Console.WriteLine();
            }

            // Mostrar la matriz con el intercambio de filas
            Console.WriteLine("\nMatriz con intercambio de filas:");

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz2[i, j] + " ");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}