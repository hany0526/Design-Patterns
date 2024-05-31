using System.Collections.Generic;

namespace DesignPatterns.Builder
{
    public class Director
    {
        private IProductBuilder _builder;
       
        public Director()
        {
        }

        // steps to create complex object
        public void constructProduct(IProductBuilder builder)
        {
            _builder = builder;
            doBuilder();
        }

        private void doBuilder()
        {
            _builder.StartUpOperations();
            _builder.BuildBody();
            _builder.InsertWheels();
            _builder.AddHeadlights();
            _builder.EndOperations();
        }
    }
}