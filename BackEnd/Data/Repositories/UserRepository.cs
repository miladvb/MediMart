using KRB.Domain.Entities;
using KRB.Domain.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace KRB.Data.Repositories;

public class UserRepository : IUserRepository
{

    private readonly UserManager<User> _userManager;

    public UserRepository(UserManager<User> userManager)
    {
        _userManager = userManager;
    }


    public async Task<IdentityResult> RegisterUserAsync(User user, string password)
    {
        user.EmailConfirmed = false;
        var userresult = await _userManager.CreateAsync(user);
        return userresult;
    }

    public async Task<string> GenerateEmailConfirmationTokenAsync(User user)
    {
        var result = await _userManager.GenerateEmailConfirmationTokenAsync(user);
        return result;
    }

    public async Task<string> GeneratePasswordResetTokenAsync(User user)
    {
        var result = await _userManager.GeneratePasswordResetTokenAsync(user);
        return result;
    }

    public async Task<User> GetUserByEmailAsync(string email)
    {
        var result = await _userManager.FindByEmailAsync(email);
        return result;
    }

    public async Task<User> GetUserByUsername(string username)
    {
        var result = await _userManager.FindByNameAsync(username);
        return result;
    }

    public async Task<IdentityResult> ResetPasswordForEmail(User user, string Token, string password)
    {
        var result = await _userManager.ResetPasswordAsync(user, Token, password);
        return result;
    }

    public async Task<User?> GetUserByIdAsync(string userId)
    {
        var result = await _userManager.FindByIdAsync(userId);
        return result;
    }

  

    public Task<bool> VerifyEmailAsync(string userId, string token)
    {
        throw new NotImplementedException();
    }

    public Task<bool> VerifyMobileAsync(string userId, string token)
    {
        throw new NotImplementedException();
    }

    public Task<bool> LoginAsync(string username, string password)
    {
        throw new NotImplementedException();
    }

    public Task<bool> ForgotPasswordAsync(string emailOrPhone)
    {
        throw new NotImplementedException();
    }

}
