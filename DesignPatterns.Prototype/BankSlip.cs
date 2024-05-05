namespace DesignPatterns.Prototype
{
    public class BankSlip : ICloneable
    {
        public BankSlip()
        {
            RandomNumber = new Random().Next(1000, 9999).ToString();
        }
        public string Number { get; set; }
        public decimal Amount { get; set; }
        public DateTime DueDate { get; set; }
        public string Beneficiary { get; set; }
        public string Payer { get; set; }
        private string RandomNumber { get; set; }

        public object Clone()
        {
            return new BankSlip
            {
                Number = this.Number,
                Amount = this.Amount,
                DueDate = this.DueDate,
                Beneficiary = this.Beneficiary,
                Payer = this.Payer,
                RandomNumber = this.RandomNumber
            };
        }

        public void Print()
        {
            Console.WriteLine($"Bank Slip: {Number}");
            Console.WriteLine($"Amount: ${Amount}");
            Console.WriteLine($"Due Date: {DueDate.ToShortDateString()}");
            Console.WriteLine($"Beneficiary: {Beneficiary}");
            Console.WriteLine($"Payer: {Payer}");
            Console.WriteLine($"Random Number: {RandomNumber}");
        }
    }
}
