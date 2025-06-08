
using KRB.IOC.Dependencies;
using KRB.WebApi.Controller;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.RegisterServices(builder.Configuration);

builder.Services.AddControllers();
builder.Services.AddControllers()
    .AddApplicationPart(typeof(Program).Assembly);  // این به ASP.NET Core می‌گوید که کنترلرها رو از اسمبلی فعلی بگیره
                                                    //.AddApplicationPart(typeof(Test).Assembly);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("ReactivitiesPloicy");
app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();



app.Run();