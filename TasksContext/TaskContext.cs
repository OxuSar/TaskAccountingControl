using Microsoft.EntityFrameworkCore;
using Models;
using System.Threading.Tasks;

namespace TasksContext
{
    public class TaskContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Exercises> Excercises { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-71EDCUE\\SQLEXPRESS;Initial Catalog=MyTask;Integrated Security=True;Encrypt=False");
        }
    }
   
}
