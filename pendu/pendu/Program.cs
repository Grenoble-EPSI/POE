using System;
using System.Timers;

namespace pendu
{
    class Program
    {
        static string lettresEntrees = "";
        static void Main(string[] args)
        {
            Console.WriteLine("Jeu du pendu");

            int nbessai = 0;
    
            
            Mot mot = Mot.CreateMot();

            Console.Write("Temps écoulé : ");

            DisplayTimeCount();

            while (!IsOver(mot))
            {
                // Fonction prise en compte de l'input et affichage de celle ci.

                Console.WriteLine($"Essai n°{++nbessai} ENTRER UNE LETTRE !");
                string entree = Console.ReadLine().ToUpper();
                

                // Test pour savoir si la lettre entrée par l'utilisateur est dans le mot choisi
                if (mot.Contains(entree))
                
                // Test pour savoir si la lettre a déjà été entré par l'utilisateur
                { if (lettresEntrees.Contains(entree))

                    {
                        Console.WriteLine($"you already used this character");
                    }
                    else
                    {
                        Console.WriteLine($"Bravo the charactere {entree} is in the word");
                    }
                }
                
                else
                {
                    Console.WriteLine("You are wrong, try again");
                }

                // Ajout du caractère tapé par l'utilisateur dans une chaine de caractère, pour sauvegarder les entrées
                lettresEntrees += entree;
            }

            Console.WriteLine("Bravo ! Tu as trouvé le mot !");

            Console.ReadKey();
        }

        private static void DisplayTimeCount()
        {
            //Récupere la position du pointeur console pour mettre a jour le compteur de temps
            var cursorPositionTimeLeft = Console.CursorLeft;
            var cursorPositionTimeTop = Console.CursorTop;

            //Création du timer
            var remainingSeconds = 60;
            var timer = new Timer(1000);
            timer.Elapsed += (e, a) =>
            {
                //Récupere la position du curseur au moment de la mise a jour
                var currentPosLeft = Console.CursorLeft;
                var currentPosTop = Console.CursorTop;

                //Se positionne a la bonne position pour réécrire le temps
                Console.SetCursorPosition(cursorPositionTimeLeft, cursorPositionTimeTop);
                Console.Write(remainingSeconds-- + " secondes          ");

                //Se repositionne à la position initiale
                Console.SetCursorPosition(currentPosLeft, currentPosTop);
            };

            //Ajout d'un retour a la ligne et lancement du timer
            Console.WriteLine("");
            timer.Start();
        }

        private static int nbEssai(int i)
        {
            return i++;
        }

        private static bool IsOver(Mot mot)
        {
            return mot.HaveAllLeters(lettresEntrees);
        }
  
    }
}

