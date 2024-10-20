using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAbstraccion
{
    public class DecimalABinario : FormulaMatematica
    {
        public int NumeroEntero { get; set; }

        public override string Calcular()
        {
            string binario = "";

            if (NumeroEntero > 0)
            {
                int numero = NumeroEntero;
                while(numero > 0)
                {
                    if(numero % 2 == 0)
                    {
                        binario = "0" + binario;
                    }
                    else
                    {
                        binario = "1" + binario;
                    }
                    numero = (int)numero/ 2;
                }
            }else if(NumeroEntero == 0)
            {
                binario = "0";
            }
            else
            {
                binario = "No se puede convertir el numero, ingrese solo numeros positivos.";
            }

            return binario;
        }

        public override void Imprimir()
        {
            Console.WriteLine($"El número decimal {NumeroEntero} convertido a binario es {Calcular()}");
        }
    }
}
