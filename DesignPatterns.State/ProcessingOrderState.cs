namespace DesignPatterns.State
{
    public class ProcessingOrderState : IOrderState
    {
        public void ProcessOrder(Order order)
        {
            Console.WriteLine("Order is already being processed.");
        }

        public void CancelOrder(Order order)
        {
            Console.WriteLine("Canceling order during processing...");
            order.SetState(new CancelledOrderState());
        }
    }

}
