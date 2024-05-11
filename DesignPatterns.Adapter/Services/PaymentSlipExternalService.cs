using DesignPatterns.Adapter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter.Services
{
    public class PaymentSlipExternalService : IPaymentSlipExternalService
    {
        public BankSlipExternalModel GeneratePaymentSlip()
        {
            return new BankSlipExternalModel
            {
                number = "16277363737737673",
                amount = 100,
                due_date = DateTime.Now.AddDays(5),
                beneficiary = "John Doe",
                payer = "Jane Doe"
            };
        }
         
    }
}
