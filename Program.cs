using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRYSTAL_GAME
{
    internal class Program
    {
        class Controul
        {
            public void Play()
            {
                Afficher to_Writ = new Afficher();
                var Color = new Color();

                List<string> mots = new List<string> { "developpeur", "ordinateur" };//, "programmation", "", "apprentissage", "javascript", "cs", "console", "writeline", "game", "bool", "git", "string", "readline", "source", "extensions", "analyser" 

                Random rand = new Random();
                string motSecret = mots[rand.Next(0, mots.Count)];
                char[] motCache = new char[motSecret.Length];
                for (int i = 0; i < motSecret.Length; i++)
                {

                    motCache[i] = '?';

                }
                int viesRestantes = 6;
                int PointScour = 1;
                int b = 0;
                List<char> lettresEssayees = new List<char>();
                int score = 0;
                /*-----------------------------------------\|/____(o_o)____\|/-----------------------*/
                bool bn = false;
                while (bn == false ) 
                {
                    int k = 1;
                    do
                    {
                        Console.Clear();
                        Color.DarkBlue();
                        to_Writ.dd(30, 5, $"Welcome to the Hangman game!");
                        Color.ColorNormal();
                        Color.Yellow();
                        to_Writ.dd(30, 8, $"Guess the secret word.");
                        Color.ColorNormal();
                        Color.Yellow();
                        to_Writ.dd(5, 10, $"Secret word : " + new string(motCache));
                        to_Writ.dd(5, 12, $"Letters tried   " + string.Join(", ", lettresEssayees));
                        to_Writ.dd(5, 14, $"Remaining lives  : " + viesRestantes);
                        to_Writ.dd(5, 16, $"Enter a letter : ");
                        char lettre = Console.ReadLine()[0];
                        if (lettresEssayees.Contains(lettre))
                        {
                            Color.DarkRed();
                            to_Writ.cdd(50, 10, "You have to write this letter . ");
                            Color.ColorNormal();
                            continue;
                        }
                        lettresEssayees.Add(lettre);
                        if (motSecret.Contains(lettre))
                        {
                            for (int i = 0; i < motSecret.Length; i++)
                            {

                                if (motSecret[i] == lettre)
                                {
                                    motCache[i] = lettre;

                                }

                            }
                            PointScour *= 5;
                        }
                        else
                        {
                            viesRestantes--;
                            Console.WriteLine("\n\n");
                        }
                        if (!motCache.Contains('?'))                                //???
                        {
                            Console.Clear();
                            b = (PointScour / viesRestantes);
                            if (b <= (PointScour / 6))
                            {
                                Color.Red();
                                to_Writ.dd(75, 12, "very good ");
                                Color.ColorNormal();

                            }
                            else if (b <= (PointScour / 5))
                            {
                                Color.DarkMagenta();
                                to_Writ.dd(75, 12, "good");
                                Color.ColorNormal();
                            }
                            else if (b <= (PointScour / 4))
                            {
                                Color.Yellow();
                                to_Writ.dd(75, 12, "It's okay for you");
                                Color.ColorNormal();
                            }
                            else if (b <= (PointScour / 3))
                            {
                                Color.DarkBlue();
                                to_Writ.dd(75, 12, "Better luck next time");
                                Color.ColorNormal();
                            }
                            else if (b <= (PointScour / 2))
                            {
                                Color.DarkGreen();
                                to_Writ.dd(75, 12, "very bad");
                                Color.ColorNormal();
                            }
                            else
                            {
                                Color.Cyan();
                                to_Writ.dd(75, 12, "**************************");
                                Color.ColorNormal();
                            }
                            Color.Green();
                            to_Writ.dd(30, 5, "**** See you in for a new game ****");
                            Color.ColorNormal();
                            to_Writ.dd(5, 10, $"Congratulations, you have guessed the secret word: " + motSecret);
                            to_Writ.dd(75, 10, "Scoure Point : " + PointScour);
                            to_Writ.dd(75, 15, "Average score : " + b);
                            score++;
                            to_Writ.dd(5, 12, $"Your current score: " + score);
                            to_Writ.dd(5, 14, $"Do you want to play again? (Yes No) : ");
                            //Color.ColorNormal();
                            string reponse = Console.ReadLine();
                            if (reponse.ToLower() == "y")
                            {
                                motSecret = mots[rand.Next(0, mots.Count)];
                                motCache = new char[motSecret.Length];
                                for (int i = 0; i < motSecret.Length; i++)
                                {
                                    motCache[i] = '?';
                                }
                                viesRestantes = 6;
                                lettresEssayees.Clear();
                            }
                            else
                            {
                                to_Writ.dd(5, 10, "Thanks for playing!");
                                break;
                            }
                            Color.ColorNormal();
                        }
                    } while (viesRestantes > 0);

                    if (viesRestantes == 0)
                    {
                        Console.Clear();
                        Color.Cyan();
                        to_Writ.dd(5, 10, "Sorry, you lost. The secret word was: " + motSecret);
                        to_Writ.dd(5, 12, "Your final score: " + score);
                        to_Writ.dd(5, 14, @"Do you want to play again? (Yes No) : ");
                        string reponse = Console.ReadLine();
                        do
                        {
                            int q = 1;
                            q++;
                            if (reponse.ToLower() == "y")
                            {
                                bn = false; // Redémarre le jeu      ???
                            }
                            else if (reponse.ToLower() == "n")
                            {
                                Console.Clear();
                                Color.Cyan();
                                to_Writ.dd(30, 15, "Thanks for playing!");
                                Console.ReadKey();
                                bn = true;
                            }
                            else
                            {
                                reponse = " ";
                                to_Writ.cdd(30, 15, "The option does not exist :: ");
                                bn = false;
                            }
                        } while (reponse.ToLower() == "n");
                        
                        
                        Color.ColorNormal();
                    }
                    k++;
                }
            }
        }
        static void Main(string[] args)
        {
            var GoWrite = new Afficher();
            var controul = new Controul();
            var color = new Color();
            int f = 1;
            int i;
            bool bl = false;
            do
            {
                f++;
                Console.Clear();
                color.DarkMagenta();
                GoWrite.dd(45, 5, " CRYSTAL GAME ");
                color.ColorNormal();
                color.DarkGreen();
                GoWrite.dd(5, 9, "1 :: Play ");
                GoWrite.dd(5, 11, "***********");
                GoWrite.dd(5, 13, "3 :: Exit the crystal game  ");
                GoWrite.dd(5, 15, "Choose a game number :: ");
                int.TryParse(Console.ReadLine(), out i);
                color.ColorNormal();
                /*______________________________\|/______( *_* )______\|/__________________________________*/
                if (i == 1)
                {
                    try
                    {
                        controul.Play();
                    }
                    catch (Exception e)
                    {
                        color.Red();
                        Console.SetCursorPosition(50, 10);
                        Console.WriteLine(e.Message);
                        color.ColorNormal();
                    }
                    finally
                    {
                        controul.Play();
                    }
                    bl = false;
                }
                else if (i == 3)
                {
                    try
                    {
                        Console.Clear();
                        color.Blue();
                        GoWrite.dd(30, 10, "**** GAME OVER  ****");
                        
                        Console.ReadKey();
                        color.ColorNormal();
                        bl = true;
                    }
                    catch (Exception e)
                    {
                        color.Red();
                        Console.SetCursorPosition(10, 10);
                        Console.WriteLine(e.Message);
                        color.ColorNormal();
                    }                  
                }
                else
                {
                    color.DarkBlue();
                    GoWrite.cdd(30, 10, "The entry is not available among the options ");
                    bl = true ;
                    color.ColorNormal();
                }
                color.ColorNormal();
            } while ((i == 3) && (bl == false ));
        }
    }   
}
