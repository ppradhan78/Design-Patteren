using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientInfoBuilder.Builder
{
    public interface IExtenderPatientRecordBuilder: IPatientRecordBuilder
    {
        string InsuranceInfo { get; set; } // new field
    }
}
