using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.ChainOfResponsability.enums;
using DesignPatterns.ChainOfResponsability.interfaces;

namespace DesignPatterns.ChainOfResponsability.models
{
    public class Director : IExpenseHandler
    {
        private readonly decimal _approvalLimit;
        private IExpenseHandler _nextHandler;

        public Director(decimal approvalLimit)
        {
            _approvalLimit = approvalLimit;
        }

        public void SetNextHandler(IExpenseHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }

        public EApprovalResponse ApproveExpense(Expense expense)
        {
            if (expense.Amount <= _approvalLimit)
            {
                return EApprovalResponse.Approved;
            }
            else if (_nextHandler != null)
            {
                return _nextHandler.ApproveExpense(expense);
            }
            else
            {
                return EApprovalResponse.Rejected;
            }
        }
    }

}
