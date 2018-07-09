using System;

namespace pendu
{
    class Program
    {
        static string entree;
        static string lettresEntrees;
        static void Main(string[] args)
        {
            Console.WriteLine("Jeu du pendu");

            while (!IsOver())
            {
                Console.WriteLine("ENTRER UNE LETTRE !");
                entree = Console.ReadLine();
                lettresEntrees += entree;
                Console.WriteLine("entrée :" + entree + " lettres entrées :" + lettresEntrees);
            }

        }

        private static bool IsOver()
        {
            
            return false;
        }
    }
}
