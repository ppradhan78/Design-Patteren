using PatientInfoBuilder.SampleModels.Patent;

namespace PatientInfoBuilder.Servcies.Patent
{
    public  class PatentServcies: IPatentServcies
    {
        private List<object> _parts = new List<object>();
        public void Add(PatentOutPutModel part)
        {
            this._parts.Add(part);
        }
    }
}
