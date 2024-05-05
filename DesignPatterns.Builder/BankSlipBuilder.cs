namespace DesignPatterns.Builder
{
    public class BankSlipBuilder
    {
        private BankSlip bankSlip = new BankSlip();

        public BankSlipBuilder WithNumber(string number)
        {
            bankSlip.Number = number;
            return this;
        }

        public BankSlipBuilder WithAmount(decimal amount)
        {
            bankSlip.Amount = amount;
            return this;
        }

        public BankSlipBuilder WithDueDate(DateTime dueDate)
        {
            bankSlip.DueDate = dueDate;
            return this;
        }

        public BankSlipBuilder ForBeneficiary(string beneficiary)
        {
            bankSlip.Beneficiary = beneficiary;
            return this;
        }

        public BankSlipBuilder FromPayer(string payer)
        {
            bankSlip.Payer = payer;
            return this;
        }

        public BankSlip Build()
        {
            return bankSlip;
        }
    }
}
