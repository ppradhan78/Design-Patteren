using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Interface.Discount
{
    internal interface IDiscountStrategy
    {
        float GetFinalBill(float BillAmount);
    }
}
