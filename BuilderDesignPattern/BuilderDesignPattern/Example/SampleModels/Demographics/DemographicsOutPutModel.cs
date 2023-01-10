using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern.Example.SampleModels.Demographics
{
    public class DemographicsOutPutModel
    {
        public string PatentId { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string AccountNumber { get; set; }
        public string Status { get; set; }
        public DateTime Addmitdate { get; set; }

    }
}
