using PatientInfoBuilder.SampleModels.PA;

namespace PatientInfoBuilder.Servcies.PA
{
    public class PAInfoServcies: IPAInfoServcies
    {
        public PAInfoOutputModel GetPAInfo()
        {
            return new PAInfoOutputModel { DateTime = DateTime.Now, PANote = "PA test Note" };
        }

    }
}
