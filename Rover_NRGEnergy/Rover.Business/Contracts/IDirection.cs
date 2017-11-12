using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Business.Contracts
{
    public interface IDirection
    {
        IDirection TurnLeft();
        IDirection TurnRight();
        void Move();
    }
}
