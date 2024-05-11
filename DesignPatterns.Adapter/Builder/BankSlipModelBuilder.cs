using DesignPatterns.Adapter.Models;

namespace DesignPatterns.Adapter.Builder
{
    public class BankSlipModelBuilder
    {
        private BankSlipModel bankSlip = new BankSlipModel();

        public BankSlipModelBuilder WithNumber(string number)
        {
            bankSlip.Number = number;
            return this;
        }

        public BankSlipModelBuilder WithAmount(decimal amount)
        {
            bankSlip.Amount = amount;
            return this;
        }

        public BankSlipModelBuilder WithDueDate(DateTime dueDate)
        {
            bankSlip.DueDate = dueDate;
            return this;
        }

        public BankSlipModelBuilder ForBeneficiary(string beneficiary)
        {
            bankSlip.Beneficiary = beneficiary;
            return this;
        }

        public BankSlipModelBuilder FromPayer(string payer)
        {
            bankSlip.Payer = payer;
            return this;
        }

        public BankSlipModel Build()
        {
            return bankSlip;
        }
    }
}
