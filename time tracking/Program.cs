using Microsoft.EntityFrameworkCore;
using Serilog;
using time_tracking.DataAccess;
using time_tracking.DataAccess.Repository;
using time_tracking.DataAccess.Repository.IRepository;
using time_tracking.Service;
using time_tracking.Service.IService;

var builder = WebApplication.CreateBuilder(args);

try
{
    Log.Logger = new LoggerConfiguration()
        .ReadFrom.Configuration(builder.Configuration)
        .CreateLogger(); 

    builder.Host.UseSerilog();
    Log.Information("Starting web application");

    builder.Services.AddControllers();

    builder.Services.AddDbContext<ApplicationDbContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


    builder.Services.AddScoped<IProjectRepository, ProjectRepository>();
    builder.Services.AddScoped<ITasksRepository, TasksRepository>();
    builder.Services.AddScoped<ITasksCommentsRepository, TasksCommentsRepository>();

    builder.Services.AddScoped<IServiceProject, ServiceProject>();
    builder.Services.AddScoped<IServiceTasks, ServiceTasks>();
    builder.Services.AddScoped<IServiceTasksComments, ServiceTasksComments>();

    // Cors
    builder.Services.AddCors();

    // Add services to the container.
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

    builder.Services.AddHealthChecks();

    var app = builder.Build();

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    // Cors
    app.UseCors(policyBuilder => policyBuilder.AllowAnyOrigin()
        .AllowAnyHeader()
        .AllowAnyMethod());

    app.UseHttpsRedirection();

    app.MapControllers();

    app.Run();
}
catch (Exception ex)
{
    Log.Fatal(ex, "Application terminated unexpectedly");
}
finally
{
    Log.CloseAndFlush();
}
