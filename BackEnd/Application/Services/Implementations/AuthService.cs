using KRB.Application.Services.Interfaces;

namespace KRB.Application.Services.Implementations;

public class AuthService : IAuthService
{
    public Task<bool> ForgetPasswordAsync(string email)
    {
        throw new NotImplementedException();
    }

    public Task<string> LoginAsync(string email, string password)
    {
        throw new NotImplementedException();
    }

    public Task<bool> RegisterUserAsync(string email, string password)
    {
        throw new NotImplementedException();
    }

    public Task<bool> VerifyEmailAsync(string userId)
    {
        throw new NotImplementedException();
    }

    public Task<bool> VerifyMobileAsync(string userId)
    {
        throw new NotImplementedException();
    }

}
