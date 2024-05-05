using DesignPatterns.Builder;

BankSlip bankSlip = new BankSlipBuilder()
            .WithNumber("123456789")
            .WithAmount(1011)
            .WithDueDate(DateTime.Today.AddDays(7))
            .ForBeneficiary("Test Company")
            .FromPayer("Test Payer")
            .Build();

bankSlip.Print();