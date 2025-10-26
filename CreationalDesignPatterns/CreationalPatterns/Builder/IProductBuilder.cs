namespace CreationalDesignPatterns.CreationalPatterns.Builder
{

    // Builder Interface
    public interface IProductBuilder
    {
        public void StartUpOperations();
        public void BuildBody();
        public void InsertWheels();
        public void AddHeadlights();
        public void EndOperations();

        public void setBrandName(string brand);
    }

}
