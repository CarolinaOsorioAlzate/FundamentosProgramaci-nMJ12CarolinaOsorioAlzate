using System;

namespace _18.ProgramacionModular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenidos al curso de fundamentos de programación"); 
            MostrarMensaje("Carolina");
            Console.WriteLine($"Carolina tiene {CalcularEdad(2026, 2006)} años.");
            MostrarMensaje("Juan");
            Console.WriteLine($"Juan tiene {CalcularEdad()} años.");
            MostrarMensaje("Alex", "Garcia López");

            
            Console.ReadKey();
            BorrarPantalla();
            
        }
        //Funciones con parametros

        static int CalcularEdad(int añoActual, int añoNacimiento)
        {
            return añoActual - añoNacimiento;
        }

        //Funciones sin parametros
        static int CalcularEdad()
        {
            int añoNacimiento = 1990;
            int añoActual = 2026;
            int edad = añoActual - añoNacimiento;
            return edad;
        }

        //Procedimientos sin parametros 
        static void BorrarPantalla()
        {
            Console.Clear();
        }

        static void MostrarMensaje(string nombre)
        {
            Console.WriteLine($"Bienvenido, {nombre} al curso de fundamentos de programación");
        }

        static void MostrarMensaje(string nombre, string apellidos)
        {
            Console.WriteLine($"Bienvenido, {nombre} {apellidos} al curso de fundamentos de programación");
        }
    }
}

