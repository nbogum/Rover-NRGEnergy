
using MarsRover.Business.Contracts;
using MarsRover.Business;
using MarsRover.Business.Directions;
using MarsRover.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NRGEnergy.MarsRover.TestMethods
{
    [TestClass]
    public class TestMethodRover
    {
        private IPlateau _plateau;

        [TestInitialize]
        public void Setup()
        {
            _plateau = new Plateau(new int[] { 5, 5 });
        }

        [TestMethod]
        public void DefaultRoverCreatedAtNorth()
        {
            var rover = new Rover(_plateau);
            Assert.IsTrue(rover.Direction is North);
        }

        [TestMethod]
        public void RoverTurnLeft()
        {
            var rover = new Rover(_plateau);
            rover.TurnLeft();
            Assert.IsTrue(rover.Direction is West);
        }


        [TestMethod]
        public void RoverTurnRight()
        {
            var rover = new Rover(_plateau);
            rover.TurnRight();
            Assert.IsTrue(rover.Direction is East);
        }

        [TestMethod]
        public void RoverTurn180()
        {
            var rover = new Rover(_plateau);
            rover.TurnRight();
            rover.TurnRight();
            Assert.IsTrue(rover.Direction is South);
       }

        [TestMethod]
        public void RoverMoveNorth()
        {
            var rover = new Rover(_plateau, new Position(1, 1, "W"));
            rover.TurnRight();
            rover.Move();
            Assert.AreEqual<int>(rover.GetRoverPosition().XCoordinate, (1));
            Assert.AreEqual<int>(rover.GetRoverPosition().YCoordinate, (2));
        }

        [TestMethod]
        public void RoverMoveEast()
        {
            var rover = new Rover(_plateau,new Position(1, 1, "N"));
            rover.TurnRight();
            rover.Move();
            Assert.AreEqual<int>(rover.GetRoverPosition().XCoordinate, (2));
            Assert.AreEqual<int>(rover.GetRoverPosition().YCoordinate, (1));
        }

        [TestMethod]
        public void RoverMoveWest()
        {
            var rover = new Rover(_plateau, new Position(1,1,"N"));
            rover.TurnLeft();
            rover.Move();
            Assert.AreEqual<int>(rover.GetRoverPosition().XCoordinate, (0));
            Assert.AreEqual<int>(rover.GetRoverPosition().YCoordinate, (1));
        }

        [TestMethod]
        public void RoverMoveSouth()
        {
            var rover = new Rover(_plateau, new Position(1, 1, "E"));
            rover.TurnRight();
            rover.Move();
            Assert.AreEqual<int>(rover.GetRoverPosition().XCoordinate, (1));
            Assert.AreEqual<int>(rover.GetRoverPosition().YCoordinate, (0));
        }

        [TestMethod]
        [DataRow("MRML", 1, 1, "N")]
        [DataRow("MMRMM", 2, 2, "E")]
        [DataRow("RMLMLMLM", 0,0 , "S")]
        public void TestMovement(string command, int x, int y, string direction)
        {
            var rover = new Rover(_plateau);
            rover.ExecuteCommands(command);
            Assert.AreEqual<int>(rover.GetRoverPosition().XCoordinate, x);
            Assert.AreEqual<int>(rover.GetRoverPosition().YCoordinate, y);
            Assert.AreEqual<string>(rover.Direction.ToString(),direction);            
        }
    }
}
