using CadastrarFuncionariosMVC.Repository;
using CadastrarFuncionariosMVC.Service;
using CadastrarFuncionariosMVC.Context;
using Microsoft.EntityFrameworkCore;
using CadastrarFuncionariosMVC.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Configuração do DbContext (Mover para cima, antes de `builder.Build()`)
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

// Services
builder.Services.AddScoped<IFuncionariosService, FuncionariosService>();

// Repositories
builder.Services.AddScoped<IFuncionariosRepository, FuncionariosRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Inicio}/{action=Index}/{id?}");

app.Run();
