using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolSystem.Server.Models;

public class Grade
{
    [Key]
    [MaxLength(191)]
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string StudentId { get; set; } = string.Empty;
    public string SubjectId { get; set; } = string.Empty;
    public decimal Score { get; set; }
}
