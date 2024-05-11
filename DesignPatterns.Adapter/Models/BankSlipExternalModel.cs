namespace DesignPatterns.Adapter.Models
{
    public class BankSlipExternalModel
    {
        public string number { get; set; }
        public decimal amount { get; set; }
        public DateTime due_date { get; set; }
        public string beneficiary { get; set; }
        public string payer { get; set; }
    }
}
