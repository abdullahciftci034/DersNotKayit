using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DersNotKayit.SqlConnectionClass
{
    public  class ogrencipuan
    {
        public int id {  get; set; }
        public string name { get; set; }    
        public int puan { get; set; }
        public ogrencipuan(int id , int puan , string name)
        {
            this.id = id;
            this.puan = puan;
            this.name = name;
        }
    }
}
