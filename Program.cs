using Microsoft.VisualBasic.CompilerServices;
using System;

namespace ConversioneDecimale_Binario
{
    class Program
    {
        static void Main(string[] args)
        {

            int num, resto;
            Console.WriteLine("Inserire il numero da convertire:");
            num = Convert.ToInt32(Console.ReadLine));
            string binario = "";
            while (num 0){
                resto = num % 2;
                num /= 2;
                binario = Convert.ToString(resto) + binario;

            }
            Console.WriteLine($"Il numero in binario è {binario}");




            
            
        }
    }
}
