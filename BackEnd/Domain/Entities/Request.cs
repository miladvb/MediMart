using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KRB.Domain.Entities;


/// <summary>
/// این کلاس مشخص می‌کند که کدام داروخانه درخواست را مشاهده کرده و چه زمانی آن را دیده است
/// </summary>
public class Request
{


    public Request()
    {
        User = new User();
        ViewedPharmacies = new List<PharmacyRequestView>();
        Responses = new List<RequestResponse>();
    }

    [Key]
    public Guid Id { get; set; }

    [ForeignKey("User")]
    public Guid UserId { get; set; }
    public string MedicineName { get; set; } = string.Empty;
    public string? MedicineImageUrl { get; set; }
    public DateTime RequestTime { get; set; }
    public bool IsCancelled { get; set; }

    public User User { get; set; }

    // وضعیت درخواست
    [ForeignKey("RequestStatus")]
    public int RequestStatusId { get; set; }  // وضعیت درخواست


    // لیست داروخانه‌هایی که درخواست را مشاهده کرده‌اند
    public List<PharmacyRequestView> ViewedPharmacies { get; set; }

    // لیست پاسخ‌های داروخانه‌ها
    public List<RequestResponse> Responses { get; set; }

}