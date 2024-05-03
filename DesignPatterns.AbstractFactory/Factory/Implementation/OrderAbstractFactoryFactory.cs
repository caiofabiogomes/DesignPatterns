using DesignPatterns.AbstractFactory.Enums;
using DesignPatterns.AbstractFactory.Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.Factory.Implementation
{
    public class OrderAbstractFactoryFactory
    {
        public IOrderAbstractFactory GetFactoryMethod(EOrderType orderType)
        {
            switch (orderType)
            {
                case EOrderType.National:
                    return new NationalOrderFactory();
                case EOrderType.International:
                    return new InternationalOrderAbstractFactory();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
