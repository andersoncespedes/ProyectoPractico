using Microsoft.EntityFrameworkCore;
using Persistence.Data;
using API.Extensions;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.ConfigureRatelimiting();
builder.Services.ConfigureApiVersioning();
builder.Services.ConfigureCors();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<APIContext>(option => {
    string con = builder.Configuration.GetConnectionString("DefaultCon");
    option.UseMySql(con, ServerVersion.AutoDetect(con));
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("CorsPolicy");
app.UseAuthorization();

app.MapControllers();

app.Run();
