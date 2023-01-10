using StrategyPattern.Infrastructure;
using StrategyPattern.Interface.Discount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.BusinessObject
{
    internal class BillGenerate
    {
        public ShippingCategory ShopType { get; set; }
        public int BillAmount { get; set; }
        public IDiscountStrategy discountStrategy;

        public BillGenerate(IDiscountStrategy _discountStrategy)
        {
            discountStrategy = _discountStrategy;
        }
        public float GetFinnlaBill()
        {
            return discountStrategy.GetFinalBill(BillAmount);
        }
    }
}
