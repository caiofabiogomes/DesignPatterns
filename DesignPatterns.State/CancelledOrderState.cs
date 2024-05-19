namespace DesignPatterns.State
{
    public class CancelledOrderState : IOrderState
    {
        public void ProcessOrder(Order order)
        {
            Console.WriteLine("Cannot process a canceled order.");
        }

        public void CancelOrder(Order order)
        {
            Console.WriteLine("Order is already canceled.");
        }
    }
}
