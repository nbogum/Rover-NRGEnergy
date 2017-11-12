using MarsRover.Models;

namespace MarsRover.Business.Contracts
{
    public interface IPlateau
    {
        int X_Coordinate { get;}
        int Y_Coordinate { get; }
        void MoveNorth();
        void MoveEast();
        void MoveSouth();
        void MoveWest();
        void SetRoverPosition(Position _position);
      
    }
}
