using C0453_ClassConsoleApp1.Unit4.Unit4;
using C0453_ClassConsoleApp1.Unit4.Unit5;
using System;
using C0453_ClassConsoleApp1.Unit4.SPS;

namespace C0453_ClassConsoleApp1.Unit4
{
    /// <summary>
   /// This class creates objects for each of the tasks and tests
   /// that each object works.
   /// 
   ///Objects are: Distance Converter, Book, Tournament, 
   ///MP3 Chart, Body Mass Index, Motel Booking and RPS Game.
  /// </summary>
    class Program
    {
        /// <summary>
        /// This method is called first when the program is executed
        /// author: Georgia
        /// </summary>
        static void Main(string[] args)
        {
           //TestDistanceConverter(); // T4.1
            //TestBook(); // T4.2 and T4.3
            //TestTournament(); //5.1 AND 5.3
            //TestMP3Chart();   //5.2
            //TestGame();
           //TestBMI(); //4.4
          //TestMotelBooking(); //5.6
          TestBubbleSort(); //5.4
        }

        private static void TestBMI() 
        {
            BMI bMI = new BMI();
            BMI.Calculator();
        }

        private static void TestBubbleSort()
        {
            Bubble NSort = new Bubble();

            NSort.InputNumbers();
            NSort.DisplayNumbers();
            NSort.SortNumbers();
        }

        private static void TestGame()
        {
            GameContoller game = new GameContoller();
            game.RunGame();
        }

        /// <summary>
        /// Task 5.1 Create a new Tournament abject 
        /// and get the scores for each player and show them
        /// </summary>
        private static void TestTournament()
        {
            Tournament tournament = new Tournament();
            tournament.GetDetails();
            tournament.ShowDetails();
        }

        /// <summary>
        /// Task 4.2 Create a Book object and test that it writes chapter 1 and 2
        /// Task 4.3 Add a Book Constructor method to initialise all the attributes
        /// </summary>
        private static void TestBook()
        {
            Book book = new Book();
            SimpleIO.WriteTitle("Horror Story", "Task 4.1");

            //book.GetDetails();
            book.GetDetails();
            book.WriteChapter1();
            book.WriteChapter2();
        }

        /// <summary>
        /// Task 4.1 Create a Converter and check that it converts between
        /// miles and feet using double numbers
        /// </summary>
        public static void TestDistanceConverter()
        {
            double miles = 1;
            double feet = 0;

           Console.WriteLine("Georgia's Distance Converter");

            DistanceConverter converter = new DistanceConverter();

            int choice = 3;

            string[] choices = new string[]
            {
             "1. Convert Miles to Feet" ,
             "2. Convert Feet to Miles" ,
             "3. Quick Test"
            };

            do
            {
                choice = SimpleIO.GetChoice(choices);

                if (choice == 1)
                {
                    miles = converter.GetDouble("Miles");
                    feet = converter.ToFeet(miles);

                    Console.WriteLine("The no of miles = " + miles);
                    Console.WriteLine("The no of feet = " + feet);
                }
                else if (choice == 2)
                {
                    feet = converter.GetDouble("Feet");
                    miles = converter.ToMiles(feet);

                    Console.WriteLine("The no of feet = " + feet);
                    Console.WriteLine("The no of miles = " + miles);
                }

            } while (choice != 3);
        } 

         ///<summary>
        /// Task 5.2. Create a list of song tracks and get vote
        /// for the favourite one.
        /// </summary>
        private static void TestMP3Chart()
        {
            MP3Chart MP3 = new MP3Chart();
            MP3.ShowSongs();

            bool finish = false;

            while (!finish)
            {
                int songNo = MP3.GetVotes();
                if (songNo == 0) finish = true;

            }

            MP3.ShowVotes();
        }

        /// <summary>
        /// A simple room booking system
        /// </summary>
        private static void TestMotelBooking()
        {
            RunBatesMotel runBatesMotel = new RunBatesMotel();
            runBatesMotel.MotelRooms();
            runBatesMotel.RunBates();
        }
    }
}




