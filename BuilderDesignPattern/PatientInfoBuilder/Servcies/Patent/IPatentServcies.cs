using PatientInfoBuilder.SampleModels.Patent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientInfoBuilder.Servcies.Patent
{
    public interface IPatentServcies
    {
        public void Add(PatentOutPutModel part);
    }
}
