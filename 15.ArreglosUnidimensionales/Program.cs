using System;

namespace _15.ArreglosUnidimensionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*//Arreglos Unidimensionales - Vectores

            int[] numeros=new int[5];

            numeros[0] = 10;
            numeros[1] = 56;
            numeros[2] = 22;
            numeros[3] = 45;
            numeros[4] = 102;
            //numeros[5] = 14;, no se puede almacenar porque es una posición que no existe

            Console.WriteLine($"El número almacenado en la posición 3 con indice 2 es : {numeros[2]}");

            //Otras formas de declarar e inicializar vactores

            char[] simbolos = new char[] {'#','$', 'ó','a','%'};
            bool[] valresVerdad = { true, false, false, true, true, false, false };

            //Recorrer para almacenar datos
            string[] nombres = new string[7];
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"ingrese el nombre para P{i + 1} : I{i}");
                nombres[1] = Console.ReadLine();
            }
            Console.Clear();
            //Recorrer para recuperar
            for (int i=0; i < nombres.Length; i++) 
            {
                Console.Write($"{nombres[i]} |");
            
            }*/

            //1Crear arreglo llamado "numeros" de 100 elementos asignar el número 10 en cada una de las posiciones del arreglo. Leer el contenido de cada elemento y escribirlo en pantalla
            /*
                        int[] numeros = new int[100];

                        for (int i = 0; i < 100; i++)
                        {
                            numeros[i] = 10;

                        }

                        for (int i = 0; i < 100; i++)
                        {
                            Console.WriteLine(numeros[i]);

                        }*/

            //2.Algoritmo que permita solicitar 10 números, los cuales se´rán almacenados en un arreglo, al final, debe visualizar el promedio de esos números

            int[] numeros = new int[10];
            int suma = 0;
            double promedio;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ingrese el número" + (i + 1) + ":");
                numeros[i] = int.Parse(Console.ReadLine());

                suma = suma + numeros[i];

            }

            promedio = suma / 10.0;

            Console.WriteLine("el promedio es:" + promedio);

        }
    }
}
