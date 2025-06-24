using PatientInfoBuilder.SampleModels.ClinicalDocument;
using PatientInfoBuilder.SampleModels.ClinicalGroup;
using PatientInfoBuilder.SampleModels.Demographics;
using PatientInfoBuilder.SampleModels.PA;
using PatientInfoBuilder.SampleModels.RiskFactor;

namespace PatientInfoBuilder.SampleModels.Patent
{
    public class PatentOutPutModel
    {
        public DemographicsOutPutModel PatientDemographics { get; set; }
        public ClinicalDocumentOutputModel PatientClinicalDocument { get; set; }

        public ClinicalGroupOutputModel PatientClinicalGrouph { get; set; }

        public RiskFactorOutputmodel PatientRiskFactor { get; set; }

        public PAInfoOutputModel PatientPAInfo { get; set; }

    }
}
