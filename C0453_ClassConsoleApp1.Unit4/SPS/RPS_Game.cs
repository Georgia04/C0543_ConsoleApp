using System;
using System.Collections.Generic;
using System.Text;

namespace C0453_ClassConsoleApp1.Unit4.SPS
{
    public enum RPS_Players
    {
        NONE,
        COMPUTER,
        PLAYER
    }

    public enum RPS_Choices
    {
        UNKOWN,
        ROCK,
        PAPER,
        SCISSORS,
    }
     class RPS_Game
    {
        public const string COMPUTER_NAME = "Computer";

        public string PlayerName { get; set; }
        //public string ComputerName { get; set; }
        public string WinnerName { get; set; }

        public RPS_Choices ComputerChoice { get; set; }
        public RPS_Choices PlayerChoice { get; set; }

        private Random randomGenerator = new Random();

        public int PlayerScore { get; set; }
        public int ComputerScore { get; set; }

        public void Start(string player)
        {
            PlayerName = player;
            WinnerName = "Unkown";
        }

        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        public void End()
        {
        }

        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        public void GetComputerChoice()
        {
            int choice;
            choice = randomGenerator.Next(3);

            if (choice == 0)
            {
                ComputerChoice = RPS_Choices.ROCK;
            }
            else if (choice == 1)
            {
                ComputerChoice = RPS_Choices.PAPER;
            }
            else ComputerChoice = RPS_Choices.SCISSORS;
        
    }


        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        public void WorkoutWinner()
        {
            if (PlayerChoice == ComputerChoice)

            {
                WinnerName = "You have Drawn!!!";
                PlayerScore++;
                ComputerScore++;
            }
            else if (PlayerChoice == RPS_Choices.ROCK &&
                   ComputerChoice == RPS_Choices.SCISSORS)
            {
                WinnerName = PlayerName;
                PlayerScore = PlayerScore + 2;
            }
            else if (PlayerChoice == RPS_Choices.PAPER &&
                    ComputerChoice == RPS_Choices.ROCK)
            {
                WinnerName = PlayerName;
                PlayerScore = PlayerScore + 2;

            }
            else if (PlayerChoice == RPS_Choices.SCISSORS &&
                    ComputerChoice == RPS_Choices.PAPER)
            {
                WinnerName = PlayerName;
                PlayerScore = PlayerScore + 2;

            }
            else if (PlayerChoice == RPS_Choices.ROCK &&
                     ComputerChoice == RPS_Choices.PAPER)
            {
                WinnerName = COMPUTER_NAME;
                ComputerScore = ComputerScore + 2;
            }
            else if (PlayerChoice == RPS_Choices.PAPER &&
                     ComputerChoice == RPS_Choices.SCISSORS)
            {
                WinnerName = COMPUTER_NAME;
                ComputerScore = ComputerScore + 2;

            }
            else if (PlayerChoice == RPS_Choices.SCISSORS &&
                    ComputerChoice == RPS_Choices.ROCK)
            {
                WinnerName = COMPUTER_NAME;
                ComputerScore = ComputerScore + 2;

            }

        }
        public void GameWinner() 
        {
            if (PlayerScore > ComputerScore)
            {
                Console.WriteLine("The winner is" + PlayerName);
                Images.DrawThumbsUp();
            }
            else if (PlayerScore < ComputerScore)
            {
                Console.WriteLine("The winner is the" + COMPUTER_NAME);
                Images.DrawThumbsDown();
            }
            else 
            {
                Console.WriteLine("It's a draw");
                Images.DrawSmile();
            }

        }
    }
            
                
            }

        
    


