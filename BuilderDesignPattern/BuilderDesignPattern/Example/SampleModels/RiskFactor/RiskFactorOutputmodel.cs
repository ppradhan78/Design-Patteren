using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern.Example.RiskFactor
{
    public class RiskFactorOutputmodel
    {
        public List<RiskFactor> HighRiskFactor { get; set; }
        public List<RiskFactor> LowRiskFactor { get; set; }

    }
    public class RiskFactor 
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
