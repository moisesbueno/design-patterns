using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Decorator
{
    public class Decorator : Component
    {
        protected Component _component;
        
        public Decorator(Component component){
            _component = component;
        }

        public void SetComponent(Component component){
            _component = component;
        }

        public override string Operation()
        {
           if(_component != null){
            return _component.Operation();
           }
           return string.Empty;
        }
    }
}