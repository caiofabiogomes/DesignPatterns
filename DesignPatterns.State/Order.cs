namespace DesignPatterns.State
{
    public class Order
    {
        private IOrderState _state;

        public Order()
        {
            _state = new NewOrderState();
        }

        public void SetState(IOrderState state)
        {
            _state = state;
        }

        public void ProcessOrder()
        {
            _state.ProcessOrder(this);
        }

        public void CancelOrder()
        {
            _state.CancelOrder(this);
        }
    }
}
