using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persone_Form.MyClasses
{
    public class RunTimeQueries
    {
        public List<Query> queries { get; set; }
        
        
        public RunTimeQueries() {
            this.queries = new List<Query>();
            
        }


    }
}
