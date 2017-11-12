using MarsRover.Business.Contracts;

namespace MarsRover.Business.Directions
{
    public class West : IDirection
    {
        private readonly IPlateau _plateau;

        #region Ctor
        public West(IPlateau landscape)
        {
            _plateau = landscape;
        }
        #endregion


        #region I-Members
        public IDirection TurnLeft()
        {
            return new South(_plateau);
        }

        public IDirection TurnRight()
        {
            return new North(_plateau);
        }

        public void Move()
        {
            _plateau.MoveWest();
        }

        public override string ToString()
        {
            return "W";
        } 
        #endregion
    }
}
