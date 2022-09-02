using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Lms2.Data.Data;
using Lms2.Api.Extentions;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Lms2ApiContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Lms2ApiContext") ?? throw new InvalidOperationException("Connection string 'Lms2ApiContext' not found.")));

// Add services to the container.
//Registrara services gör att servicerna kan injekas i vår kod
// Svarsmeddelande när önskat svarsformat inte stöds (default json)  statuskod 400 


builder.Services.AddControllers(opt => opt.ReturnHttpNotAcceptable = true) //(opt => opt.InputFormatters .....vilket format som är default
    //lägger till support för olika format
    .AddNewtonsoftJson()
    .AddXmlDataContractSerializerFormatters();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle 


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddSingleton<FileExtentionContentTypeProvider>(); ===> singeltin-lifetime tar fram filtyp på extern fil
//===> i filen där vi ska använda servicen skapar vi:
// * konstruktor som tar (FileExtentionContentTypeProvider) som argument
// * variabel (private readonly FileExtentionContentTypeProvider)
// * lägger till using (xxxx.StaticFiles)


var app = builder.Build();

await app.SeedDataAsync();

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


//blå=variabler /object
//vit = Interface
//gul=funktion
// grön=Typ?