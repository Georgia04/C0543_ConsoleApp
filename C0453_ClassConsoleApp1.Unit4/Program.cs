using C0453_ClassConsoleApp1.Unit4.Unit4;
using C0453_ClassConsoleApp1.Unit4.Unit5;
using System;
using C0453_ClassConsoleApp1.Unit4.SPS;

namespace C0453_ClassConsoleApp1.Unit4
{
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
            //TestTournament();
            //TestMP3Chart();
            TestGame();
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
            tournament.GetScores();
            tournament.ShowScores();
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

            miles = SimpleIO.GetDouble("Miles");
            feet = converter.ToFeet(miles);

            Console.WriteLine("The no of Miles = " + miles);
            Console.WriteLine("The no of feet = " + feet);

            feet = SimpleIO.GetDouble("Feet");
            miles = converter.ToMiles(feet);

            Console.WriteLine("The no of feet = " + feet);
            Console.WriteLine("The no of miles = " + miles);

        }

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
            BatesMotel motel = new BatesMotel();

            SimpleIO.WriteTitle("The Bates Motel", "Task 5.6");

            string[] choices =
            {
                "1. Book a Room",
                "2. Vacate a Room",
                "3. Display All Rooms",
                "4. Vacate All Rooms",
                "5. Quit"
            };

            int choice = SimpleIO.GetChoice(choices);

            switch (choice)
            {
                case 1:
                    //.Book(1, 2);
                    break;

                default:
                    break;
               


            }

        }
    }
}



