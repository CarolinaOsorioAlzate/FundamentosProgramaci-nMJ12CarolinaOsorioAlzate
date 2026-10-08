using System;

namespace _19.Ejercicio_Modulos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MostrarMenu();
            RealizarOperaciones(CapturarOpción());
        }

        static float Multiplicacion()
        {
            float numero = 0;
            float multiplicacion = 1;
            char respuesta = ' ';
            do
            {
                Console.WriteLine("ingrese un número");
                numero = float.Parse(Console.ReadLine());
                multiplicacion *= numero;
                Console.WriteLine("desea multiplicar más numeros. s: para continuar");
                respuesta = char.Parse(Console.ReadLine());
            } while (respuesta == 's');
            return multiplicacion;
        }
        static float division()
        {
            Console.WriteLine("ingrese el primer número :");
            float numero1 = float.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el segundo número :");
            float numero2 = float.Parse(Console.ReadLine());
            return numero1 / numero2;
        }

        static float resta()
        {
            Console.WriteLine("ingrese el primer número :");
            float numero1 = float.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el segundo número :");
            float numero2 = float.Parse(Console.ReadLine());
            return numero1 - numero2;
        }

        static float suma()
        {
            float numero = 0;
            float suma = 0;
            char respuesta = ' ';
            do
            {
                Console.WriteLine("ingrese un número");
                numero = float.Parse(Console.ReadLine());
                suma += numero;
                Console.WriteLine("desea sumar más numeros. s: para continuar");
                respuesta = char.Parse(Console.ReadLine());
            } while (respuesta == 's');
            return suma;
        }
        static void RealizarOperaciones(int opcion) 
        {
            while (opcion != 0)
            {
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine($"La SUMA de los números ingresados es:{suma()}");
                        break;
                    case 2:
                        Console.WriteLine($"La RESTA de los números ingresados es {resta()}");
                        break;
                    case 3:
                        Console.WriteLine($"La MULTIPLICACIÓN de los numeros ingresados es: {Multiplicacion()}");
                        break;
                    case 4:
                        Console.WriteLine($"La DIVISIÓN de los numeros ingresados es: {division()}");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
                MostrarMenu();
                opcion = CapturarOpción();
            }
        }

        static int CapturarOpción() 
        {
            return int.Parse(Console.ReadLine());
        
        }
        static void MostrarMenu() 
        {
            Console.WriteLine("------------------------MENÚ-------------------------");
            Console.WriteLine("1.Suma                 2.Resta");
            Console.WriteLine("3.Multiplicación       4.División");
            Console.WriteLine("0.Salir");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Ingrese una ópcion del menú:");

        }
    }

}
