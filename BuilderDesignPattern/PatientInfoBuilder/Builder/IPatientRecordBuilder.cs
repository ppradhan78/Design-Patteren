using PatientInfoBuilder.SampleModels.Patent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientInfoBuilder.Builder
{
    public interface IPatientRecordBuilder
    {
        PatentOutPutModel Build();
        void AddClinicalInformation();
        void AddDemographicInformation();
        void AddRiskFactorsInformation();
        void AddDocumentInformation();
        void AddPhysicianAdvisoryInformation();
        
    }
}
