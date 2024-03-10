using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Exercises
    {
        public int ID { get; set; }
        public string description { get; set; }
        public string DateRegistration { get; set; }
        public string DateStart { get; set; }
        public string DateEnd { get; set; }

        [Column("fk_Admin_id")]
        public int Admin_id { get; set; }
        [Column("fk_user_id")]
        public int User_id { get; set; }

        [ForeignKey("fk_Admin_id")]
        public Admin Admin { get; set; }

        [ForeignKey("fk_user_id")]
        public User User { get; set; }
    }
}
