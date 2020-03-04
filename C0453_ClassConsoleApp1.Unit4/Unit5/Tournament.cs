using System;
using System.Collections.Generic;
using System.Text;

namespace C0453_ClassConsoleApp1.Unit4.Unit5

{
    /// <summary>
    /// Task 5.1 and Task 5.3
    /// This class gets and displays an array of tournament 
    /// scores for an array of players ( names)
    /// </summary>
    /// Georgia Gkegka
    class Tournament
    {
        public const int MAXN_SCORES = 6;

        // Another way of initialising attributes
        private int[] scores = new int[MAXN_SCORES];

        //not created yet
        private string[] names;

        /// <summary>
        /// Class Constructor (not needed)
        /// </summary>
        public Tournament()
        {
            scores = new int[MAXN_SCORES];
            names = new string[]
            {
                "Godfrey",
                "Eric",
                "Georgia",
                "Dylan",
                "Oluyemi",
                "Shamial"
            };
        }

        /// <summary>
        /// Asks for scores, and then stores it as an integer
        /// </summary>
        public void GetScores()
        {
            SimpleIO.WriteTitle("Enter Tournament Scores", "Task 5.1");
        for (int index = 0; index < MAXN_SCORES; index++)
            {
                Console.Write("Enter score for player" + (index + 1) + " > ");
                scores[index] = Convert.ToInt32(Console.ReadLine());
            }
        }

        /// <summary>
        /// This will take the names and scores for all the players
        /// </summary>
        public void GetDetails()
        {
            SimpleIO.WriteTitle("Enter Tournament Scores", "Task 5.1");

            for (int i = 0; i < MAXN_SCORES; i++)
            {
                Console.WriteLine("Enter name for player" + (i + 1));
                names[i] = Console.ReadLine();

                Console.WriteLine("Enter score for  player" + (i + 1));
                scores[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        ///summary
        ///Shows the players and their scores to the user
        ///</summary>
        public void ShowDetails() 
        {
            SimpleIO.WriteTitle(" Show Tournament scores ", "Task 5.1");

            for (int i = 0; i < MAXN_SCORES; i++) 
            {
                Console.WriteLine(" Player " + names[i] + " scored " + scores[i]);
            }
        }
    }
}
