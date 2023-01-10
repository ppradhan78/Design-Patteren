using BuilderDesignPattern.Example.SampleModels.ClinicalDocument;
using System.Collections.Generic;

namespace BuilderDesignPattern.Example.Servcies.ClinicalDocument
{


    public class ClinicalDocumentServcie
    {
        public ClinicalDocumentOutputModel GetClinicalDocument()
        {
            return new ClinicalDocumentOutputModel{Documents= new List<string>() { "H&P", "ED" } } ;
        }
    }
}
