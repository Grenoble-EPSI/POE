using System;

namespace pendu
{
    class Program
    {
        static string entree;
        static string lettresEntrees;
        static void Main(string[] args)
        {
            // Fonction prise en compte de l'input et affichage de celle ci.
            Console.WriteLine("ENTRER UNE LETTRE !");
            entree = Console.ReadLine();
            lettresEntrees += entree;
            Console.WriteLine("entrée :" + entree + " lettres entrées :" + lettresEntrees);
        }
    }
}
