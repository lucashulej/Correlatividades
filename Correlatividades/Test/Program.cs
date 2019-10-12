using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Catedra catedra = new Catedra();
            catedra.Mostrar();
            Console.WriteLine();
            catedra[0] = 1;
            catedra[1] = 1;
            catedra[2] = 1;
            catedra[3] = 1;
            catedra[4] = 1;
            catedra.printCursadadaPosible();
            Console.ReadLine();
        }
    }
}
