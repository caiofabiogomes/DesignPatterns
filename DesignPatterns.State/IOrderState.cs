namespace DesignPatterns.State
{
    public interface IOrderState
    {
        void ProcessOrder(Order order);
        void CancelOrder(Order order);
    }
}
