using MarsRover.Models.Enums;

namespace MarsRover.Models
{
    public class Position
    {

        #region ctor
        public Position(int x, int y, string direction)
        {
            XCoordinate = x;
            YCoordinate = y;
            _Direction = GetDirection(direction);
        }

        #endregion


        #region Properties

        private int _XCoordinate;
        private int _YCoordinate;
        private Compass _Direction;

        public int XCoordinate { get => _XCoordinate; set => _XCoordinate = value; }
        public int YCoordinate { get => _YCoordinate; set => _YCoordinate = value; }
        public Compass Direction { get => _Direction; set => _Direction = value; }
        #endregion


        #region Helpers
        private Compass GetDirection(string direction)
        {
            switch (direction)
            {
                case "N": return Compass.North;
                case "E": return Compass.East;
                case "W": return Compass.West;
                case "S": return Compass.South;
                default: return Compass.North; ;
            }
        } 
        #endregion
    }
}
