using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adapter
{
    public class Adaptee
    {
        public string GetSpecificRequest(){
            return "Specific request";
        }
    }
}