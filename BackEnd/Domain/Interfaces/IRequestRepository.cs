using KRB.Domain.Entities;

namespace KRB.Domain.Interfaces;

public interface IRequestRepository
{
    Task AddRequestAsync(Request request);
    Task<Request?> GetRequestByIdAsync(Guid requestId);
    Task<List<Request>> GetUserRequestsAsync(Guid userId);
    Task UpdateRequestStatusAsync(Guid requestId, int statusId);
    Task DeleteRequestAsync(Guid requestId);
}
