using System;

namespace pendu
{
    class Program
    {
        static string entree;
        static string lettresEntrees = "";
        static string mot = "fox";
        static void Main(string[] args)
        {
            Console.WriteLine("Jeu du pendu");

            while (!IsOver(mot))
            {
                // Fonction prise en compte de l'input et affichage de celle ci.
                Console.WriteLine("ENTRER UNE LETTRE !");
                entree = Console.ReadLine();
                lettresEntrees += entree;

                // Test pour savoir si la lettre entrée par l'utilisateur est dans le mot
                if (mot.Contains(entree))
                {
                    Console.WriteLine($"Bravo the charactere {entree} is in the word");
                }
                else
                {
                    Console.WriteLine("You are wrong, try again");
                }
            }

            Console.WriteLine("Bravo ! Tu as trouvé le mot !");

            Console.ReadKey();
        }

        private static bool IsOver(string mot)
        {
            for(int i = 0; i < mot.Length ; i++)
            {
                if (!lettresEntrees.Contains(mot.Substring(i, 1)))
                {
                    return false;
                }
            }

            return true;
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

