using MarsRover.Business.Contracts;

namespace MarsRover.Business.Directions
{
    public class East : IDirection
    {
        private readonly IPlateau _plateau;

        #region Ctor
        public East(IPlateau plateau)
        {
            _plateau = plateau;
        } 
        #endregion


        #region I-Members
        public IDirection TurnLeft()
        {
            return new North(_plateau);
        }

        public IDirection TurnRight()
        {
            return new South(_plateau);
        }

        public void Move()
        {
            _plateau.MoveEast();
        }

        public override string ToString()
        {
            return "E";
        } 
        #endregion
    }
}
