using KRB.Application.DTOs.Activiteis;
using KRB.Application.Services.Interfaces;
using KRB.Domain.Interfaces;

namespace KRB.Application.Services.Implementations;

public class ActivityService : IActivityService
{
    private readonly IActivityRepository _activityRepository;

    public ActivityService(IActivityRepository activityRepository)
    {
        _activityRepository = activityRepository;
    }


    public async Task<List<ActivityViewModel>> GetAllActivitiesAsync()
    {
        var list = await _activityRepository.GetAllActivitiesAsync();
        var lstVM = list.Select(x => new ActivityViewModel
        {
            Category = x.Category,
            City = x.City,
            Date = x.Date,
            Description = x.Description,
            Id = x.Id,
            Title = x.Title,
            Venue = x.Venue
        }).ToList();

        return lstVM;
    }

}
