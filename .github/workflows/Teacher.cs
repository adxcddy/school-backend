using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolSystem.Server.Models;

public class Teacher
{
    [Key]
    [MaxLength(191)]
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}
