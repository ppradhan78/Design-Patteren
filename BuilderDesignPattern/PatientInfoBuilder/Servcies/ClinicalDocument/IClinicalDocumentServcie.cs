using PatientInfoBuilder.SampleModels.ClinicalDocument;

namespace PatientInfoBuilder.Servcies.ClinicalDocument
{
    public interface IClinicalDocumentServcie
    {
        public ClinicalDocumentOutputModel GetClinicalDocument();
    }
}
