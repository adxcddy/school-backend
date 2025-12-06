using SchoolSystem.Server.Data;
using SchoolSystem.Server.Models;

namespace SchoolSystem.Server.Services;

public class PaymentService
{
    private readonly SchoolContext _db;
    public PaymentService(SchoolContext db) => _db = db;

    public PaymentTransaction Record(decimal amount, string currency, string? studentId = null, string? provider = null, string? providerTxnId = null)
    {
        var tx = new PaymentTransaction { Amount = amount, Currency = currency, StudentId = studentId, Provider = provider, ProviderTransactionId = providerTxnId };
        _db.PaymentTransactions.Add(tx);
        _db.SaveChanges();
        return tx;
    }
}
