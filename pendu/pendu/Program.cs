using System;
using System.Timers;

namespace pendu
{
   
    class Program
    {
        static int i=0;
        static string lettresEntrees = "";
        static Timer timer = null;
        static int remainingSeconds;

        static void Main(string[] args)
        {
            Console.WriteLine("Jeu du pendu");

            remainingSeconds = 10;
            Mot mot = Mot.CreateMot();

            while (!IsOver(mot) && remainingSeconds > 0)
            {
                DisplayTimeCount();

                // Fonction prise en compte de l'input et affichage de celle ci.
                
                Console.WriteLine();
                Console.WriteLine($"Essai n°{nbEssai()} Entrez une lettre !");

                string entree = Console.ReadLine().ToUpper();

                //Si le temps est écoulé, on arrète maintenant
                if(remainingSeconds <= 0)
                {
                    break;
                }

                // Test pour savoir si la lettre entrée par l'utilisateur est dans le mot choisi
                if (mot.Contains(entree))
                {
                    if (lettresEntrees.Contains(entree))
                    {
                        Console.WriteLine($" Lettre déja saisie");
                    }
                    else
                    {
                        Console.WriteLine($"Bravo! {entree} Continuez !");
                    }
                }
                
                else
                {
                    Console.WriteLine("Manqué, essayez encore !");
                }

                // Ajout du caractère tapé par l'utilisateur dans une chaine de caractère, pour sauvegarder les entrées
                lettresEntrees += entree;
            }

            //Affichage du message de fin, si le joueur a bien trouvé toutes les lettres, il à gagné
            if(IsOver(mot))
            {
                Console.WriteLine("Bravo ! Vous avez touvé le bon mot !");
            }

            Console.ReadKey();
        }
        
        // methode qui sert à incrementer le compteur
        static int nbEssai()
        {
            return ++i;
        }

        private static void DisplayTimeCount()
        {
            Console.Write("Temps écoulé : ");

            //Récupere la position du pointeur console pour mettre a jour le compteur de temps
            var cursorPositionTimeLeft = Console.CursorLeft;
            var cursorPositionTimeTop = Console.CursorTop;
            Console.Write(remainingSeconds-- + " secondes          ");

            //Supression ancien timer
            if(timer != null)
            {
                timer.Stop();
            }

            //Création du timer
            timer = new Timer(1000);
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

                if(remainingSeconds < 0)
                {
                    Console.WriteLine("Dommage ! Tu as perdu petit asticot !");
                    timer.Stop();
                }
            };

            //Ajout d'un retour a la ligne et lancement du timer
            Console.WriteLine("");
            timer.Start();
        }

        private static bool IsOver(Mot mot)
        {
            return mot.HaveAllLeters(lettresEntrees);
        }
    }
}

