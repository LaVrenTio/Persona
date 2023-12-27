using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persone_Form.MyClasses
{
    public class Db_settings
    {
        public string ConnectionString {  get; set; }
        public Db_settings() {
            this.ConnectionString = "Data_Source=C:/lorenzo/Lorenz_db.db";
                
        }
    }
}
