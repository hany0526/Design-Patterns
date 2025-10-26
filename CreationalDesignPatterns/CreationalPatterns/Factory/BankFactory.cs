namespace CreationalDesignPatterns.CreationalPatterns.Factory
{
    // concrete class
    public class BankFactory : IBankFactory
    {
        public IBank GetBank(string bankCode)
        {
            switch (bankCode)
            {
                case "123456": return new BankA(); 
                case "111111": return new BankB();     
                default: return null;
            }

        }

    }

}
