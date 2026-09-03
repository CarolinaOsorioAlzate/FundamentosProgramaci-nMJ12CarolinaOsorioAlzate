using System;
using System.Timers;


namespace _13.CicloFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Ciclo for

            //int acumulador = 0;
            //for (int contador = 1; contador <= 5; contador++)
            //{
            //    acumulador += contador;
            //}

            //Algoritmo que le permita pedirle un número al usuario y calcular la factorial del número ingresado. ejemplo 5!=1x2x3x4x5

            int numero;
            int factorial = 1;

            Console.WriteLine("Ingrese un número: ");
            numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                factorial = factorial * i;
            }

            Console.WriteLine("El factorial de  " + numero + " es: " + factorial);
        }
    }
}
