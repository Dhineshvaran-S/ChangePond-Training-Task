using Microsoft.EntityFrameworkCore;

namespace EFCCRUDDEMO.Models
{
    public class CompanyContext : DbContext
    {

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasOne(d => d.Department)
                .WithMany(p => p.Employee)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_emp_dept");
            });
        }
        public CompanyContext(DbContextOptions<CompanyContext> options) : base(options)
        {

        }

        public DbSet<Department> Department { get; set; }

        public DbSet<Employee> Employees { get; set; }


    }
}
