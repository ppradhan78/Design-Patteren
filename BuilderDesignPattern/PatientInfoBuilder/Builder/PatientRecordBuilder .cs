using PatientInfoBuilder.SampleModels.Patent;
using PatientInfoBuilder.Servcies.ClinicalDocument;
using PatientInfoBuilder.Servcies.ClinicalGroup;
using PatientInfoBuilder.Servcies.Demographics;
using PatientInfoBuilder.Servcies.PA;
using PatientInfoBuilder.Servcies.Patent;
using PatientInfoBuilder.Servcies.RiskFactor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientInfoBuilder.Builder
{
    public class PatientRecordBuilder : IPatientRecordBuilder
    {
        private readonly PatentOutPutModel _patientRecord = new();
        #region Global Variable(s)
        private readonly IClinicalDocumentServcie _clinicalDocumentServcie;
        private readonly IClinicalGroupServices _clinicalGroupServices;
        private readonly IDemographicsServices _demographicsServices;
        private readonly IPAInfoServcies _pAInfoServcies;
        private readonly IPatentServcies _patentServcies;
        private readonly IRiskFactorServcie _riskFactorServcie;
        #endregion

        //public PatientRecordBuilder(
        //    IClinicalDocumentServcie clinicalDocumentServcie,
        //    IClinicalGroupServices clinicalGroupServices,
        //    IDemographicsServices demographicsServices,
        //    IPAInfoServcies pAInfoServcies,
        //    IPatentServcies patentServcies,
        //    IRiskFactorServcie riskFactorServcie
        //    )
        //{
        //    _clinicalDocumentServcie = clinicalDocumentServcie;
        //    _clinicalGroupServices = clinicalGroupServices;
        //    _demographicsServices = demographicsServices;
        //    _pAInfoServcies = pAInfoServcies;
        //    _patentServcies = patentServcies;
        //    _riskFactorServcie = riskFactorServcie;
        //}
        public PatentOutPutModel Build()
        {
            return _patientRecord;
        }
        public void AddClinicalInformation()
        {
            //_patientRecord.PatientClinicalGrouph = ClinicalGroupServices.GetAllClinicalGroup();
            _patientRecord.PatientClinicalGrouph= new ClinicalGroupServices().GetAllClinicalGroup();
        }

        public void AddDemographicInformation()
        {
            //_patientRecord.PatientDemographics= _demographicsServices.GetDemographics();
            _patientRecord.PatientDemographics =new DemographicsServices().GetDemographics();
        }

        public void AddDocumentInformation()
        {
            //_patientRecord.PatientClinicalDocument=_clinicalDocumentServcie.GetClinicalDocument();
            _patientRecord.PatientClinicalDocument = new ClinicalDocumentServcie().GetClinicalDocument();
        }

        public void AddPhysicianAdvisoryInformation()
        {
            //_patientRecord.PatientPAInfo= _pAInfoServcies.GetPAInfo();
            _patientRecord.PatientPAInfo = new PAInfoServcies().GetPAInfo();
        }

        public void AddRiskFactorsInformation()
        {
            //_patientRecord.PatientRiskFactor=_riskFactorServcie.GetAllRiskFactor();
            _patientRecord.PatientRiskFactor = new RiskFactorServcie().GetAllRiskFactor();
        }

       
    }
}
