using System;

namespace _2.ConstanteTiposDOperadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CONSTANTES
            const string gravedad = "9.8";
            string nombre = "Carolina";
            nombre = "Osorio";
            //gravedad= "10"; mo puedo cambiar el valor de una constante  

            //TIPOS DE DATOS
            byte dato1 = 5; // 0 a 255
            int dato2 = -4568; 
            ulong dato3 = 235454224;
            float dato4 = 14.6f; //siempre con el sufijo f porque solo lo identifica así
            double dato5 = 2132156.65421;
            decimal dato6 = 2132135545642.545641m;//siempre con el sufijo m

            char dato7 = '+'; //signos
            string dato8 = "hsadsjkhdas9+edf8";
            bool dato9 = false; //true o false
            object dato10 = new object();//creo la clase por medio de la palabra reservada new y el constructor (me ayuda a construir la clase)

            //OPERADORES
            //Operadores Númericos
            //Cambio de signos

            int dato11 = 5;
            int dato12 = -dato11;
            int dato13 = +dato12;
            int dato14 = -dato13;

            Console.WriteLine("Dato 11: {0}, Dato 12: {1}, Dato 13: {2}, Dato 14: {3}", dato11, dato12, dato13, dato14);

            int dato15 = 5 + 3;//suma
            int dato16 = dato15 - 2;//resta
            int dato17 = 25 * 3;//producto
            float dato18 = 5 / 3f; //División //division de enteros pasela a float 

            Console.WriteLine("suma: {0}, resta: {1}, producto: {2}, división: {3}", dato15, dato16, dato17, dato18);

        }
    }
}
