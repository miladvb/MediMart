using KRB.Domain.Entities;
using KRB.Domain.Interfaces;

namespace KRB.Data.Repositories;

public class RequestRepository : IRequestRepository
{
    public Task AddRequestAsync(Request request)
    {
        throw new NotImplementedException();
    }

    public Task DeleteRequestAsync(Guid requestId)
    {
        throw new NotImplementedException();
    }

    public Task<Request?> GetRequestByIdAsync(Guid requestId)
    {
        throw new NotImplementedException();
    }

    public Task<List<Request>> GetUserRequestsAsync(Guid userId)
    {
        throw new NotImplementedException();
    }

    public Task UpdateRequestStatusAsync(Guid requestId, int statusId)
    {
        throw new NotImplementedException();
    }

}
