using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KRB.Domain.Entities;

/// <summary>
/// این کلاس مشخص می‌کند که کدام داروخانه چه پاسخی به درخواست داده و چه زمانی پاسخ ارسال شده است.
/// </summary>
public class RequestResponse
{
    [Key]
    public Guid Id { get; set; }

    [ForeignKey("Request")]
    public Guid RequestId { get; set; }

    [ForeignKey("Pharmacy")]
    public Guid PharmacyId { get; set; }

    public string ResponseMessage { get; set; } = string.Empty; // مثلا "دارو موجود است" یا "این دارو را نداریم"
    public DateTime ResponseTime { get; set; } = DateTime.UtcNow;

    public Request Request { get; set; }
    public Pharmacy Pharmacy { get; set; }
}
