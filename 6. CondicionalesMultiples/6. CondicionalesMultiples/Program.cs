using System;


namespace _6.CondicionalesMultiples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Condicionales Múltiples
            //Crear un algoritmo que muestre por pantalla un menú con 5 opciones, y según la opción elegida del menú, muestre un mensaje por pantalla donde se muestra la opción elegida en cado de que se seleccione una opción que no está en el menú mostrar un mensaje de error.

            int respuesta = 0;
            Console.WriteLine("-------------Menú--------------");
            Console.WriteLine("1. Opción 1        2.Opción 2");
            Console.WriteLine("1. Opción 3        2.Opción 4");
            Console.WriteLine("1. Opción 5");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Elija una opción del menú:");
            respuesta = int.Parse(Console.ReadLine());

            switch (respuesta)
            {
                case 1:
                    Console.WriteLine("Eligió la Opción 1");
                    break;

                case 2:
                    Console.WriteLine("Eligió la Opción 2");
                    break;

                case 3:
                    Console.WriteLine("Eligió la Opción 3");
                    break;

                case 4:
                    Console.WriteLine("Eligió la Opción 4");
                    break;

                case 5:
                    Console.WriteLine("Eligió la Opción 5");
                    break;

                default:
                    Console.WriteLine("Eligia una opción valida");
                    break;
            }
        }
    }
}
