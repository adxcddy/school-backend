using Microsoft.EntityFrameworkCore;
using SchoolSystem.Server.Models;

namespace SchoolSystem.Server.Data;

public class SchoolContext : DbContext
{
    public SchoolContext(DbContextOptions<SchoolContext> opts) : base(opts) { }

    public DbSet<Student> Students { get; set; } = null!;
    public DbSet<Admin> Admins { get; set; } = null!;
    public DbSet<Classroom> Classes { get; set; } = null!;
    public DbSet<PaymentTransaction> PaymentTransactions { get; set; } = null!;
    public DbSet<Enrollment> Enrollments { get; set; } = null!;
    public DbSet<Grade> Grades { get; set; } = null!;
    public DbSet<Teacher> Teachers { get; set; } = null!;
    public DbSet<Subject> Subjects { get; set; } = null!;
    public DbSet<Classroom> Classrooms { get; set; }
    public DbSet<Attendance> Attendance { get; set; }
}
