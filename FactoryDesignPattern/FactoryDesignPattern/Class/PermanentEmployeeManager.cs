﻿using FactoryDesignPattern.Interface;

namespace FactoryDesignPattern.Class
{
    public class PermanentEmployeeManager : IEmployeeManager
    {
        public decimal GetBonus()
        {
            return 10;
        }

        public decimal GetPay()
        {
            return 8;
        }
        public decimal GetHouseAllowance()
        {
            return 150;
        }
    }
}
