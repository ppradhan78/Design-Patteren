using PatientInfoBuilder.SampleModels.ClinicalGroup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientInfoBuilder.Servcies.ClinicalGroup
{
    public interface IClinicalGroupServices
    {
        public ClinicalGroupOutputModel GetAllClinicalGroup();
    }
}
