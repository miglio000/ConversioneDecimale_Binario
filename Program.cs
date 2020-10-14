using Microsoft.VisualBasic.CompilerServices;
using System;

namespace ConversioneDecimale_Binario
{
    class Program
    {
        static void Main(string[] args)
        {

            int num, resto, resto8, resto16, temp;
            Console.WriteLine("Inserire il numero da convertire:");
            num = int.Parse(Console.ReadLine());
            string binario = "";
            string ottale = "";
            string esadecimale = "";
            while (num > 0)
            {
                resto = num % 2;
                num /= 2;
                binario = Convert.ToString(resto) + binario;
            }
            num = temp;

            
            Console.WriteLine($"Il numero in binario è {binario}");
            Console.WriteLine($"Il numero in ottale è {ottale}");
            Console.WriteLine($"Il numero in esadecimale è {esadecimale}");
            Console.ReadLine();






        }
    }
}
