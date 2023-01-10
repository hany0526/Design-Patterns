namespace DesignPatterns.Builder
{
    // Concrete Builder.
    public class Car : IBuilder
    {

        private string brandName;
        private Product product;

        public Car(string brand)
        {
            this.brandName = brand;
            product = new Product();
        }

        public void StartUpOperations()
        {
            product.Add($"Car Model name :{this.brandName}");
        }

        public void BuildBody() { product.Add("Body of car was added"); }
        public void InsertWheels() { product.Add("wheels are added"); }

        public void AddHeadlights()
        {
            product.Add("Headlights are added");
        }

        public void EndOperations() { /*End Operation*/ }

        public Product GetVehicle() { return product; }
    }

}
