using KRB.Domain.Entities;

namespace KRB.Domain.Interfaces;

/// <summary>
/// این اینترفیس مدیریت داروخانه‌هایی را که درخواست را مشاهده کرده‌اند، بر عهده دارد.
/// </summary>
public interface IPharmacyRequestViewRepository
{
    Task MarkRequestAsViewedAsync(Guid requestId, Guid pharmacyId);
    Task<int> GetViewedPharmaciesCountAsync(Guid requestId);
    Task<List<PharmacyRequestView>> GetViewedPharmaciesAsync(Guid requestId);
}
