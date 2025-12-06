using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolSystem.Server.Models;

public class Enrollment
{
    [Key]
    [MaxLength(191)]
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string StudentId { get; set; } = string.Empty;
    public string ClassId { get; set; } = string.Empty;
    public DateTime EnrolledAt { get; set; } = DateTime.UtcNow;
    public Student? Student { get; set; }
    public Classroom? Classroom { get; set; }
    public DateTime EnrolledOn { get; set; } = DateTime.UtcNow;
    public string? ClassName
        {
            get
            {
                return Classroom != null ? Classroom.Name : null;
            }
        }
}
        