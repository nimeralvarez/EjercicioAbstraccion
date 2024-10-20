
using EjercicioAbstraccion;

int opcion;

do
{
    Console.WriteLine("*****************************************");
    Console.WriteLine("    SELECCIONE ALGUNA DE LAS FORMULAS    ");
    Console.WriteLine("*****************************************");
    Console.WriteLine("1. Convertir decimal a binario");
    Console.WriteLine("2. Converti binario a decimal");
    Console.WriteLine("3. Convertir gigabyte a kilobyte");
    Console.WriteLine("4. Salir");
    Console.Write("Ingrese el número de la opción: ");
    opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion)
    {
        case 1:

            DecimalABinario decimalABinario = new DecimalABinario();
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("       CONVERTIR DECIMAL A BINARIO       ");
            Console.WriteLine("-----------------------------------------");
            Console.Write("Ingrese un numero entero a convertir: ");
            decimalABinario.NumeroEntero = Convert.ToInt32(Console.ReadLine());

            decimalABinario.Calcular();
            decimalABinario.Imprimir();

            break;
        case 2:

            BinarioADecimal binarioADecimal = new BinarioADecimal();
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("       CONVERTIR BINARIO A DECIMAL       ");
            Console.WriteLine("-----------------------------------------");
            Console.Write("Ingrese un numero binario a convertir: ");
            binarioADecimal.Binario = Convert.ToInt32(Console.ReadLine());

            binarioADecimal.Calcular();
            binarioADecimal.Imprimir();

            break;
        case 3:

            GigabyteAKilobyte gigabyteAKilobyte = new GigabyteAKilobyte();
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("       CONVERTIR GIGABYTE A KILOBYTE     ");
            Console.WriteLine("-----------------------------------------");
            Console.Write("Ingrese la cantidad de gigabyte a convertir: ");
            gigabyteAKilobyte.Gigabyte = Convert.ToDouble(Console.ReadLine());

            gigabyteAKilobyte.Calcular();
            gigabyteAKilobyte.Imprimir();

            break;
        case 4:
            Console.WriteLine("Salir de la aplicación.");
            break;
        default:
            Console.WriteLine("Ingrese un numero valido.");
            break;
    }
    Console.WriteLine("\n");
} while (opcion!=4);
