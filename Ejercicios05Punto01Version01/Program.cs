using System;

namespace Ejercicios05Punto01Version01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title="Primer ejemplo de Ciclos Repetitivos";
            var suma = 0;
            var contador = 0;
            while (contador<4)
            {
                Console.Write($"Ingrese el número {contador+1}:");
                var nro =int.Parse(Console.ReadLine());
                suma = suma + nro;
                contador = contador + 1;

            }
            Console.Write($"La suma de los 10 números es {suma}");
		}
    }
}
