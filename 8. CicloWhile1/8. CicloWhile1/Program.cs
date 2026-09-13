using System;
using System.Security.Policy;


namespace _8.CicloWhile1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Realizar un algoritmo que pida números enteros positivos y los sume, hasta que se ingrese un número entero negativo. 
            Se debe mostrar por pantalla el total de la suma de los números ingresados.*/

            int numero;
            int suma = 0; // Acumulador

            Console.WriteLine("Ingrese un número entero positivo (-1 para terminar):");
            numero = int.Parse(Console.ReadLine());

            while (numero >= 0)
            {
                suma = suma + numero;

                Console.WriteLine("Ingrese otro número entero positivo (-1 para terminar):");
                numero = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("El total de la suma es: " + suma);
        }
    }
}
