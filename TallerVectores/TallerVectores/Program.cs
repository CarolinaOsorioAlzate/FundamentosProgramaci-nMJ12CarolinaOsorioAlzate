using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerVectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.
            /*int[] numeros = new int[15];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Ingrese el numero P{i+1},I{i}");
                numeros[i] = int.Parse(Console.ReadLine());

                int menor = numeros[0];
                int mayor = numeros[0];

                if (numeros[i] > mayor)
                {
                    mayor = numeros[i];
                }

                if (numeros[i] < menor)
                {
                    menor = numeros[i];
                }

              
                
            }
            Console.WriteLine($"El numero mayor es: {mayor}, el numero menor es: {menor}");*/

            //2.
            /*int[] columna1 = new int[3];
            int[] columna2 = new int[3];
            int contador = 0;

            for (int i = 0; i < columna1.Length; i++)
            {
                Console.WriteLine($"Ingrese el numero P{i + 1},I{i} de la primera ronda");
                columna1[i] = int.Parse(Console.ReadLine());

                Console.WriteLine($"Ingrese el numero P{i + 1},I{i} de la segunda ronda");
                columna2[i] = int.Parse(Console.ReadLine());

                if (columna1[i] == columna2[i])
                {
                    contador++;
                }
            }
            for (int i = 0; i < columna1.Length; i++)
            {
                Console.WriteLine($"P{i + 1},I{i} {columna1[i]}||{columna2[i]}");
            }
            Console.WriteLine($"La cantidad de numeros que son iguales es de: {contador}");*/

            //3.
            /*Random numero = new Random();
            int[] num = new int[20];
            float promedio = 0f;

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = numero.Next(-100, 99);
                promedio += num[i];
            }
            promedio /= 20f;
            Console.WriteLine($"EL promedio es:{promedio}");*/

            /* 
           Escribir un algoritmo que permita:
           a.Crear dos vectores del mismo tamaño. 
           b.Llenarlos con números.
           c.Comparar posición por posición.
           d.Indicar cuántos elementos son iguales. */

            int[] vector1 = new int[10];
            int[] vector2 = new int[10];
            int numIguales = 0;

            for (int n1 = 0; n1 < 10; n1++)
            {
                Console.WriteLine($"Ingrese el número {n1 + 1} del vector 1.");
                vector1[n1] = int.Parse(Console.ReadLine());
            }
            for (int n2 = 0; n2 < vector2.Length; n2++)
            {
                Console.WriteLine($"Ingrese el número {n2 + 1} del vector 2.");
                vector2[n2] = int.Parse(Console.ReadLine());
                if (vector1[n2] == vector2[n2])
                {
                    Console.WriteLine($"Los números de la posición {n2 + 1} son iguales.");
                }
            }

        }
    }
}