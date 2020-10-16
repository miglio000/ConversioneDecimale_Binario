using Microsoft.VisualBasic.CompilerServices;
using System;

namespace ConversioneDecimale_Binario
{
    class Program
    {
        static void Main(string[] args)
        {

            int num, resto, valorebase, temp;
            string numconvertito = "";
            Console.WriteLine("Inserire un numero da convertire:");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserire la base in cui convertire il numero (basi da 2 a 16):");
            valorebase = Convert.ToInt32(Console.ReadLine());
            temp = num;
            if (valorebase > 16 || valorebase < 2)
            {
                Console.WriteLine("Non puoi convertire in basi sopra la esadecimale.");
                Console.WriteLine("Non puoi convertire in una base minore della binaria.");
            }
            else
            {
                while (num > 0)
                {
                    resto = num % valorebase;
                    num /= valorebase;
                    switch (resto)
                    {
                        case 10:
                            numconvertito = "A";
                            break;
                        case 11:
                            numconvertito = "B";
                            break;
                        case 12:
                            numconvertito = "C";
                            break;
                        case 13:
                            numconvertito = "D";
                            break;
                        case 14:
                            numconvertito = "E";
                            break;
                        case 15:
                            numconvertito = "F";
                            break;
                        default:
                            numconvertito = Convert.ToString(resto) + numconvertito;
                            break;
                    }
                }
                Console.WriteLine($"Il numero {temp} in base {valorebase} è: {numconvertito}.");
            }
            Console.ReadLine();
        }
    }
}

