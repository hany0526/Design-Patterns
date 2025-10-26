using CreationalDesignPatterns.CreationalPatterns.Builder;

namespace CreationalDesignPatterns.CreationalPatterns.Builder.Models
{
    public class MotorCycle : Product, IProductBuilder
    {
        private string brandName;

        public MotorCycle() 
        {
        }

        public MotorCycle(string brand = "Motor")
        {
            brandName = brand;
        }

        public override void setBrandName(string brand)
        {
            brandName = brand;
        }

        public override void StartUpOperations()
        { }

        public override void BuildBody()
        {
            Add("Body was added");
        }

        public override void InsertWheels()
        {
            Add("wheels are added");
        }

        public override void AddHeadlights()
        {
            Add("Headlights are added");
        }

        public override void EndOperations()
        {
            Add($"Motorcycle brand name {brandName}");
        }

    }
}
