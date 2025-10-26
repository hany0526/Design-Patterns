namespace StructuralDesignPatterns.StructuralPatterns.Facade
{
    public class InventoryOrder
    {
        public string CreateOrder(ShoppingBasket basket, string storeID)
        {
            basket.GetItems();
            return $"Order Number is {Guid.NewGuid().ToString()}";
        }
    }
}