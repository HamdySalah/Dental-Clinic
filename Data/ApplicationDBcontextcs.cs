using dental_clinic.Models;
using Microsoft.EntityFrameworkCore;

namespace dental_clinic.Data
{
  
        public class ApplicationDBcontext : DbContext
        {
            public ApplicationDBcontext(DbContextOptions<ApplicationDBcontext> options) : base(options) { }
            public DbSet<Doctors> Dcotors { get; set; }
            public DbSet<payment> payments { get; set; }
            public DbSet<paitents> paitents { get; set; }
            public DbSet<Appointment> Appointments { get; set; }
            public DbSet<Nuerses> Nuerses { get; set; }

        }

    
}
