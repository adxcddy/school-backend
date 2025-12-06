using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolSystem.Server.Models;

public class PaymentTransaction
{
    [Key]
    [MaxLength(191)]
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public decimal Amount { get; set; }
    public string Currency { get; set; } = "USD";
    public string? StudentId { get; set; }
    public string? Provider { get; set; }
    public string? ProviderTransactionId { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public Student? Student { get; set; }
}
