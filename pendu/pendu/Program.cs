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

            remainingSeconds = 60;
            Mot mot = Mot.CreateMot();

            while (!IsOver(mot))
            {
                DisplayTimeCount();

                // Fonction prise en compte de l'input et affichage de celle ci.


                Console.WriteLine($"Essai n°{nbEssai()} ENTRER UNE LETTRE !");
                
             

                string entree = Console.ReadLine().ToUpper();
                

                // Test pour savoir si la lettre entrée par l'utilisateur est dans le mot choisi
                if (mot.Contains(entree))
                
                // Test pour savoir si la lettre a déjà été entré par l'utilisateur
                { if (lettresEntrees.Contains(entree))

                    {
                        Console.WriteLine($" Caractère déja sésie");
                    }
                    else
                    {

                        Console.WriteLine($"Bravo {entree} contunier");
                    }
                }
                
                else
                {
                    Console.WriteLine("Ce n'est pas correcte, réessayer encore");
                }

                // Ajout du caractère tapé par l'utilisateur dans une chaine de caractère, pour sauvegarder les entrées
                lettresEntrees += entree;
            }

            Console.WriteLine("Bravo ! Tu as trouvé le mot !");

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

