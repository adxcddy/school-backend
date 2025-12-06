using SchoolSystem.Server.Models;

namespace SchoolSystem.Server.Data;

public static class SeedData
{
    public static void EnsureSeedData(SchoolContext db)
    {
        if (!db.Admins.Any())
        {
            db.Admins.Add(new Admin { Id = Guid.NewGuid().ToString(), Username = "admin", PasswordHash = "admin" });
        }

        if (!db.Classes.Any())
        {
            db.Classes.Add(new Classroom { Id = Guid.NewGuid().ToString(), Name = "Form 1" });
            db.Classes.Add(new Classroom { Id = Guid.NewGuid().ToString(), Name = "Form 2" });
        }

        if (!db.Students.Any())
        {
            db.Students.Add(new Student { Id = Guid.NewGuid().ToString(), FirstName = "John", LastName = "Doe", Email = "john@example.com", ClassId = db.Classes.First().Id });
            db.Students.Add(new Student { Id = Guid.NewGuid().ToString(), FirstName = "Jane", LastName = "Smith", Email = "jane@example.com", ClassId = db.Classes.Skip(1).First().Id });
        }

        db.SaveChanges();
    }
}
