using System;

namespace pendu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Lettre pste ds mot

            string mot = "fox";
            string caratereTape = "f";
            if (mot.Contains(caratereTape))
            {
                Console.WriteLine($"Bravo the charactere {caratereTape} is in the word");
            }
            else
            {
                Console.WriteLine("You are wrong, try again");
            }



            Console.ReadKey();
        }
    }
}
