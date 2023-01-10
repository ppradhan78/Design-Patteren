using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern.Example.SampleModels.ClinicalGroup
{
    public class ClinicalGroupOutputModel
    {
        public List<ClinicalGroup> ClinicalGroups   { get; set; }
    }
    public class ClinicalGroup 
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
