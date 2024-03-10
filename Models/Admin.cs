using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Admin
    {
        public int Id { get; set; }

        [Column("fk_user_id")]
        public int UserID { get; set; }

        [ForeignKey("fk_user_id")]
        List<User> users { get; set; }
    }
}
