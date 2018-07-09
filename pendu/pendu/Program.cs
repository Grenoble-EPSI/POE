using System;

namespace pendu
{
    class Program
    {
        static string entree;
        static string entreeMajuscule;
        static string lettresEntrees = "";

        static void Main(string[] args)
        {
            Console.WriteLine("Jeu du pendu");

            string mot = "FOX";
            while (!IsOver(mot))
            {
                // Fonction prise en compte de l'input et affichage de celle ci.
                Console.WriteLine("ENTRER UNE LETTRE !");
                entree = Console.ReadLine();
                entreeMajuscule = entree.ToUpper(); // Fonction qui passe la lettre en majuscules 
                lettresEntrees += entreeMajuscule;

                // Test pour savoir si la lettre entrée par l'utilisateur est dans le mot choisi
                if (mot.Contains(entreeMajuscule))
                {
                    Console.WriteLine($"Bravo the charactere {entreeMajuscule} is in the word");
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
    }
}

