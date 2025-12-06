using System.ComponentModel.DataAnnotations;

namespace SchoolSystem.Server.Models
{
    public class Attendance
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(191)]
        public string StudentId { get; set; } = string.Empty;

        public DateTime Date { get; set; } = DateTime.UtcNow;
        public bool Present { get; set; }

        public Student? Student { get; set; }
    }
}
