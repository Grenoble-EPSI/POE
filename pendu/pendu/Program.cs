using System;
using System.Timers;


namespace pendu
{
   
    class Program
    {
        static int essais;
        static string lettresEntrees = "";
        static Timer timer = null;
        static int remainingSeconds;

        static void Main(string[] args)
        {

            string path = "dictionnaire.txt";
                     
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Jeu du pendu");
           
            remainingSeconds = 100;
           

       

            //Boucle du jeu
            do
            {
                //Initialisation
                lettresEntrees = "";
                remainingSeconds = 100;
                essais = 0;
                Mot mot = Mot.CreateMot();

                //Actions
                while (!IsOver(mot) && remainingSeconds > 0)
                {
                    DisplayTimeCount();
                    Console.WriteLine(DisplayWordResult(mot));

                    // Fonction prise en compte de l'input et affichage de celle ci.
                    Console.WriteLine();
                    Console.WriteLine($"Essai n°{nbEssai()} Entrez une lettre !");

                    string entree = Console.ReadLine().ToUpper();

                    //Si le temps est écoulé, on arrète maintenant
                    if (remainingSeconds <= 0)
                    {
                        break;
                    }

                    // Test pour savoir si la lettre entrée par l'utilisateur est dans le mot choisi
                    if (mot.Contains(entree))
                    {
                        if (lettresEntrees.Contains(entree))
                        {
                            DisplayColor("Caractère déja entré", ConsoleColor.Red);
                        }
                        else
                        {
                            DisplayColor($"Bravo! {entree} Continuez !", ConsoleColor.Green);
                        }
                    }
                    else
                    {
                        if (lettresEntrees.Contains(entree))
                        {
                            DisplayColor("Caractère déja entré", ConsoleColor.Red);
                        }
                        else
                        {
                            DisplayColor("Manqué, essayez encore !", ConsoleColor.Red);
                        }
                    }

                    // Ajout du caractère tapé par l'utilisateur dans une chaine de caractère, pour sauvegarder les entrées
                    lettresEntrees += entree;
                    RefreshConsole();
                }

                timer.Stop();


                //Affichage du message de fin, si le joueur a bien trouvé toutes les lettres, il à gagné
                if (IsOver(mot))
                {
                    Console.Clear();
                    DisplayColor("Bravo ! Tu as gagné !", ConsoleColor.Green);
                }
                
                Console.WriteLine("Voulez vous continuer? Y/N");

            } while (Console.ReadLine().ToUpper() == "Y");


            Console.ReadKey();
        }

        private static void ClearConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);

        }

        private static void RefreshConsole()
        {
            for(int i = 0; i < 3; i++)
            {
                Console.SetCursorPosition(1, Console.CursorTop - 2);
                ClearConsoleLine();
            }
        }



        private static string DisplayWordResult(Mot mot)
        {
            string result = "";
            for(int i = 0; i < mot.Length; i++)
            {
                if (lettresEntrees.Contains(mot.GetChar(i).ToString()))
                {
                    result += mot.GetChar(i);
                } else
                {
                    result += "-";
                }
            }
            return result;
           
        }


        // methode qui sert à incrementer le compteur
        static int nbEssai()
        {
            return ++essais;
        }

        private static void DisplayTimeCount()
        {
            Console.Write("Temps écoulé : ");

            //Récupere la position du pointeur console pour mettre a jour le compteur de temps
            var cursorPositionTimeLeft = Console.CursorLeft;
            var cursorPositionTimeTop = Console.CursorTop;
            DisplayRemainingSeconds();

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
                DisplayRemainingSeconds();

                //Se repositionne à la position initiale
                Console.SetCursorPosition(currentPosLeft, currentPosTop);

                if(remainingSeconds < 0)
                {
                    DisplayColor("Dommage ! Tu as perdu petit asticot !", ConsoleColor.Red);
                    timer.Stop();
                }
            };

            //Ajout d'un retour a la ligne et lancement du timer
            Console.WriteLine("");
            timer.Start();
        }

        static void DisplayRemainingSeconds()
        {
            remainingSeconds--;

            if(remainingSeconds <= 10)
            {
                DisplayColor(remainingSeconds + " secondes          ", ConsoleColor.Red);
            }
            else
            {
                Console.Write(remainingSeconds + " secondes          ");
            }
        }

        private static bool IsOver(Mot mot)
        {
            return mot.HaveAllLeters(lettresEntrees);
        }

        private static void DisplayColor(string sentence, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(sentence);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}

