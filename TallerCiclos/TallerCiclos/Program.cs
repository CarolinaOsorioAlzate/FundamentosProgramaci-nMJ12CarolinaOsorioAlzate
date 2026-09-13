using System;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Win32;


namespace TallerCiclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1.Algoritmo que permita calcular el promedio de calificaciones, el algoritmo 
            le permitirá al usuario, introducir tantas calificaciones como así desee, 
            en el momento en que seleccione que no desea continuar capturando 
            calificaciones, el algoritmo debe presentar el promedio de las 
            calificaciones capturadas previamente*/

            /*int calificacion = 0;
            string opción = "s";
            float acumulador = 0;
            int contador = 0;

            do
            {

                Console.WriteLine("Ingrese una calificación:");
                calificacion = int.Parse (Console.ReadLine());
                acumulador = acumulador + calificacion;
                contador++;
                Console.WriteLine("¿añadir otra calificación? s/sí, cualquier otra letra para no");
                opción = Console.ReadLine();

            } while (opción == "s");

            Console.WriteLine($"el promedio de las calificaciones es: {acumulador / contador}");*/



            /*2.Se requiere un algoritmo para mostrar por pantalla los divisores de un
            número ingresado por teclado. 
            Tener en cuenta que dados dos números enteros a y b, se dice que b es
            divisor de a si se cumple que al efectuar una división entera a/ b el
            residuo es 0, en C# utilizar el operador Mod para obtener el residuo de 
            una división de dos números.
            Ejemplo: si se ingresa 6 por teclado, por pantalla se debe mostrar 6, 3, 
            2, 1 que son los divisores del número 6.*/

            /*int numero;

            Console.WriteLine("Ingrese un número.");
            numero = int.Parse(Console.ReadLine());
            int contador = 0;

            do
            {
                contador++;
                if (numero % contador == 0)
                {
                    Console.WriteLine(contador);
                }
            } while (contador <= numero);*/


            /*Dados dos números enteros ingresados por teclado: b que es la base y
            e que es el exponente, se requiere calcular el resultado de la
            potenciación.
            Ejemplo: b = 2, e = 5  25 = 2 * 2 * 2 * 2 * 2 = 32
            Mostrar por pantalla el resultado de la potenciación. 
            Seguir pidiendo por teclado la base y el exponente y realizar la
            potenciación correspondiente, hasta que el usuario ingrese por teclado
            el carácter de escape ‘n’*/

            /*int b = 0;
            int e = 0;
            string opcion = "s";
            do
            {

                Console.WriteLine("ingrese un número:");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("ingrese una potencia para el número:");
                e = int.Parse(Console.ReadLine());

                double resultado = Math.Pow(b, e);

                Console.WriteLine($"la potencia del número {b} es: {resultado}");

                Console.WriteLine("¿desea calcular otra potencia? s/sí, cualquier otra letra para no");
                opcion = Console.ReadLine();

            } while (opcion == "s");*/

            /*Un entrenador le ha propuesto a un atleta recorrer una ruta de cinco
            kilómetros durante 10 días, para determinar si es apto para la prueba de
            5 kilómetros.Para considerarlo apto debe cumplir las siguientes
            condiciones: 

            -Que en ninguna de las pruebas haga un tiempo mayor a 20 minutos.
            -Que al menos en una de las pruebas realice un tiempo menor de 15
            minutos.
            -Que su promedio sea menor o igual a 18 minutos.

            Diseñar un algoritmo para registrar los datos y decidir si es apto para la
            competencia*/

            /*int tiempoPrueba = 0;
            int tiempoTotal = 0;
            int cantidadPruebas = 1;
            float promedio = 0;
            bool apto = true;
            bool pruebaCumplida = false;


            do
            {
                Console.WriteLine($"Ingrese el tiempo del dia {cantidadPruebas}");
                tiempoPrueba = int.Parse(Console.ReadLine());

                tiempoTotal = tiempoTotal + tiempoPrueba;
                promedio = tiempoTotal / cantidadPruebas;

                if (tiempoPrueba > 20)
                {
                    apto = false;
                }
                if (tiempoPrueba < 15)
                {
                    pruebaCumplida = true;
                }
                if (promedio > 18)
                {
                    apto = false;
                }

                cantidadPruebas++;
            } while (apto && cantidadPruebas <= 10);

            Console.WriteLine($" promedio es: {promedio}");

            if (!pruebaCumplida)
            {
                apto = false;
            }

            if (apto)
            {
                Console.WriteLine("El atleta es apto");
            }
            else
            {
                Console.WriteLine("El atleta no es apto");*
            }
            */
        }
    }
}
