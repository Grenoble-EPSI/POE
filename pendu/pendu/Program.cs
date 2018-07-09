using System;

namespace pendu
{
   
    class Program
    {
        static int i=0;
        static string lettresEntrees = "";
        static void Main(string[] args)
        {
            Console.WriteLine("Jeu du pendu");

            
    
            
            Mot mot = Mot.CreateMot();
            while (!IsOver(mot))
            {

                // Fonction prise en compte de l'input et affichage de celle ci.
                Console.WriteLine($"Essai n°{nbEssai()} ENTRER UNE LETTRE !");
                string entree = Console.ReadLine();
                lettresEntrees += entree;

                // Test pour savoir si la lettre entrée par l'utilisateur est dans le mot choisi
                if (mot.Contains(entree))
                
                { if (!(lettresEntrees.Contains(entree)))

                    {
                        Console.WriteLine($"Bravo the charactere {entree} is in the word");
                    }
                    else
                    {
                        Console.WriteLine("you already used this character");
                    }
                }
                
                else
                {
                    Console.WriteLine("You are wrong, try again");
                }
            }

            Console.WriteLine("Bravo ! Tu as trouvé le mot !");

            Console.ReadKey();
        }


         static int nbEssai()
        {
            return ++i;
        }

        private static bool IsOver(Mot mot)
        {
            return mot.HaveAllLeters(lettresEntrees);
        }
  
    }
}

