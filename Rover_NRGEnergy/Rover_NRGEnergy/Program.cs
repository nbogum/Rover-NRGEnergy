using MarsRover.Business;
using MarsRover.Models;
using System;
using System.Linq;

namespace MarsRover_NRGEnergy
{
    class Program
    {

        #region Entry-Point
        static void Main(string[] args)
        {
            HelpCommands();

            var platue = new Plateau(GetPlatueDimensions().Split(' ').Select(Int32.Parse).ToArray());
            bool exit = false;

            while (!exit)
            {
                var rover = new Rover(platue, GetLaunchCoordinates());

                //Launch Position
                Console.WriteLine("Intial {0} ", rover.ToString());

                //Execute
                rover.ExecuteCommands(GetExecutionCommands());

                //Final Position
                Console.WriteLine("Final {0} ", rover.ToString());
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("*************** Hit Any Key to Launch New Rover (OR) Enter 'EXIT' to End Program  ************* ");

                exit = Console.ReadLine().ToUpper() == "EXIT";
            }
        } 
        #endregion


        #region Helper-Methods

        private static void HelpCommands()
        {
            Console.WriteLine("Help Menu");
            Console.WriteLine("=============================");
            Console.WriteLine("Rover Movement Commands:");
            Console.WriteLine("Enter 'L' for Left Turn");
            Console.WriteLine("Enter 'R' for Right Turn ");
            Console.WriteLine("Enter 'M' to Move Rover");
            Console.WriteLine("=============================");
        }
        private static string GetPlatueDimensions()
        {
            Console.WriteLine("Please Enter Platue dimensions {Example: 5 5}");
            return Console.ReadLine();
        }
        private static Position GetLaunchCoordinates()
        {
            Console.WriteLine("Please Enter Rover Launch Coordinates {Example 5 5 N}");
            var pos = Console.ReadLine().ToUpper().Split(' ');
            return new Position(Convert.ToInt32(pos[0]), Convert.ToInt32(pos[1]), pos[2]);
        }
        private static string GetExecutionCommands()
        {
            Console.WriteLine("Please Enter Commands for Rover Movement {Example LMLMLMLMMR}");
            return Console.ReadLine().ToUpper();
        }

        #endregion

    }
}
