namespace DesignPatterns.FactoryMethod.InputModels
{
    public class PaypalInputModel : PaymentInfoInputModel
    {
        public PaypalInputModel(string email, string password)
        {
            Email = email;
            Password = password;
        }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
