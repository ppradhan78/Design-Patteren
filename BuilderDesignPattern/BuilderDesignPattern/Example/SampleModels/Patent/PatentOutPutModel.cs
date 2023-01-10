using BuilderDesignPattern.Example.PA;
using BuilderDesignPattern.Example.RiskFactor;
using BuilderDesignPattern.Example.SampleModels.ClinicalDocument;
using BuilderDesignPattern.Example.SampleModels.ClinicalGroup;
using BuilderDesignPattern.Example.SampleModels.Demographics;

namespace BuilderDesignPattern.Example.SampleModels.Patent
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
