using System;

namespace _4.CondicionlesSimpleDoble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  //ESTRUCTURA DE CONTROL CONDICIONALES
              //SIMPLES
              //Crea un algoritmo que lea la edad de un usuario, si el usuario es mayor de 18, se debe mostrar el siguiente mensaje; "Bienvenido a mi sitio web".
              byte edad = 0;
              Console.WriteLine("Ingrese su edad");
              edad = Convert.ToByte( Console.ReadLine());

              if (edad >= 18)
              {
                  //Sí se cumple la condición
                  Console.WriteLine("Bienvenido a mi sitio web <3");
              {*/

            //Crear un algoritmo que permita ingresar el nnombre y el sueldo de una persona, si el sueldo supera los 3000 pesos, mostrar el mensaje en pantalla con el nombre de la persona, indicando que debe anonar impuestos

            /*float num = 0f;
            string name;

            Console.WriteLine("Ingrese su nombre ");
            name = Console.ReadLine();

            Console.WriteLine("Ingrese su sueldo");
            num = Convert.ToSingle(Console.ReadLine());

            if (num > 3000)
            {
                Console.WriteLine("Hola, " + name + " Debe abonar impuestos.");
            }*/

            //Crea un algoritmo que lea la edad de un usuario, si el usuario es mayor de 18, se debe mostrar el siguiente mensaje; "Bienvenido a mi sitio web".

            byte edad = 0;
            Console.WriteLine("Ingrese su edad");
            edad = Convert.ToByte(Console.ReadLine());

            if (edad >= 18)
            {
                //Sí se cumple la condición
                Console.WriteLine("Bienvenido a mi sitio web <3");
            }
            else
            {
                //Si NO se cumple la condición
                Console.WriteLine("No es apto para el contenido del sitio web >:(");
            }

            /*string name;

            Console.WriteLine("digite su nombre");

            name = Console.ReadLine();

            if (name == "maisa")
            {
                Console.WriteLine("Bienvenida a mi sitio web beba, muak :3");
            }
            else 
            {
                Console.WriteLine("No popo, no puedes entrar a mi sitio, fe@");
                  
            }*/
        }

        
    }
}
