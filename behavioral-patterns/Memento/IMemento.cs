using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Memento
{
    public interface IMemento
    {
        string GetName();
        string GetState();
        DateTime GetDate();
    }
}