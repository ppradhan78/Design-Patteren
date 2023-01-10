using StrategyPattern.BusinessObject;
using StrategyPattern.Infrastructure;
using StrategyPattern.Interface.Discount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BillGenerate _billGenerate = new BillGenerate(null);
            _billGenerate.BillAmount = 10000;
            //_billGenerate.ShopType = ShippingCategory.CreditCard;
            _billGenerate.ShopType = ShippingCategory.NoDiscount;
            //_billGenerate.ShopType = ShippingCategory.Festivals;


            switch (_billGenerate.ShopType)
            {
                case ShippingCategory.Festivals:
                    _billGenerate.discountStrategy = new FestivalsDiscountStrategy();
                    break;
                case ShippingCategory.CreditCard:
                    _billGenerate.discountStrategy = new CreditCardDiscountStrategy();
                    break;
                default:
                    _billGenerate.discountStrategy = new NoDiscountStrategy();
                    break;
            }
            Console.WriteLine(_billGenerate.GetFinnlaBill());

            Console.ReadLine();
        }
    }
}
