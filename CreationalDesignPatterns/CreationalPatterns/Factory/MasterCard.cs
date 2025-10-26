namespace CreationalDesignPatterns.CreationalPatterns.Factory
{
    public class MasterCard : IPaymentCard
    {
        public string GetName()
        {
            return "Master Card";
        }

        public string GetProviderInfo()
        {
            return "MasterCard";
        }
    }
}
