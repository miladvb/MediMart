using KRB.Application.DTOs.Activiteis;

namespace KRB.Application.Services.Interfaces;

public interface IActivityService
{
    Task<List<ActivityViewModel>> GetAllActivitiesAsync();
}
