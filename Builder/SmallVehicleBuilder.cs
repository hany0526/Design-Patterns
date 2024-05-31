using System;

namespace DesignPatterns.Builder
{
    public class SmallVehicleBuilder: Product, IProductBuilder
    {
        private string brandName;

        public SmallVehicleBuilder()
        {
        }

        public SmallVehicleBuilder(string brand)
        {
            brandName = brand;
        }

        public void StartUpOperations()
        {
            Add($"Car Model name :{this.brandName}");
        }

        public void BuildBody()
        {
            Add("Body of car was added");
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
            Add("Operations are done");
        }

        public Product GetVehicle() 
        { 
            return this; 
        }

        public override string ToString()
        {
            return base.Show();
            // return base.ToString();
            // return GetVehicle().Show();
        }

    }
}
