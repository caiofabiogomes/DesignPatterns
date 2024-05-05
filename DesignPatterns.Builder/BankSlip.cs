namespace DesignPatterns.Builder
{
    public class BankSlip
    {
        public string Number { get; set; }
        public decimal Amount { get; set; }
        public DateTime DueDate { get; set; }
        public string Beneficiary { get; set; }
        public string Payer { get; set; }

        public void Print()
        {
            Console.WriteLine($"Bank Slip: {Number}");
            Console.WriteLine($"Amount: ${Amount}");
            Console.WriteLine($"Due Date: {DueDate.ToShortDateString()}");
            Console.WriteLine($"Beneficiary: {Beneficiary}");
            Console.WriteLine($"Payer: {Payer}");
        }
    }
}
