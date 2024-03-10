using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public  class User
    {
        public  int ID;
        public string userName { get; set;}
        public string password { get; set;}
        public bool isAdmin { get; set;}
        public DateTime date { get; set;}
        public string phone { get; set; }
        public string specialization { get; set; }
        public byte img { get; set; }


    }
}
