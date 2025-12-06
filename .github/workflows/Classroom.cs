using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolSystem.Server.Models;

public class Classroom
{
    [Key]
    [MaxLength(191)]
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
}
