namespace CreationalDesignPatterns.CreationalPatterns.Factory
{
    public class PaymentCardFactory
    {
        public IPaymentCard GetPaymentCard(string cardNumber)
        {
            switch (cardNumber)
            {
                case "12": return new VisaCard();
                case "34": return new MasterCard();
            }
            return null;
        }
    }
}