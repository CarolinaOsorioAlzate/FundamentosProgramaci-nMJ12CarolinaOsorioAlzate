using System;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;

namespace TallerCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Crear un algoritmo que permita leer tres valores y almacenarlos en las variables numero1,
            numero2, numero3 respectivamente.El algoritmo debe comprobar si los números son
            diferentes, si es así, imprimir cual es el número mayor, además ordenar y mostrar en
            pantalla los números de menor a mayor.
            Si hay números iguales, el algoritmo debe mostrar un mensaje indicando que se deben
            ingresar números diferentes.*/

            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            Console.WriteLine("Por favor ingrese 3 valores diferentes");
            Console.WriteLine("Ingrese el valor del número 1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del número 2");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del número 3");
            num3 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                //Verdadera
                if (num1 > num3)
                {
                    Console.WriteLine("El número 1 es el mayor");
                    if (num2 > num3)
                    {
                        Console.WriteLine("El orden de los numeros es:" + " " + num1 + " " + num2 + " " + num3);
                    }
                    else
                    {
                        Console.WriteLine("El orden de los numeros es:" + " " + num1 + " " + num3 + " " + num2);
                    }

                }
                else
                {
                    Console.WriteLine("El número 3 es el mayor");
                    if (num1 > num2)
                    {
                        Console.WriteLine("El orden de los numeros es:" + " " + num3 + " " + num1 + " " + num2);
                    }
                    else
                    {
                        Console.WriteLine("El orden de los numeros es:" + " " + num3 + " " + num2 + " " + num1);
                    }

                }
            }
            else
            {
                //Falsa
                if (num2 > num3)
                {
                    Console.WriteLine("El número 2 es el mayor");
                    if (num1 > num3)
                    {
                        Console.WriteLine("El orden de los numeros es:" + " " + num2 + " " + num1 + " " + num3);
                    }
                    else
                    {
                        Console.WriteLine("El orden de los numeros es:" + " " + num2 + " " + num3 + " " + num1);
                    }
                }
                else
                {
                    Console.WriteLine("El número 3 es el mayor");
                    if (num2 > num1)
                    {
                        Console.WriteLine("El orden de los numeros es:" + " " + num3 + " " + num2 + " " + num1);
                    }
                    else
                    {
                        Console.WriteLine("El orden de los numeros es:" + " " + num3 + " " + num1 + " " + num2);
                    }
                }
            }


            /*Crear un algoritmo que permita ingresar las coordenadas x,y, para tres puntos: P1(x1, y1), 
            P2(x2, y2), P3(x3, y3).Luego calcular la distancia entre los puntos P1  P2, P2  P3, P1
            P3.La distancia entre dos puntos está dada por la siguiente formula:
                        d = √((x2 - x1)² +(y2 - y1)²)*/
            




        }
    }
}
