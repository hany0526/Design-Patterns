using CreationalDesignPatterns.CreationalPatterns.Builder.Models;

namespace CreationalDesignPatterns.CreationalPatterns.Builder
{
    public class Director
    {
        private Product _builder;
       
        public Director()
        {
        }

        // steps to create complex object
        public void constructProduct(Product builder)
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