using Microsoft.EntityFrameworkCore;
using UFAR.TimeManagementTracker.Backend.Data;
using UFAR.TimeManagementTracker.Backend.Services;
using UFAR.TimeManagmentTracker.Backend.Services;
using UFAR.VirtuLearn.BFF.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers();

// Register your DbContext (make sure your connection string is in appsettings.json)
builder.Services.AddDbContext<TimeManagementContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Register your TimeManagementService in the DI container
builder.Services.AddScoped<ITimeManagementService, TimeManagementService>();
builder.Services.AddScoped<ISubmissionService, SubmissionService>();
// Register AIService with IAIService interface in the DI container
builder.Services.AddScoped<IAIService, AIService>();
  



// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
