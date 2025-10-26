using CreationalDesignPatterns.CreationalPatterns.Builder;

namespace CreationalDesignPatterns.CreationalPatterns.Builder.Models
{
    // Concrete Builder Class.
    public class Car: Product, IProductBuilder
    {

        private string brandName;

        public Car()
        {
        }

        public Car(string brand)
        {
            brandName = brand;
        }

        public override void setBrandName(string brand)
        {
            brandName = brand;
        }

        public override void StartUpOperations()
        {
            Add($"Car Model name :{brandName}");
        }

        public override void BuildBody()
        {
            Add("Body of car was added");
        }

        public override void InsertWheels() { Add("wheels are added"); }

        public override void AddHeadlights()
        {
            Add("Headlights are added");
        }

        public override void EndOperations() { /*End Operation*/ }

    }

}
