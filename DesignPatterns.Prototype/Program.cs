using DesignPatterns.Prototype;

var bankSlipOne = new BankSlip
{
    Amount = 100,
    DueDate = DateTime.Now.AddDays(5),
    Number = "22838948.3837377",
    Beneficiary = "Test Company",
    Payer = "Test Payer"
};

bankSlipOne.Print();

(bankSlipOne.Clone() as BankSlip).Print();
