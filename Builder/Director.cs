using System.Collections.Generic;

namespace DesignPatterns.Builder
{
    public class Director
    {
        private IBuilder _builder;
        public Director()
        {
        }

        public Director(IBuilder builder)
        {
            _builder = builder;
        }

        // steps to create complex object
        public void BuildProduct(IBuilder builder)
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