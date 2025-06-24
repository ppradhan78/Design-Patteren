using PatientInfoBuilder.SampleModels.Patent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientInfoBuilder.Builder
{
    public class ExtenderPatientRecordBuilder : IExtenderPatientRecordBuilder
    {
        public string InsuranceInfo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void AddClinicalInformation()
        {
            throw new NotImplementedException();
        }

        public void AddDemographicInformation()
        {
            throw new NotImplementedException();
        }

        public void AddDocumentInformation()
        {
            throw new NotImplementedException();
        }

        public void AddPhysicianAdvisoryInformation()
        {
            throw new NotImplementedException();
        }

        public void AddRiskFactorsInformation()
        {
            throw new NotImplementedException();
        }

        public PatentOutPutModel Build()
        {
            throw new NotImplementedException();
        }
    }
}
