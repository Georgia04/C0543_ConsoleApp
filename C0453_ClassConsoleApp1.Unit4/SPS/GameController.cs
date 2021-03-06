﻿using System;
using System.Collections.Generic;
using System.Text;

namespace C0453_ClassConsoleApp1.Unit4.SPS 
{ 
    /// <summary>
    /// This class will handle the input and output 
    /// of the RPS Game
    /// </summary>
    public class GameContoller 
    {

    public static string Title = "Scissors-Paper-Stone Game";

    public const string ROCK = "ROCK";
    public const string PAPER = "PAPER";
    public const string SCISSORS = "SCISSORS";

    public const int MAXN_TURNS = 3;

    private RPS_Game game = new RPS_Game();

    private int turn;

    public void RunGame()
    {
        SetupScreen();
            StartGame();


        for (turn = 1; turn <= MAXN_TURNS; turn++)
        {
            GetPlayerChoice();
            game.GetComputerChoice();

            ShowChoices();

            game.WorkoutWinner();
            ShowResult();

            Console.WriteLine();
            Console.Write("Press any key!");
            Console.ReadKey();
        }

        game.End();

            EndGame();
    }

    /// <summary>
    /// Prints the wiiner of the game
    /// </summary>
    public void EndGame()
    {
        Console.Clear();
        SimpleIO.WriteTitle(Title, "Week 3");
        game.GameWinner();
    }

    /// <summary>
    /// This method takes 3 choices from the player in each turn and prints them. 
    /// </summary>
    private void GetPlayerChoice()
    {
        Console.Clear();
        SimpleIO.WriteTitle(Title, "Week 3");

        Console.WriteLine("Turn no " + turn + " of " + MAXN_TURNS);

        string[] choices = new string[]
        {
                ROCK,
                PAPER,
                SCISSORS
        };

        int choiceNo = SimpleIO.GetChoice(choices);

        if (choiceNo == 1)
        {
            game.PlayerChoice = RPS_Choices.ROCK;
        }
        else if (choiceNo == 2)
        {
            game.PlayerChoice = RPS_Choices.PAPER;

        }
        else game.PlayerChoice = RPS_Choices.SCISSORS;

        Console.WriteLine();
    }

    /// <summary>
    /// This method draws out an image of the choice for
    /// either the computer, or the player.  The player's
    /// choice is drawn at (x = 5, y = 14) and the computers 
    /// choice at (x = 50, y = 14)
    /// FIND THE SINGLE MISTAKE!!!
    /// </summary>
    private void DrawChoice(RPS_Players player)
    {
        RPS_Choices choice;

        int x;

        int y = 14;

        if (player == RPS_Players.COMPUTER)
        {
                x = 40;
            choice = game.ComputerChoice;
        }
        else
        {
            choice = game.PlayerChoice;
            x = 5;
        }

        if (choice == RPS_Choices.SCISSORS)
        {
            Images.DrawScissors(x, y);
        }
        else if (choice == RPS_Choices.PAPER)
        {
            Images.DrawPaper(x, y);
        }
        else if (choice == RPS_Choices.ROCK)
        {
            Images.DrawStone(x, y);
        }
    }

    /// <summary>
    /// *******************************************************
    /// At the end of the round the choices are shown.
    /// *******************************************************
    /// </summary>
    private void ShowChoices()
    {
        DrawChoice(RPS_Players.PLAYER);
        DrawChoice(RPS_Players.COMPUTER);

        Console.WriteLine("\n\t" + game.PlayerName + " picked " + game.PlayerChoice);
        Console.WriteLine("\tThe computer choice is " + game.ComputerChoice);
        Console.WriteLine();
    }

    /// <summary>
    /// *******************************************************
    /// The result for the round is shown to the user.
    /// *******************************************************
    /// </summary>
    private void ShowResult()
    {

            Console.WriteLine("\tThe Players score = " + game.PlayerScore);
            Console.WriteLine("\tThe Computer score = " + game.ComputerScore);
            Console.WriteLine("\tThe current winner is the " + game.WinnerName);
        Console.WriteLine();
        Console.WriteLine("\tThe player has won ");
        Console.WriteLine("\tThe computer has won ");
    }

    /// <summary>
    /// *******************************************************
    /// Sets the title, window size, colours and clears the console.
    /// *******************************************************
    /// </summary>
    private void SetupScreen()
    {
        Console.Title = Title;

        Console.SetWindowSize(100, 36);
        Console.SetBufferSize(100, 36);

        Console.BackgroundColor = ConsoleColor.Red;
        Console.ForegroundColor = ConsoleColor.White;

        Console.Clear();  // clear screen in chosen colour
    }

    /// <summary>
    /// *******************************************************
    /// Asks fot the user's name, begins the game.
    /// *******************************************************
    /// </summary>
    private void StartGame()

    {
            Console.WriteLine("What's your name");
            string userName = Console.ReadLine();
        SimpleIO.WriteTitle(Title, "Week 3");
            game.Start(userName);
    }
}
 
}

   
    
        
