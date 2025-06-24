namespace PatientInfoBuilder.SampleModels.RiskFactor
{
    public class RiskFactorOutputmodel
    {
        public List<RiskFactorModel> HighRiskFactor { get; set; }
        public List<RiskFactorModel> LowRiskFactor { get; set; }

    }
    public class RiskFactorModel 
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
