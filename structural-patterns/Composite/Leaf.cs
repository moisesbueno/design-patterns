using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Composite
{
    public class Leaf : Component
    {
        public override string Operation()
        {
            return "leaf";
        }

        public override bool IsComposite()
        {
            return false;
        }
    }
}