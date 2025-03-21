using Domain.Interface;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using Model.Configuration;
using Model.Entities;
using NoteAppBlazor.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();



builder.Services.AddDbContextFactory<PostContext>(
    options => options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
        new MySqlServerVersion(new Version(8, 0, 36))));

builder.Services.AddTransient<IRepositoryAsync<User>, UserRepositoryAsync>();
builder.Services.AddTransient<IRepositoryAsync<Post>, PostRepositoryAsync>();
builder.Services.AddScoped<UserRepositoryAsync>();
builder.Services.AddSingleton<LogInState>();



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