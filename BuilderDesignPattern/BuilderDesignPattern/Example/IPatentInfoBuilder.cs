using BuilderDesignPattern.Example.PA;
using BuilderDesignPattern.Example.SampleModels.Patent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern.Example
{
    public interface IPatentInfoBuilder
    {
        void PatientDemographicsBuilder();
        void PatientClinicalDocumentBuilder();
        void PatientClinicalGrouphBuilder();
        void PatientRiskFactorBuilder();
        void PatientPAInfoBuilder();
        public PatentOutPutModel GetPatentDetails();
    }
}
