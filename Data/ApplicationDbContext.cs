using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using assignment1.Models;

namespace assignment1.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<Student>().Property(m => m.FirstName).HasMaxLength(40);
        builder.Entity<Student>().Property(m => m.LastName).HasMaxLength(40);
        builder.Entity<Student>().Property(m => m.MobileNumber).HasMaxLength(15);
        builder.Entity<Student>().Property(m => m.EmailAddress).HasMaxLength(200);
        builder.Entity<Student>().Property(m => m.CityOfResidence).HasMaxLength(25);
        builder.Entity<Student>().Property(m => m.Specialization).HasMaxLength(25);
        builder.Entity<Student>().ToTable("Student");
        builder.Seed();
    }
    public DbSet<assignment1.Models.Student> Student { get; set; }
}
