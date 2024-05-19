using DesignPatterns.ChainOfResponsability.enums;
using DesignPatterns.ChainOfResponsability.models;

namespace DesignPatterns.ChainOfResponsability.interfaces
{
    public interface IExpenseHandler
    {
        EApprovalResponse ApproveExpense(Expense expense);
        void SetNextHandler(IExpenseHandler nextHandler);
    }
}
