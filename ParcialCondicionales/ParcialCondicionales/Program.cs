using System;

namespace Parcial_Condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Desarrolle un programa en C# que permita a un usuario seleccionar una sala y un juego de acuerdo con su edad, y determine el precio que debe pagar.
            a. Ingreso de datos
            El programa debe solicitar al usuario:
            Edad, expresada como un número entero positivo.
            b.Determinación de las salas habilitadas
            De acuerdo con la edad ingresada, se determinarán las salas a las que el usuario puede acceder:

            Edad
            Sala(s) habilitada(s)
            1 a 5 años

            Sala 1
            6 a 16 años

            Sala 2
            17 a 25 años

            Sala 3 y Sala 4
            26 años o más
            Sala 5

            Si la edad ingresada no corresponde a un rango válido, el programa debe mostrar un mensaje de error y finalizar.
            Cuando exista una sola sala habilitada, esta será asignada automáticamente.Cuando existan dos salas habilitadas, el programa debe mostrar ambas opciones y permitir al usuario seleccionar una.
            c.Juegos disponibles por sala
            Una vez determinada la sala, el programa debe mostrar los juegos disponibles en ella:

            Sala
            Juegos disponibles
            Sala 1
            Juego1, Juego5

            Sala 2
            Juego3, Juego6

            Sala 3
            Juego2, Juego7

            Sala 4
            Juego4, Juego8

            Sala 5
            Juego9, Juego10

            El usuario debe seleccionar uno de los juegos disponibles para la sala elegida.
            Si el usuario selecciona una sala o un juego que no corresponda a las opciones habilitadas, el programa debe mostrar un mensaje indicando que la selección no es válida y finalizar.
            d.Precio de los juegos
            El precio que debe pagar el usuario depende del juego seleccionado:

            
            Juego
            Precio

            Juego1, Juego10
            $3.000

            Juego2, Juego9
            $5.000

            Juego3, Juego5, Juego8
            $7.000

            Juego4, Juego6
            $9.000

            Juego7
            $10.000

            Una vez realizadas las selecciones correctamente, el programa debe mostrar:
            Edad del usuario
            Sala seleccionada
            Juego seleccionado
            Precio a pagar
            Por ejemplo:
            Edad del usuario: 20
            Sala seleccionada: Sala 3
            Juego seleccionado: Juego2
            Precio a pagar: $5.000
            El estudiante podrá utilizar las estructuras condicionales estudiadas en clase que considere adecuadas para resolver el problema.*/

            //a. Ingreso de datos

            int edad;
            int sala = 0;
            int juego = 0;
            int precio = 0;

            Console.WriteLine("Ingrese su edad: ");
            edad = int.Parse(Console.ReadLine());

            // b. Determinación de las salas habilitadas

            if (edad >= 1 && edad <= 5)
            {
                sala = 1;
            }
            else if (edad >= 6 && edad <= 16)
            {
                sala = 2;
            }
            else if (edad >= 17 && edad <= 25)
            {
                Console.WriteLine("Tiene dos salas disponibles:");
                Console.WriteLine("Seleccione una sala: 3 o 4");
                sala = int.Parse(Console.ReadLine());

                if (sala != 3 && sala != 4)
                {
                    Console.WriteLine("Error: La sala no corresponde a las opciones disponibles");
                    sala = 0;
                }
            }
            else if (edad >= 26)
            {
                sala = 5;
            }
            else
            {
                Console.WriteLine("Error");
                sala = 0;
            }


            // c. Juegos disponibles por sala

            if (sala != 0)
            {
                Console.WriteLine("Juegos disponibles:");

                if (sala == 1)
                {
                    Console.WriteLine("Juego1 y Juego5");
                }
                else if (sala == 2)
                {
                    Console.WriteLine("Juego3 y Juego6");
                }
                else if (sala == 3)
                {
                    Console.WriteLine("Juego2 y Juego7");
                }
                else if (sala == 4)
                {
                    Console.WriteLine("Juego4 y Juego8");
                }
                else if (sala == 5)
                {
                    Console.WriteLine("Juego9 y Juego10");
                }

                Console.WriteLine("Seleccione un juego:");
                juego = int.Parse(Console.ReadLine());


                // Validar juego

                if (sala == 1 && juego != 1 && juego != 5)
                {
                    Console.WriteLine("Error: Juego no válido");
                    juego = 0;
                }
                else if (sala == 2 && juego != 3 && juego != 6)
                {
                    Console.WriteLine("Error: Juego no válido");
                    juego = 0;
                }
                else if (sala == 3 && juego != 2 && juego != 7)
                {
                    Console.WriteLine("Error: Juego no válido");
                    juego = 0;
                }
                else if (sala == 4 && juego != 4 && juego != 8)
                {
                    Console.WriteLine("Error: Juego no válido");
                    juego = 0;
                }
                else if (sala == 5 && juego != 9 && juego != 10)
                {
                    Console.WriteLine("Error: Juego no válido");
                    juego = 0;
                }


                // d. Precio de los juegos

                if (juego != 0)
                {
                    if (juego == 1 || juego == 10)
                    {
                        precio = 3000;
                    }
                    else if (juego == 2 || juego == 9)
                    {
                        precio = 5000;
                    }
                    else if (juego == 3 || juego == 5 || juego == 8)
                    {
                        precio = 7000;
                    }
                    else if (juego == 4 || juego == 6)
                    {
                        precio = 9000;
                    }
                    else if (juego == 7)
                    {
                        precio = 10000;
                    }


                    // Resultado

                    Console.WriteLine("---♥ RESULTADO ♥---");
                    Console.WriteLine("Edad del usuario: " + edad);
                    Console.WriteLine("Sala seleccionada: Sala " + sala);
                    Console.WriteLine("Juego seleccionado: Juego" + juego);
                    Console.WriteLine("Precio a pagar: $" + precio);
                }
            }
        }
    }
}
