using KRB.Domain.Entities;

namespace KRB.Domain.Interfaces;
/// <summary>
/// این اینترفیس مربوط به مدیریت پاسخ‌های داروخانه‌ها به درخواست‌ها است.
/// </summary>
public interface IRequestResponseRepository
{
    Task RespondToRequestAsync(Guid requestId, Guid pharmacyId, string responseMessage);
    Task<List<RequestResponse>> GetRequestResponsesAsync(Guid requestId);
    Task<RequestResponse?> GetResponseByIdAsync(Guid responseId);
    Task DeleteResponseAsync(Guid responseId);
}
