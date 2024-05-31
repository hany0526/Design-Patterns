namespace DesignPatterns.Builder
{
    public class MotorCycleBuilder : Product,  IProductBuilder
    {
        private string brandName;

        public MotorCycleBuilder(string brand)
        {
            brandName = brand;
        }

        public void StartUpOperations()
        { }

        public void BuildBody()
        {
            Add("Body was added");
        }

        public void InsertWheels()
        {
            Add("wheels are added");
        }

        public void AddHeadlights()
        {
            Add("Headlights are added");
        }
        
        public void EndOperations()
        {
            Add($"Motorcycle brand name {this.brandName}");
        }
        
        public Product GetVehicle() { return this; }

        public override string ToString()
        {
            return base.Show();
            // return GetVehicle().Show();
        }

    }
}
