using System;

namespace pendu
{
    class Program
    {
        static string entree;
        static string lettresEntrees;
        static void Main(string[] args)
        {
            string mot = "bateau";

            Console.WriteLine("Jeu du pendu");

            while (!IsOver())
            {
                Console.WriteLine("ENTRER UNE LETTRE !");
                entree = Console.ReadLine();
                lettresEntrees += entree;
                Console.WriteLine("entrée :" + entree + " lettres entrées :" + lettresEntrees);

                /*if(verifLettre(entree, mot))
                {
                    Console.WriteLine("lettre valide");
                }
                else
                {
                    Console.WriteLine("lettre non valide");
                }*/
            }

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
