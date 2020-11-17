using System;

namespace Taschenrechner_Iteration_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bitte gib den ersten Summanden ein: ");
            string ersterSummand = Console.ReadLine();
            Console.Write("Bitte gib den zweiten Summanden ein: ");
            string zweiterSummand = Console.ReadLine();

            // Wandel Text in Ganzahl um

            int ersterSummandAlsZahl = Convert.ToInt32(ersterSummand);
            int zweiterSummandAlsZahl = Convert.ToInt32(zweiterSummand);

            int ergebnis = ersterSummandAlsZahl + zweiterSummandAlsZahl;
            Console.WriteLine("Die Summe ist: " + ergebnis);
            Console.ReadLine();
        }
    }
}
