using BuilderDesignPattern.Example.SampleModels.Patent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern.Example.Servcies.Patent
{
   public  class PatentServcies
    {
        private List<object> _parts = new List<object>();
        public void Add(PatentOutPutModel part)
        {
            this._parts.Add(part);
        }
    }
}
