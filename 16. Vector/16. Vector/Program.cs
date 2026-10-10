using System;

namespace _16.Vector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Llene un arreglo con 15 números ingresados por teclado. 
            Una vez registrado el total de valores, muestre en pantalla todos los elementos del arreglo. 
            Finalmente, determine cuál es el número mayor y cuál es el número menor, junto con la posición que ocupa cada uno dentro del arreglo. */

            float[] num = new float[15];
            float mayor = num[0];
            float menor = num[0];
            int posMayor = 0;
            int posMenor = 0;

            for (int n = 0; n < 15; n++)
            {
                Console.WriteLine($"Ingrese el número {n + 1}");
                num[n] = float.Parse(Console.ReadLine());
                if (n == 0)
                {
                    mayor = num[0];
                    menor = num[0];
                    posMayor = n + 1;
                    posMenor = n + 1;
                }
                if (num[n] > mayor)
                {
                    mayor = num[n];
                    posMayor = n + 1;
                }
                if (num[n] < menor)
                {
                    menor = num[n];
                    posMenor = n + 1;
                }
            }
            for (int n = 0; n < 15; n++)
            {
                Console.WriteLine($"El número {n + 1} fue: {num[n]}.");
            }
            Console.WriteLine($"\nEl número mayor es {mayor} y está en la posición {posMayor}.");
            Console.WriteLine($"El número menor es {menor} y está en la posición {posMenor}.");
        }
    }
}
