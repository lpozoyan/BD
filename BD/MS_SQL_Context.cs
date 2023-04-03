using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VovaBD.BD
{
    internal class MS_SQL_Context : DbContext
    {
        string cs = "Server=192.168.49.180; Database=Karamela19; user id=stud; password=stud; TrustServerCertificate=true;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(cs);
        }
        public DbSet<User> Users { get; set; }
    }
   
}
