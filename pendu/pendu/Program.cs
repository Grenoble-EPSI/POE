using System;

namespace pendu
{
    class Program
    {
        static string entree;
        static string lettresEntrees;
        static void Main(string[] args)
        {
            Console.WriteLine("ENTRER UNE LETTRE !");
            entree = Console.ReadLine();
            lettresEntrees += entree;
            Console.WriteLine("entrée :" + entree + " lettres entrées :" + lettresEntrees);
        }
    }
}
