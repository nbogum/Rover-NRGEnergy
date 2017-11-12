using MarsRover.Business.Commands;
using MarsRover.Business.Contracts;
using MarsRover.Business.Directions;
using MarsRover.Models;
using MarsRover.Models.Enums;

namespace MarsRover.Business
{
    public class Rover : IRover
    {

        #region Fields 
        private readonly IPlateau plateau;

        #endregion


        #region Ctors   

        public Rover(IPlateau _plateau, Position _position=null)
        {
            plateau = _plateau;
            Initialize(_position);
        }
        #endregion


        #region Properties       
        public IDirection Direction { get; private set; }
        public Position RoverPostion { get; set; }

        #endregion


        #region I-Members
        public void TurnLeft()
        {
            Direction = Direction.TurnLeft();
        }

        public void TurnRight()
        {
            Direction = Direction.TurnRight();
        }

        public void Move()
        {
            Direction.Move();
        }

        public Position GetRoverPosition()
        {
            return RoverPostion= new Position(this.plateau.X_Coordinate, this.plateau.Y_Coordinate, this.Direction.ToString());
        }
        #endregion


        #region Helpers

        private void Initialize(Position _position = null)
        {
            RoverPostion= _position?? new Position(0, 0, "N");
            plateau.SetRoverPosition(RoverPostion);
            Direction = InitializeDirection(RoverPostion.Direction);
        }

        private IDirection InitializeDirection(Compass direction)
        {
            switch (direction)
            {
                case Compass.North:
                    return new North(plateau);
                case Compass.East:
                    return new East(plateau);
                case Compass.South:
                    return new South(plateau);
                case Compass.West:
                    return new West(plateau);
                default: 
                    //default to North Facing
                    return new North(plateau);
            }
        }

        public override string ToString()
        {
            GetRoverPosition();
            return string.Format("Rover's Position: [X : {0}, Y : {1}, Direction : {2}]", RoverPostion.XCoordinate, RoverPostion.YCoordinate, this.Direction.ToString());
        }
        #endregion


        #region ExecuteCommand
        public void ExecuteCommands(string commandString)
        {
            var commands = new Command(commandString).CommandsList;
            commands.ForEach((x) => x.Execute(this));
        } 
        #endregion
    }
}
