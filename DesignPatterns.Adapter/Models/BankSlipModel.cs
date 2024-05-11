namespace DesignPatterns.Adapter.Models
{
    public class BankSlipModel
    {
        public string Number { get; set; }
        public decimal Amount { get; set; }
        public DateTime DueDate { get; set; }
        public string Beneficiary { get; set; }
        public string Payer { get; set; }
    }
}
