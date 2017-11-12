using MarsRover.Business.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Business.Commands
{
    public class Right: ICommand
    {
        public void Execute(IRover rover)
        {
            rover.TurnRight();
        }
    }
}
