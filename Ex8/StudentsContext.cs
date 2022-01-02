using Ex8.Domain;
using Microsoft.EntityFrameworkCore;

namespace Ex8
{
    public class StudentsContext : DbContext
    {
        public DbSet<Student> Student { get; set; }

        public StudentsContext(DbContextOptions<StudentsContext> options) : base(options)
        {

        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer("Server=LAPTOP-GCUB180R\\SQLEXPRESS;Database=zad8;Trusted_Connection=True;MultipleActiveResultSets=True;");
            //.UseInMemoryDatabase("MoviesDb");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        }
    }
}
