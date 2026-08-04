using System;

namespace _3.Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Operadores Numéricos
            //Incremento Decremento 
            int dato1 = 0;
            dato1++; //dato1 = dato1 + 1; Incrementa en 1 unidad
            dato1--; //dato1 = dato1 - 1; Decrementa en 1 unidad
            dato1 += 15; //dato1 = dato1 + 15; Incrementa en 15 unidades
            dato1 -= 14; //dato1 = dato1 - 14; Decrementa en 14 unidades
            dato1 *= 3; //dato1 = dato1*3;
            dato1 /= 2; //dato1 = dato1/2;
            dato1 *= dato1;

            //Orden de evalución Operadores Aritméticos

            int dato2 = 4 * 3 / 2;
            int dato3 = 5 / 2 * 4;
            int dato4 = 4 * (5 / 2);
            int dato5 = 3 - 1 * (4 / 2);
            Console.WriteLine (dato2);
            Console.WriteLine(dato3);
            Console.WriteLine(dato4);

            //OPERADORES LÓGICOS
            //CONJUNCIÓN - AND - Y - &&

            Console.WriteLine("TABLA DE LA CONJUNCIÓN");
            Console.WriteLine("V && V= " + (true && true));
            Console.WriteLine("V && F =" + (true && false));
            Console.WriteLine("F && V =" + (false && true));
            Console.WriteLine("F && F =" + (false && false));

            //DISYUNCIÓN - OR - O - ||

            Console.WriteLine("TABLA DE LA DISYUNCIÓN");
            Console.WriteLine("V || V= " + (true || true));
            Console.WriteLine("V || F =" + (true || false));
            Console.WriteLine("F || V =" + (false || true));
            Console.WriteLine("F || F =" + (false || false));

            //NEGACIÓN 

            bool dato6 = true;
            bool dato7 =! dato6;

            //OPERADORES DE COMPARACIÓN

            bool dato8 = 5 > 4;
            bool dato9 = 1002 == 102;
            bool dato10 = 10 >= 9; 
            bool dato11 = 0 != 1;
            bool dato12 = 4 < 5 && 3 == 0;
            bool dato13 = 0 != 2 && dato8 || dato9;
        }
    }
}
