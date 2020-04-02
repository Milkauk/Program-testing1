using System;

namespace Studiolaskin
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Valitse laskutoimitus: 1 = [+], 2 = [-], 3 = [*], 4 = [/], 5 = (break)");
                int valinta = Convert.ToInt32(Console.ReadLine());
                if (valinta == 5)
                {
                    break;
                }
                Console.WriteLine("Anna ensimmäinen luku: ");
                int luku1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Anna toinen luku: ");
                int luku2 = Convert.ToInt32(Console.ReadLine());

                if (valinta == 1)
                {
                    int tulos = calculator.Add(luku1, luku2);
                    Console.WriteLine("Lukujen summa on: " + (tulos));
                    Console.ReadKey();
                }
                if (valinta == 2)
                {
                    int tulos = calculator.Deduct(luku1, luku2);
                    Console.WriteLine("Lukujen erotus on: " + (tulos));
                    Console.ReadKey();
                }
                if (valinta == 3)
                {
                    int tulos = calculator.Times(luku1, luku2);
                    Console.WriteLine("Lukujen tulo on: " + (tulos));
                    Console.ReadKey();
                }
                if (valinta == 4)
                {
                    int tulos = calculator.Divide(luku1, luku2);
                    Console.WriteLine("Lukujen osamäärä on: " + (tulos));
                    Console.ReadKey();
                }
            }
        }
    }
    public class Calculator
    {
        public int Add(int luku1, int luku2)
        {
            return luku1 + luku2;
        }
        public int Deduct(int luku1, int luku2)
        {
            return luku1 - luku2;
        }
        public int Times(int luku1, int luku2)
        {
            return luku1 * luku2;
        }
        public int Divide(int luku1, int luku2)
        {
            return luku1 / luku2;
        }
    }
}
