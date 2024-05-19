namespace DesignPatterns.ChainOfResponsability.models
{
    public class Expense
    {
        public decimal Amount { get; }

        public Expense(decimal amount)
        {
            Amount = amount;
        }
    }

}
