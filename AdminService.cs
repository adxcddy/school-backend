using SchoolSystem.Server.Data;
using SchoolSystem.Server.Models;
using System.Security.Cryptography;
using System.Text;

namespace SchoolSystem.Server.Services;

public class AdminService
{
    private readonly SchoolContext _db;
    public AdminService(SchoolContext db) => _db = db;

    private string HashPassword(string password)
    {
        using var sha = SHA256.Create();
        var bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
        return BitConverter.ToString(bytes).Replace("-", "").ToLower();
    }

    public Admin CreateAdmin(string username, string password)
    {
        var hashed = HashPassword(password);
        var admin = new Admin { Id = Guid.NewGuid().ToString(), Username = username, PasswordHash = hashed };
        _db.Admins.Add(admin);
        _db.SaveChanges();
        return admin;
    }

    public Admin? Login(string username, string password)
    {
        var hashed = HashPassword(password);
        return _db.Admins.FirstOrDefault(a => a.Username == username && a.PasswordHash == hashed);
    }
}
