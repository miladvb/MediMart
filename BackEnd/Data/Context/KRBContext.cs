using KRB.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KRB.Data.Context;

public class KRBContext : IdentityDbContext<User, Role, Guid>
{
    public DbSet<Activity> Activities { get; set; }

    public KRBContext(DbContextOptions<KRBContext> dbContext) : base(dbContext)
    {

    }



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }

}
