namespace DesignPatterns.Factory
{
    public class VisaCard : IPaymentCard
    {
        public string GetName()
        {
            return "Visa Card";
        }

        public string GetProviderInfo()
        {
            return "Visa";
        }
    }
}
