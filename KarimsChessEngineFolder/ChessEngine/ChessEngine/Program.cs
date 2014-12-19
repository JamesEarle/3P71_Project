using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessEngine
{
    class Program
    {
        //This is our 2D array chess board

        static void Main(string[] args)
        {
            //This is the boolean that terminates the game loop on exit
            bool exit = false;
            
            //This is the main game loop. It'll continue to loop until exit is true, breaking the program loop and exiting the application.
            while (!exit) 
            {
                //Check for user input
                getUserMove();

                //Check if user move is valid

                //If User move is valid, call computer engine to respond
                //else not valid, prompt for error, try again

                Console.WriteLine("Continue?");
                String exitString = Console.ReadLine();

                if (exitString == "x")
                {
                    exit = true;
                }
            }

        }

        public static void getUserMove()
        {
            //Selecting the starting piece
            Console.WriteLine("");
            Console.WriteLine("Please Select a piece to move selecting its column (A to H)...");
            String inputColumn = Console.ReadLine().ToUpper();
            Console.WriteLine("Please Select the row of the piece to move (1 to 8)...");
            Int32 inputRow = Int32.Parse(Console.ReadLine());
            Console.WriteLine("You entered column: " + inputColumn + " and row: " + inputRow);

            //Selecting where to move that piece to
            Console.WriteLine("");
            Console.WriteLine("Please Select which column to move that piece to");
            String inputColumn2 = Console.ReadLine().ToUpper();
            Console.WriteLine("Please Select the row to move that piece to");
            Int32 inputRow2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("You entered column: " + inputColumn2 + " and row: " + inputRow2);

        }

        int score;

        int[] moves = new int[20];

       
    }
}
