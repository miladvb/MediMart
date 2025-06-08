using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace KRB.Domain.Entities;

public class User : IdentityUser<Guid>
{

}

