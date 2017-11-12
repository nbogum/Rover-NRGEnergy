using MarsRover.Business.Contracts;
using MarsRover.Models;

namespace MarsRover.Business
{
    public class Plateau : IPlateau
    {
        #region Fields & Properties
        public int X_Coordinate { get; private set; }
        public int Y_Coordinate { get; private set; }
        private readonly int xAxis;
        private readonly int yAxis;
        #endregion


        #region Ctor
        public Plateau(int[] dimensions)
        {
            //BNk: Set default Rover position to Origin
            X_Coordinate = 0;
            Y_Coordinate = 0;
            xAxis = dimensions[0];
            yAxis = dimensions[1];
        }

        #endregion


        #region I-Members
        public void MoveEast()
        {
            if (X_Coordinate < xAxis)
                X_Coordinate++;
        }

        public void MoveWest()
        {
            if (X_Coordinate > 0)
                X_Coordinate--;
        }

        public void MoveSouth()
        {
            if (Y_Coordinate > 0)
                Y_Coordinate--;
        }

        public void MoveNorth()
        {
            if (Y_Coordinate < yAxis)
                Y_Coordinate++;
        }
      
        public void SetRoverPosition(Position _position)
        {
            X_Coordinate = _position.XCoordinate;
            Y_Coordinate = _position.YCoordinate;
        }      

        #endregion
    }
}
