using PatientInfoBuilder.SampleModels.ClinicalDocument;

namespace PatientInfoBuilder.Servcies.ClinicalDocument
{
    public class ClinicalDocumentServcie: IClinicalDocumentServcie
    {
        public ClinicalDocumentOutputModel GetClinicalDocument()
        {
            return new ClinicalDocumentOutputModel{Documents= new List<string>() { "H&P", "ED" } } ;
        }
    }
}
