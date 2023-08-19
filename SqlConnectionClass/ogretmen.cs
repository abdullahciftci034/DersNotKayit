using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DersNotKayit.SqlConnectionClass
{
    public class ogretmen
    {
        int id { get; set; }    
        public int tcno { get; set; }  
        public string password { get; set; }

        public ogretmen(int id, int tcno, string password)
        {
            this.id = id;
            this.tcno = tcno;
            this.password = password;
        }
    }
}
