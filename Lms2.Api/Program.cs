using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Lms2.Data.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Lms2ApiContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Lms2ApiContext") ?? throw new InvalidOperationException("Connection string 'Lms2ApiContext' not found.")));

// Add services to the container.
// Svars medelande vid fel typp kod 400
builder.Services.AddControllers(opt => opt.ReturnHttpNotAcceptable = true)
    .AddNewtonsoftJson()
    .AddXmlDataContractSerializerFormatters();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
