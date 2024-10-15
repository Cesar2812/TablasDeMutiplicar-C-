using System;

namespace TablasMultiplicar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            while (a<=5) 
            {
                Console.WriteLine("Escriba el numero de la tabla");
                var numero = Convert.ToInt32(Console.ReadLine());// aca lo que le digo es que para que se pueda ejecutar el  metodo ReadLine() solo puede almacenar texto que lo convierta a entero para poder leer la variable

                Console.WriteLine("La tabla del " + numero + " es:");
                for (int i = 0; i < 12; i++)
                {
                    Console.WriteLine(numero + "*" + (i + 1) + "= " + (numero * (i + 1)));
                }
               a++;
            }
            


        }
    }
}
