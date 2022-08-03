using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Facade
{
    public class Client
    {
        public static void ClientCode(Facade facade){
            Console.WriteLine(facade.Operation());
        }
    }
}