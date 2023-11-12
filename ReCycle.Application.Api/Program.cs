using ReCycle.Application.Service.ApplicationServiceLogin;
using ReCycle.Domain.Service.LoginContextService;
using ReCycle.Infra.SqlServer;
using ReCycle.Infra.SqlServer.Interfaces.ICadastroContextRepository;
using ReCycle.Infra.SqlServer.Interfaces.IConfigContextRepository;
using ReCycle.Infra.SqlServer.Interfaces.IEnderecoContextRepository;
using ReCycle.Infra.SqlServer.Interfaces.IMapaColetaContextRepository;
using ReCycle.Infra.SqlServer.Interfaces.ITrocaPontuacaoContextRepository;
using ReCycle.Infra.SqlServer.Repositories.CadastroContextRepository;
using ReCycle.Infra.SqlServer.Repositories.ConfigContextRepository;
using ReCycle.Infra.SqlServer.Repositories.EnderecoContextRepository;
using ReCycle.Infra.SqlServer.Repositories.MapaColetaContextRepository;
using ReCycle.Infra.SqlServer.Repositories.TrocaPontuacaoContextRepository;

var builder = WebApplication.CreateBuilder(args);

// Injection Of Controll

// AdminContext
builder.Services.AddScoped<IConfigRepository, ConfigRepository>();
// CadastroContext
builder.Services.AddScoped<IAdminRepository, AdminRepository>();
builder.Services.AddScoped<IColetorRepository, ColetorRepository>();
builder.Services.AddScoped<IDescartanteRepository, DescartanteRepository>();
builder.Services.AddScoped<ILojaRepository, LojaRepository>();
// EnderecoContext
builder.Services.AddScoped<IEnderecoRepository, EnderecoRepository>();
builder.Services.AddScoped<IUserEnderecoRepository, UserEnderecoRepository>();
// MapaColetaContext
builder.Services.AddScoped<IAreaColetaRepository, AreaColetaRepository>();
builder.Services.AddScoped<IPontoColetaRepository, PontoColetaRepository>();
// TrocaPontuacaoContext
builder.Services.AddScoped<ICupomRepository, CupomRepository>();
builder.Services.AddScoped<IPontuacaoRepository, PontuacaoRepository>();
builder.Services.AddScoped<IPontuacaoCupomRepository, PontuacaoCupomRepository>();

// Services
builder.Services.AddScoped<ValidacaoLoginService, ValidacaoLoginService>();
builder.Services.AddScoped<ApplicationServiceValidacaoLogin, ApplicationServiceValidacaoLogin>();

// SqlServerContext
builder.Services.AddScoped<SqlServerContext, SqlServerContext>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configuration Cors
app.UseCors("corsapp");
app.UseCors(c =>
{
    c.AllowAnyHeader();
    c.AllowAnyMethod();
    c.AllowAnyOrigin();
});

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
