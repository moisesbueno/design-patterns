using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bridge
{
    public class Client
    {
        public void ClientCode(Abstraction abstraction){
            Console.WriteLine(abstraction.Operation());
        }
    }
}