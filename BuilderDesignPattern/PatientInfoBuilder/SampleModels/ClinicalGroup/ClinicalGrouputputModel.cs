namespace PatientInfoBuilder.SampleModels.ClinicalGroup
{
    public class ClinicalGroupOutputModel
    {
        public List<ClinicalGroupModel> ClinicalGroups   { get; set; }
    }
    public class ClinicalGroupModel 
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
