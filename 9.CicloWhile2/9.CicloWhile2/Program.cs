using System;


namespace _9.CicloWhile2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar un algoritmo que le pida al usuario ingresas por teclado números enteros al azar. Al usuario le corresponde ingresar la cantidad de números que va a introducir. El algoritmo debe escribir en pantalla: 1. la cantidad de números introducidos que son mayores que 0 2. la cantidad de números introducidos menores que 0 3. la cantidad de números iguales a 0

            //int cantidadNumeros = 0;
            //int numero = 0;
            //int contador = 0;
            //int contadorceros = 0;
            //int contadormenor = 0;
            //int contadormayor = 0;

            //Console.WriteLine("Cuál es la cantidad de números a evaluar: "); 
            //cantidadNumeros = int.Parse(Console.ReadLine());

            //while (contador <= cantidadNumeros)
            //{
            //    contador++;
            //    Console.WriteLine("Ingrese un número al azar: ");
            //    numero = int.Parse(Console.ReadLine());

            //    if (numero == 0) 
            //    {
            //        contadorceros++;
            //    }
            //    else
            //    {
            //        if (numero > 0)
            //        {
            //            contadormayor++;
            //        }
            //        else
            //        {
            //            contadormenor++;
            //        }
            //    }
            //}

            //Console.WriteLine($"Mayores que 0: {contadormayor}, menores que 0: {contadormenor}, iguales que 0: {contadorceros}");







            //Escribir un algoritmo que cuente cuántos números pares hay en un rango de números del 1 al número n

            int n = 0;
            int contador = 0;
            int numeros = 0;
            int contadorpares = 0;

            Console.WriteLine("Ingrese el número de números q va a evaluar: ");
            n = int.Parse(Console.ReadLine());

            while (contador <= n)
            {
                contador++;
                Console.WriteLine("Ingrese número: ");
                numeros = int.Parse(Console.ReadLine());

                if (numeros % 2 == 0)
                {
                    contadorpares++;
                }

            }

            Console.WriteLine($"Hay {contadorpares} números pares");
        }
    }
}
