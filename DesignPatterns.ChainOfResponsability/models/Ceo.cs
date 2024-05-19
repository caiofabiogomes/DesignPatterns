using DesignPatterns.ChainOfResponsability.enums;
using DesignPatterns.ChainOfResponsability.interfaces;

namespace DesignPatterns.ChainOfResponsability.models
{
    public class CEO : IExpenseHandler
    {
        private readonly decimal _approvalLimit;

        public CEO(decimal approvalLimit)
        {
            _approvalLimit = approvalLimit;
        }

        public void SetNextHandler(IExpenseHandler nextHandler)
        {

        }

        public EApprovalResponse ApproveExpense(Expense expense)
        {
            if (expense.Amount <= _approvalLimit)
            {
                return EApprovalResponse.Approved;
            }
            else
            {
                return EApprovalResponse.Rejected;
            }
        }
    }

}
