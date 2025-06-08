using System.ComponentModel.DataAnnotations;
using KRB.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace KRB.Application.Identity;

public class UniqueUsernameAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        var userManager = validationContext.GetService(typeof(UserManager<User>)) as UserManager<User>;
        if (userManager == null)
            return new ValidationResult("خطا در اعتبارسنجی: سرویس مدیریت کاربر پیدا نشد.");
        var username = value as string;

        if (!string.IsNullOrEmpty(username))
        {
            var user = userManager.FindByNameAsync(username);
            if (user != null)
                return new ValidationResult($"نام کاربری '{username}' قبلاً وجود دارد.");
        }
        return ValidationResult.Success;

    }
}

public class UniqueEmailAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        var userManager = validationContext.GetService(typeof(UserManager<User>)) as UserManager<User>;
        if (userManager == null)
            return new ValidationResult("خطا در اعتبارسنجی: سرویس مدیریت کاربر پیدا نشد.");

        var email = value as string;
        if (!string.IsNullOrEmpty(email))
        {
            var userEmail = userManager.FindByEmailAsync(email);
            if (userEmail != null)
                return new ValidationResult($"ایمیل '{email}' قبلاً ثبت شده است.");
        }


        return ValidationResult.Success;
    }
}
