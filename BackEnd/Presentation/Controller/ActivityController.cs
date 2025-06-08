using KRB.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace KRB.WebApi.Controller;

[ApiController]
[Route("api/[controller]")]
public class ActivityController : BaseApiController
{
    private readonly IActivityService _activityService;

    public ActivityController(IActivityService activityService)
    {
        _activityService = activityService;
    }


    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var activities = await _activityService.GetAllActivitiesAsync();
        // در صورتی که لیست خالی باشد
        if (activities == null || activities.Count == 0)
        {
            return NotFound(new { message = "No activities found." });
        }

        return Ok(activities);
    }
}
