using System;

namespace pendu
{
    class Program
    {
        static string entree;
        static string lettresEntrees;
        static void Main(string[] args)
        {
<<<<<<< HEAD
            Console.WriteLine("Hello World!");
            //Console.ReadKey();
            
            string mot = "fox";
            string caractereTape =  "f";

            if (mot.Contains(caractereTape))
            {
                Console.WriteLine("ok");
            }
            else Console.WriteLine(" not ok");
=======
          

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

>>>>>>> d796d3a9fa3d5eb890712d3a3117a6346ba74409
            Console.ReadKey();
        }
    }
}

