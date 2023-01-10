using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern.Example.SampleModels.Demographics
{
    public class DemographicsServices
    {
        public DemographicsOutPutModel GetDemographics()
        {
            return new DemographicsOutPutModel { AccountNumber = "100", Addmitdate = DateTime.Now, FirstName = "test", LastName = "test LN", PatentId = "wefwdqwdqwd", Status = "Cont Moniter" };
        }
    }
   
}
