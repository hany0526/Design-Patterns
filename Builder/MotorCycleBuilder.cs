namespace DesignPatterns.Builder
{
    public class MotorCycleBuilder : IBuilder
    {
        private string brandName;
        private Product product;

        public MotorCycleBuilder(string brand)
        {
            brandName = brand;
            product = new Product();
        }

        public void StartUpOperations()
        { }

        public void BuildBody()
        {
            product.Add("Body was added");
        }

        public void InsertWheels()
        {
            product.Add("wheels are added");
        }

        public void AddHeadlights()
        {
            product.Add("Headlights are added");
        }
        
        public void EndOperations()
        {
            product.Add($"Motorcycle brand name {this.brandName}");
        }
        
        public Product GetVehicle() { return product; }

        public override string ToString()
        {
            return GetVehicle().Show();
        }

    }
}
