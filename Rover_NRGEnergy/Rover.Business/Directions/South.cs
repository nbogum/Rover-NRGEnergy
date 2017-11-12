using MarsRover.Business.Contracts;

namespace MarsRover.Business.Directions
{
    public class South : IDirection
    {
        private readonly IPlateau _plateau;

        #region Ctor
        public South(IPlateau landscape)
        {
            _plateau = landscape;
        }
        #endregion


        #region I-Members
        public IDirection TurnLeft()
        {
            return new East(_plateau);
        }

        public IDirection TurnRight()
        {
            return new West(_plateau);
        }

        public void Move()
        {
            _plateau.MoveSouth();
        }

        public override string ToString()
        {
            return "S";
        } 
        #endregion
    }
}
