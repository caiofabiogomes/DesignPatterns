namespace DesignPatterns.Decorator.InputModels
{
    public class PaypalInputModel : PaymentInfoInputModel
    {
        public PaypalInputModel(string email, string password)
        {
            Email = email;
            Password = password;
        }
        
        public string Password { get; set; }
    }
}
