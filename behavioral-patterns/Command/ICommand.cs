using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Command
{
    public interface ICommand
    {
        void Execute();
    }
}