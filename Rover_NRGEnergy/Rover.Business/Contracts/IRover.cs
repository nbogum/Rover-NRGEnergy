using MarsRover.Models;

namespace MarsRover.Business.Contracts
{
    public interface IRover
    {
        void TurnLeft();
        void TurnRight();
        void Move();
        Position GetRoverPosition();
    }
}
