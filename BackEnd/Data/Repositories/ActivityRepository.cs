
using KRB.Data.Context;
using KRB.Domain.Entities;
using KRB.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace KRB.Data.Repositories;

public class ActivityRepository : IActivityRepository
{

    private readonly KRBContext _context;

    public ActivityRepository(KRBContext context)
    {
        _context = context;
    }


    public async Task<List<Activity>> GetAllActivitiesAsync()
    {
        return await _context.Activities.ToListAsync();
    }

}
