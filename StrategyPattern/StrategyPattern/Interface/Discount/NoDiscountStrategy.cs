using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Interface.Discount
{
    internal class NoDiscountStrategy : IDiscountStrategy
    {
        public float GetFinalBill(float BillAmount)
        {
            return BillAmount;
        }
    }
}
