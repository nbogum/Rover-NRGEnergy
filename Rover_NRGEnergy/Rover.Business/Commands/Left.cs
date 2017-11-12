using MarsRover.Business.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Business.Commands
{
    public class Left : ICommand
    {
        public void Execute(IRover rover)
        {
            rover.TurnLeft();
        }
    }
}
