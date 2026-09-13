using System;


namespace _14.CicloFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar un programa que permita imprimir por pantalla los números múltiplos de 5, el usuario debe ingresar por el teclado el rango de números a evaluar. 

            int inicioRango;
            Console.WriteLine("Ingrese el incio del rango de números que desea evaluar");
            inicioRango = int.Parse(Console.ReadLine());
            int finRango;
            Console.WriteLine("Ingrese el final del rango de números que desea evaluar");
            finRango = int.Parse(Console.ReadLine());

            Console.WriteLine($"Los múltiplos de 5 entre {inicioRango} y {finRango} son:");

            for (int i = inicioRango; i <= finRango; i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
