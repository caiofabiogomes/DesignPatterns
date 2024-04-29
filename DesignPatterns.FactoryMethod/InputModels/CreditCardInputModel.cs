using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod.InputModels
{
    public class CreditCardInputModel : PaymentInfoInputModel
    {
        public CreditCardInputModel(string cardNumber, string cardHolderName, string expirationDate, string cvv)
        {
            CardNumber = cardNumber;
            CardHolderName = cardHolderName;
            ExpirationDate = expirationDate;
            CVV = cvv;
        }
        public string CardNumber { get; set; }
        public string CardHolderName { get; set; }
        public string ExpirationDate { get; set; }
        public string CVV { get; set; }
    }
}
