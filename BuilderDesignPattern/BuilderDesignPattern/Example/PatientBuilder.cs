using BuilderDesignPattern.Example.SampleModels.Patent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern.Example
{
    public class PatientBuilder
    {
        private IPatentInfoBuilder _toyBuilder;
        public PatientBuilder(IPatentInfoBuilder toyBuilder)
        {
            _toyBuilder = toyBuilder;
        }
        public void CreatePatent()
        {
            _toyBuilder.PatientDemographicsBuilder();
            _toyBuilder.PatientClinicalDocumentBuilder();
            _toyBuilder.PatientClinicalGrouphBuilder();
            _toyBuilder.PatientPAInfoBuilder();
            _toyBuilder.PatientRiskFactorBuilder();
        }
        public PatentOutPutModel GetPatentDetails()
        {
            return _toyBuilder.GetPatentDetails();
        }
    }
}
