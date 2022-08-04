using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Flyweight
{
    public class Flyweight
    {
        private Car _sharedState;

        public Flyweight(Car sharedState)
        {
            _sharedState = sharedState;
        }

        public void Operation(Car uniqueState){
            string s = JsonConvert.SerializeObject(_sharedState);
            string u = JsonConvert.SerializeObject(uniqueState);

            Console.WriteLine($"Flyweight: Displaying shared {s} and unique {u} state.");
        }
    }
}