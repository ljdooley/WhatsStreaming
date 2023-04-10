using Microsoft.EntityFrameworkCore;
using WhatsStreaming.Data;
using WhatsStreaming.Data.Database;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<WhatsStreamingContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("WhatsStreaming")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<WhatsStreamingContext>();

    bool created = dbContext.Database.EnsureCreated();

    if (created)
    {
        var seedDatabase = new SeedDatabase(dbContext);
        seedDatabase.AddSeedData();
    }
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
