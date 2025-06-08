
using KRB.Domain.Entities;

namespace KRB.Domain.Interfaces;

public interface IActivityRepository
{
    Task<List<Activity>> GetAllActivitiesAsync();
}
