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
                // Fonction prise en compte de l'input et affichage de celle ci.
                Console.WriteLine("ENTRER UNE LETTRE !");
                entree = Console.ReadLine();
                lettresEntrees += entree;

                // Test pour savoir si la lettre entrée par l'utilisateur est dans le mot
                string mot = "fox";
                if (mot.Contains(entree))
                {
                    Console.WriteLine($"Bravo the charactere {entree} is in the word");
                }
                else
                {
                    Console.WriteLine("You are wrong, try again");
                }
            }

            Console.ReadKey();
        }

        private static bool IsOver()
        {
            
            return false;
        }

        private static bool VerifLettre(string lettre, string mot)
        {
            bool lettreValide = false;
            for (int i = 0; i < mot.Length ; i++ )
            {
                if (lettre == mot.Substring(i, 1))
                {
                    Console.WriteLine(mot.Substring(i, 1));
                    lettreValide = true;
                    break;
                }
            }
            

            return lettreValide;
        }
    }
}

