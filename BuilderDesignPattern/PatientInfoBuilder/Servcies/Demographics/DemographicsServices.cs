using PatientInfoBuilder.SampleModels.Demographics;

namespace PatientInfoBuilder.Servcies.Demographics
{
    public class DemographicsServices: IDemographicsServices
    {
        public DemographicsOutPutModel GetDemographics()
        {
            return new DemographicsOutPutModel { AccountNumber = "100", Addmitdate = DateTime.Now, FirstName = "test", LastName = "test LN", PatentId = "wefwdqwdqwd", Status = "Cont Moniter" };
        }
    }
   
}
