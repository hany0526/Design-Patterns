namespace DesignPatterns.Builder
{

    // Builder Interface

    public interface IProductBuilder
    {
        void StartUpOperations();
        void BuildBody();
        void InsertWheels();
        void AddHeadlights();
        void EndOperations();
        Product GetVehicle();
    }

}
