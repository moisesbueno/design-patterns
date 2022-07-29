using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Builder
{
    public class Director
    {
        private IBuilder _builder;
        public IBuilder Builder { set { _builder = value; } }


        public void BuildMinimalViableProduct()
        {
            _builder.BuildPartA();
        }


        public void BuildFullFeaturedProduct()
        {
            _builder.BuildPartA();
            _builder.BuildPartB();
            _builder.BuildPartC();
        }
    }
}