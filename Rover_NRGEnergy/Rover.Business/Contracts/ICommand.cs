using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Business.Contracts
{
    public interface ICommand
    {
        void Execute(IRover rover);
    }
}
