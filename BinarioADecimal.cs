using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAbstraccion
{
    public class BinarioADecimal : FormulaMatematica
    {
        public long Binario { get; set; }

        public override string Calcular()
        {
            int numero = 0;
            int digito = 0;
            const int DIVISOR = 10;

            for(long i=Binario, j=0; i>0; i/=DIVISOR, j++)
            {
                digito = (int)i % DIVISOR;
                if(digito!=1 && digito != 0)
                {
                    return "No se puede convertir a un número decimal.";
                }
                numero += digito * (int)Math.Pow(2, j);
            }
            return numero.ToString();
        }

        public override void Imprimir()
        {
            Console.WriteLine($"El número binario {Binario} convertido a decimal es {Calcular()}");
        }
    }
}
