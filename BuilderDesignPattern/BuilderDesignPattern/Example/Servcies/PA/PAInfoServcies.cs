using BuilderDesignPattern.Example.PA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern.Example.Servcies.PA
{
    public class PAInfoServcies
    {
       
        public PAInfoOutputModel GetPAInfo()
        {
            return new PAInfoOutputModel { DateTime = DateTime.Now, PANote = "PA test Note" };
        }

    }
}
