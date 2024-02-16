using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Exercises
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public Admin Admin { get; set; }
        
        public int UserID { get; set; }
        public User User { get; set; }
    }
}
