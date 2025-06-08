using KRB.Domain.Entities;

namespace KRB.Domain.Interfaces;

/// <summary>
/// این اینترفیس برای مدیریت وضعیت‌های مختلف درخواست‌ها طراحی شده است.
/// </summary>
public interface IRequestStatusRepository
{
    Task<List<RequestStatus>> GetAllStatusesAsync();
    Task<RequestStatus?> GetStatusByIdAsync(int statusId);
    Task AddStatusAsync(RequestStatus status);
    Task DeleteStatusAsync(int statusId);
}
