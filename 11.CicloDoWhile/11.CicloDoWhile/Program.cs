using System;


namespace _11.CicloDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
             /*//Ciclo Do while
             int contador = 1;
             int acumulador = 0;

             do
             {
                 acumulador += contador;
                 contador++;
             } 

             while (contador <=5);

             Console.WriteLine($"La suma de los cinco primeros números enteros es: {acumulador}");*/
 

            //Algoritmo que solicita un número y genere su correspondiente tabla de multiplicar desde el 1 hasta el 10, y asi susecivamente hasta que el usuario ya no desee continuar generando tablas de multiplicar

            /* int contador = 1;
             int numero = 0;
             char respuesta = ' ';

             do
             {

                 Console.WriteLine("ingrese el numero del cual quiere obtener la tabla de multiplicar:");
                 numero = int.Parse(Console.ReadLine());

                 do
                 {
                     Console.WriteLine(numero + "X" + contador + "=" + numero * contador);
                     contador++;
                 }while (contador <= 10);
                 contador = 1;
                 Console.WriteLine("Desea continuar: s/si - cualquier otro caracter para salir");
                 respuesta=char.Parse(Console.ReadLine());
             }while (respuesta=='s');*/

            //crear un algoritmo que permita calcular y mostrar por pantalla los numeros primos hasta el número 100

            int numero = 2;
            int divisor;
            int contador;

            do
            {
                divisor = 1;
                contador = 0;

                do
                {
                    if (numero % divisor == 0)
                    {
                        contador++;
                    }

                    divisor++;

                } while (divisor <= numero);

                if (contador == 2)
                {
                    Console.WriteLine(numero);
                }

                numero++;

            }while (numero <= 100);

        }
    }
}
