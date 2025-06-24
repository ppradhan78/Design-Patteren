using PatientInfoBuilder.SampleModels.RiskFactor;

namespace PatientInfoBuilder.Servcies.RiskFactor
{
    public class RiskFactorServcie: IRiskFactorServcie
    {
        public RiskFactorOutputmodel GetAllRiskFactor()
        {
            return new RiskFactorOutputmodel
            { 
            HighRiskFactor=new List<RiskFactorModel> { 
                new RiskFactorModel { 
                    Id=1,
                    Name="HRF 1"
                } ,
                 new RiskFactorModel {
                    Id=2,
                    Name="HRF 2"
                }
            },
            LowRiskFactor =  new List<RiskFactorModel> {
                new RiskFactorModel {
                    Id=1,
                    Name="LRF 1"
                } ,
                 new RiskFactorModel {
                    Id=2,
                    Name="LRF 2"
                }
            }
            };
        }
    }
   
}
