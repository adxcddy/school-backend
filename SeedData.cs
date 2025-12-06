using SchoolSystem.Server.Data;
using SchoolSystem.Server.Models;

public static class SeedData
{
    public static void EnsureSeedData(SchoolContext db)
    {
        if (!db.Admins.Any())
        {
            db.Admins.Add(new Admin
            {
                Username = "admin",
                PasswordHash = "e10adc3949ba59abbe56e057f20f883e" // default: 123456 (MD5 or your hash)
            });
        }
        
        if (!db.Classrooms.Any())
        {
              db.Classrooms.Add(new Classroom { Id = "c1", Name = "S1" });

        }

        db.SaveChanges();
    }
}
