using System;
namespace _12.CicloDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Algoritmo que le pida a un grupo de usuarios su nombre, número de cuenta y saldo; Para cada usuario se debe hacer lo siguiente:

            //i. si el saldo es mayor o igual a 3'000.000, sacar un mensaje que diga el nombre del usuario, el número de cuenta, el saldo y "es apto para el crédito"

            //ii. si el saldo es menor a 3'000.000, sacar un mensaje que diga el nombre del usuario, el número de cuenta, el saldo y "no es apto para el cr´´edito"

            //El algoritmo debe permitir preguntar la información de usuarios, hasta que se le indique que ya no se desea preguntar más.

            //Además, el algoritmo debe permitir mostrar el número de usuarios a los que se le preguntó por la información, y debe mostrar el promedio de los saldos.


            string nombre;
            int NumeroCuenta;
            float saldo;
            string continuar;

            int contador = 0;
            double acumulador = 0;


            do
            {
                Console.WriteLine("Ingrese el nombre del usuario");
                nombre = Console.ReadLine();

                Console.WriteLine("Ingrese el número de cuenta");
                NumeroCuenta = int.Parse(Console.ReadLine());

                Console.WriteLine("ingrese el saldo:");
                saldo = float.Parse(Console.ReadLine());

                contador++;
                acumulador = acumulador + saldo;

                if (saldo >= 3000000)
                {
                    Console.WriteLine("Nombre: " + nombre);

                    Console.WriteLine("Número de cuenta: " + NumeroCuenta);

                    Console.WriteLine("Saldo: " + saldo);

                    Console.WriteLine("Es apto para el Crédito :)");

                }
                else
                {
                    Console.WriteLine("Nombre: " + nombre);

                    Console.WriteLine("Número de cuenta: " + NumeroCuenta);

                    Console.WriteLine("Saldo: " + saldo);

                    Console.WriteLine("No es apto para el crédito :(");
                }
                Console.WriteLine();
                Console.Write("Desea ingresar otro usuario? (si/no)");
                continuar = Console.ReadLine();

            } while (continuar == "si");

            double promedio = acumulador / contador;
            Console.WriteLine();
            Console.WriteLine("Número de usuarios: " + contador);
            Console.WriteLine("Promedio de saldos: " + promedio);

        }
    }
}
