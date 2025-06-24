using PatientInfoBuilder.SampleModels.ClinicalGroup;

namespace PatientInfoBuilder.Servcies.ClinicalGroup
{
    public class ClinicalGroupServices: IClinicalGroupServices
    {
        public ClinicalGroupOutputModel GetAllClinicalGroup()
        {
            return new ClinicalGroupOutputModel
            {
                ClinicalGroups = new List<ClinicalGroupModel>() { new ClinicalGroupModel { Id = 1, Name = "CARDIC" } }
            };
        }
    }

}
