using Microsoft.Win32;
using System;

namespace Parcial_Ciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Una pequeña bodega necesita un programa para registrar las entradas de mercancía que van llegando a lo
            largo del día. A diferencia de otros días, no se sabe cuántos lotes van a llegar en total.

            Utiliza una estructura repetitiva adecuada(while o do -while) que permita registrar lotes de forma indefinida 
            hasta que el usuario decida terminar.El programa debe cumplir con lo siguiente:

            1.En cada iteración, solicitar el código del producto(un número entero) y la cantidad de unidades ingresadas.

            2.Condición de salida: El ciclo debe repetirse mientras el código del producto sea diferente de -1(el código - 1 indica que 
              ya no hay más lotes por registrar).

            3.Validación con Condicional: Si la cantidad de unidades ingresada es menor o igual a 0, el programa debe mostrar 
              un mensaje de advertencia "Cantidad inválida, no se sumará al inventario" y omitir ese registro sin romper el ciclo.

            4.Estadísticas de Cierre: Al finalizar el ingreso de datos(cuando el usuario digite -1), el programa debe mostrar en pantalla:

                -El total acumulado de unidades ingresadas en la bodega durante todo el día.
                -Cuántos lotes válidos se registraron en total.*/


            int codigo;
            int cantidad;
            int totalUnidades = 0; //acumulador
            int lotesValidos = 0;  //contador

            Console.WriteLine("Ingrese el código del producto    (si no desea ingresar más, digite -1 para terminar):");
            codigo = int.Parse(Console.ReadLine());

            while (codigo != -1)
            {
                Console.WriteLine("Ingrese la cantidad de unidades:");
                cantidad = int.Parse(Console.ReadLine());

                if (cantidad <= 0)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Cantidad inválida, no se sumará al inventario");
                }
                else
                {
                    totalUnidades = totalUnidades + cantidad;
                    lotesValidos = lotesValidos + 1;
                }
                Console.WriteLine(" ");
                Console.WriteLine("Ingrese el código del producto     (si no desea ingresar más, digite -1 para terminar):");
                codigo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(" ");
            Console.WriteLine("      -Total acumulado de unidades ingresadas en la bodega: " + totalUnidades);
            Console.WriteLine("      -Total de lotes válidos: " + lotesValidos);

        }
    }
}
