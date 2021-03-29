using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValoresNumericosEjercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = 0;

            Console.WriteLine("Ingrese un valor numérico");
            if (!int.TryParse(Console.ReadLine(), out valor))
            {
                Console.WriteLine("Debe ser un valor numérico");
            }
            else
            {
                Console.WriteLine($"El valor ingresado es: {valor}");
            }

            Console.ReadKey();
        }
    }
}
