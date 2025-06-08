using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KRB.Domain.Entities;

public class PharmacyRequestView
{

    [Key]
    public Guid Id { get; set; }

    [ForeignKey("Request")]
    public Guid RequestId { get; set; }

    [ForeignKey("Pharmacy")]
    public Guid PharmacyId { get; set; }

    public DateTime ViewedAt { get; set; } = DateTime.UtcNow;

    public Request Request { get; set; }
    public Pharmacy Pharmacy { get; set; }
}
