using BuilderDesignPattern.Example.PA;
using BuilderDesignPattern.Example.SampleModels.ClinicalGroup;
using BuilderDesignPattern.Example.SampleModels.Demographics;
using BuilderDesignPattern.Example.SampleModels.Patent;
using BuilderDesignPattern.Example.Servcies.ClinicalDocument;
using BuilderDesignPattern.Example.Servcies.PA;
using BuilderDesignPattern.Example.Servcies.Patent;
using BuilderDesignPattern.Example.Servcies.RiskFactor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern.Example
{
    public class PatentInfoBuilder : IPatentInfoBuilder
    {
        private PatentOutPutModel _Patent = new PatentOutPutModel();
        public PatentInfoBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {
            this._Patent = new PatentOutPutModel();
        }
        public void PatientClinicalDocumentBuilder()
        {
            _Patent.PatientClinicalDocument = new ClinicalDocumentServcie().GetClinicalDocument();
        }

        public void PatientClinicalGrouphBuilder()
        {
            _Patent.PatientClinicalGrouph = new ClinicalGroupServices().GetAllClinicalGroup();
        }

        public void PatientDemographicsBuilder()
        {
            _Patent.PatientDemographics = new DemographicsServices().GetDemographics();
        }

        public void PatientPAInfoBuilder()
        {
            _Patent.PatientPAInfo = new PAInfoServcies().GetPAInfo();
        }

        public void PatientRiskFactorBuilder()
        {
            _Patent.PatientRiskFactor = new RiskFactorServcie().GetAllRiskFactor();

        }

        public PatentOutPutModel GetPatentDetails()
        {
            return _Patent;
        }

     
    }
}
