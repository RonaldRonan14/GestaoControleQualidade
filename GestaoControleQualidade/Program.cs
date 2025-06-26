using GestaoControleQualidade.Apresentacao.Components;
using GestaoControleQualidade.Infraestrutura.Dados;
using GestaoControleQualidade.Infraestrutura.Repositorios;
using GestaoControleQualidade.Servico.Perfis;
using GestaoControleQualidade.Servico.Servicos;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddAutoMapper(typeof(TarefaPerfil));

builder.Services.AddDbContext<GestaoControleQualidadeDb>(opt =>
{
    opt.UseInMemoryDatabase("GestaoControleQualidadeDb");
});

builder.Services.AddScoped<TarefaRepositorio>();
builder.Services.AddScoped<TarefaServico>();
    
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
