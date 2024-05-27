using System.Net;
using TaskManagement.Dbo;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("SiUserConnection")), ServiceLifetime.Transient);

#region  Scopes
//builder.Services.AddScoped<ICadastroService, CadastroService>();
//builder.Services.AddScoped<ITokenService, TokenService>();
#endregion


builder.Services.AddControllers();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
