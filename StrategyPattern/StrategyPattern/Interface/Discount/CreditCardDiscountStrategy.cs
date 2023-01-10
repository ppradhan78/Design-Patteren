using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Interface.Discount
{
    internal class CreditCardDiscountStrategy : IDiscountStrategy
    {
        public float GetFinalBill(float BillAmount)
        {
            return (float)(BillAmount - (BillAmount * 0.1));
        }
    }
}
