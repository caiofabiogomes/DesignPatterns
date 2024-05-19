namespace DesignPatterns.State
{
    public class NewOrderState : IOrderState
    {
        public void ProcessOrder(Order order)
        {
            Console.WriteLine("Processing new order...");
            order.SetState(new ProcessingOrderState());
        }

        public void CancelOrder(Order order)
        {
            Console.WriteLine("Canceling new order...");
        }
    }
}
