using FactoryDesignPattern.Interface;

namespace FactoryDesignPattern.Class
{
    public class ContractEmployeeManager : IEmployeeManager
    {
        public decimal GetBonus()
        {
            return 5;
        }

        public decimal GetPay()
        {
            return 12;
        }
        public decimal GetMedicalAllowance()
        {
            return 12;
        }
    }
}
