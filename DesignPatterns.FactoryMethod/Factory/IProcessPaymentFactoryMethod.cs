using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.FactoryMethod.Enums;
using DesignPatterns.FactoryMethod.Services.Interfaces;

namespace DesignPatterns.FactoryMethod.Factory
{
    public interface IProcessPaymentFactoryMethod
    {
        IPaymentService GetPaymentService(EPaymentMethod paymentMethod);
    }
}
