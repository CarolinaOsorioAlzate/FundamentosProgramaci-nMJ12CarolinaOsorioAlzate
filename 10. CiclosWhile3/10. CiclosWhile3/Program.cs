using System;

namespace _10.CiclosWhile3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escribe un algoritmo en el que el computador elija un número aleatorio entre 1 y 100.El usuario debe adivinar el número, 
            y el programa debe decirle si su intento es demasiado alto, demasiado bajo o correcto. Usa un ciclo while para seguir pidiendo intentos
            hasta que el usuario adivine el número. Utilizar la función Random para elegir el número aleatorio.*/

            Random generador = new Random();
            int numero = generador.Next(1, 101);
            int intento = 0;

            while (intento != numero)
            {
                Console.WriteLine("El programa ha elegido un número entre 1 y 100, intente adivinarlo");
                intento = int.Parse(Console.ReadLine());

                if (intento > numero)
                {
                    Console.WriteLine("Su intento es mayor al número");
                }
                else if (intento < numero)
                {
                    Console.WriteLine("Su intento es menor al número");
                }
            }
            Console.WriteLine($"Has acertado, el número era {intento}");


        }
    }
}
