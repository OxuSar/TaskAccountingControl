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
        public string Name {get; set;}
        public string Phone { get; set; }
        public string Specialization { get; set; }
        public byte img { get; set; }
        public Admin Admin { get; set; }

        public int ExercisesId { get; set; }
        public List<Exercises> exercises { get; set; }

    }
}
