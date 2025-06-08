namespace KRB.Application.Services.Interfaces;

public interface IAuthService
{
    Task<bool> RegisterUserAsync(string email, string password);
    Task<string> LoginAsync(string email, string password);
    Task<bool> VerifyEmailAsync(string userId);
    Task<bool> VerifyMobileAsync(string userId);
    Task<bool> ForgetPasswordAsync(string email);
}
