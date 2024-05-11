namespace DesignPatterns.Decorator.InputModels
{
    public abstract class PaymentInfoInputModel
    {
        public decimal Value { get; set; }
        public string Email { get; set; }
    }
}
