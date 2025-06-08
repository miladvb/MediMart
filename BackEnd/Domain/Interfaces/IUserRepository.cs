using KRB.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace KRB.Domain.Interfaces;

public interface IUserRepository
{
    Task<IdentityResult> RegisterUserAsync(User user, string password);

    Task<string> GenerateEmailConfirmationTokenAsync(User user);
    Task<string> GeneratePasswordResetTokenAsync(User user);
    Task<IdentityResult> ResetPasswordForEmail(User user, string Token, string password);

    Task<User> GetUserByEmailAsync(string email);
    Task<User> GetUserByUsername(string username);


    Task<User?> GetUserByIdAsync(string userId);
    Task<bool> VerifyEmailAsync(string userId, string token);
    Task<bool> VerifyMobileAsync(string userId, string token);
    Task<bool> LoginAsync(string username, string password);
    Task<bool> ForgotPasswordAsync(string emailOrPhone);

}
