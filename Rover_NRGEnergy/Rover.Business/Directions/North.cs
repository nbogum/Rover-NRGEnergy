using MarsRover.Business.Contracts;

namespace MarsRover.Business.Directions
{
    public class North : IDirection
    {
        private readonly IPlateau _plateau;
        
        #region Ctor

        public North(IPlateau landscape)
        {
            _plateau = landscape;
        }
        #endregion

        #region I-Members
        public IDirection TurnLeft()
        {
            return new West(_plateau);
        }

        public IDirection TurnRight()
        {
            return new East(_plateau);
        }

        public void Move()
        {
            _plateau.MoveNorth();
        }

        public override string ToString()
        {
            return "N";
        } 
        #endregion
    }
}
