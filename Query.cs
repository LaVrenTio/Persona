using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persone_Form.MyClasses
{
    public class Query
    {
        public string QueryText { get; set; }
        public string QueryType { get; set; }


        public Query( string text)
        {
            
            this.QueryType = "";
            this.QueryText = text;
        }
    }
}
