using BuilderDesignPattern.Example.RiskFactor;
using System.Collections.Generic;

namespace BuilderDesignPattern.Example.Servcies.RiskFactor
{
    public class RiskFactorServcie
    {
        public RiskFactorOutputmodel GetAllRiskFactor()
        {
            return new RiskFactorOutputmodel
            { 
            HighRiskFactor=new List<Example.RiskFactor.RiskFactor> { 
                new Example.RiskFactor.RiskFactor { 
                    Id=1,
                    Name="HRF 1"
                } ,
                 new Example.RiskFactor.RiskFactor {
                    Id=2,
                    Name="HRF 2"
                }
            },
            LowRiskFactor =  new List<Example.RiskFactor.RiskFactor> {
                new Example.RiskFactor.RiskFactor {
                    Id=1,
                    Name="LRF 1"
                } ,
                 new Example.RiskFactor.RiskFactor {
                    Id=2,
                    Name="LRF 2"
                }
            }
            };
        }
    }
   
}
