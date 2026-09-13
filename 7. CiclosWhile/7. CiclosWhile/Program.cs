using System;


namespace _7.CiclosWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*//1. Escribir un algoritmo que permita generar los primeros 5 n+umeros enteros positivos y realizar y mostrar su suma.

            int contador = 1;
            int acumulador = 1;

            while (contador < 5)
            {
                contador++;
                acumulador = acumulador + contador;
            }

            Console.WriteLine($"La suma de los cinco primeros números es: {acumulador}"); */

            //2. Crear un algoritmo que permita calcular la factorial de un número dado por el usuario. (5! = 1*2*3*4*5)

            int contador = 1;
            int acumulador = 1;
            int numero;
            Console.WriteLine("Ingrese el número.");
            numero = int.Parse(Console.ReadLine());

            while (contador <= numero)
            {
                acumulador = acumulador * contador;
                contador++;
            }
            Console.WriteLine($"La factorial del número dado es: {acumulador}");

        }
    }
}
