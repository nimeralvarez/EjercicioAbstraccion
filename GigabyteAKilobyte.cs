using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAbstraccion
{
    internal class GigabyteAKilobyte : FormulaMatematica
    {
        public double Gigabyte { get; set; }

        public override string Calcular()
        {
            return (Gigabyte * 1000000) + " kB";
        }

        public override void Imprimir()
        {
            Console.WriteLine($"{Gigabyte} GB a kilobyte es: {Calcular()}");
        }
    }
}
