using System.ComponentModel.DataAnnotations;

namespace KRB.Domain.Entities;

public class RequestStatus
{
    [Key]
    public int Id { get; set; }  // شناسه وضعیت (مثلاً 1 = Pending, 2 = Viewed)

    [Required]
    public string Name { get; set; } = string.Empty;  // نام وضعیت (Pending, Viewed, Available)

    public string? Description { get; set; } // توضیح وضعیت (اختیاری)
}
