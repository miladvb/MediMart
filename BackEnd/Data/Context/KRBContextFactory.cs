using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using KRB.Data.Context; // ارجاع به پروژه KRB.Data

public class KRBContextFactory : IDesignTimeDbContextFactory<KRBContext>
{
    public KRBContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<KRBContext>();

        // تنظیم مسیر به appsettings.json پروژه KRB.WebApi
        var currentDirectory = Directory.GetCurrentDirectory();
        var projectRoot = Directory.GetParent(currentDirectory).FullName;
        var appSettingsPath = Path.Combine(projectRoot, "Presentation", "appsettings.json");


        var configuration = new ConfigurationBuilder()
            .SetBasePath(currentDirectory) // استفاده از پوشه فعلی به عنوان Base Path
            .AddJsonFile(appSettingsPath, optional: false, reloadOnChange: true)
            .Build();

        // استفاده از رشته اتصال از appsettings.json
        optionsBuilder.UseSqlServer(configuration.GetConnectionString("KRBConnectionString"));

        // بازگرداندن DbContext با استفاده از پیکربندی
        return new KRBContext(optionsBuilder.Options);
    }
}
