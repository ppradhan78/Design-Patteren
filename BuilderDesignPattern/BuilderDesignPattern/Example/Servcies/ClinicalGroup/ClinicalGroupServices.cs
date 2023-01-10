using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern.Example.SampleModels.ClinicalGroup
{
    public class ClinicalGroupServices
    {
        public ClinicalGroupOutputModel GetAllClinicalGroup()
        {
            return new ClinicalGroupOutputModel
            {
                ClinicalGroups = new List<ClinicalGroup>() { new ClinicalGroup { Id = 1, Name = "CARDIC" } }
            };
        }
    }

}
