using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiProyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programacion estructurada seccion 0463");
            Console.WriteLine("Programa que Imprima del 1 al 50");
            Console.WriteLine("Alfredo Saltitopa    106824455");
            Console.WriteLine("Juana La del barrio  106824455");
            Console.WriteLine("Fefita La Grande     106824455");

            int x;
            x = 5;
            while (x <= 50)
            {
                Console.Write(x);
                Console.Write(" , ");
                x = x + 1;
            }
            Console.ReadKey();
        }

    }
}
