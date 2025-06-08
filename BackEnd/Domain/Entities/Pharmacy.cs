using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KRB.Domain.Entities;

public class Pharmacy
{

    public Pharmacy()
    {
        RegisteredAt = DateTime.Now;
        User = new User();
    }

    [Key]
    public Guid Id { get; set; }
    public string PharmacyName { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string MobileNumber { get; set; } = string.Empty;
    public string Latitude { get; set; } = string.Empty;
    public string Longitude { get; set; } = string.Empty;
    public string ManagerName { get; set; } = string.Empty;
    public DateTime RegisteredAt { get; set; }
    public byte[]? Logo { get; set; }
    public string LogoName { get; set; } = string.Empty;
    public string LogoExtension { get; set; } = string.Empty;


    [ForeignKey("User")]
    public Guid UserId { get; set; }
    public User User { get; set; }


}
