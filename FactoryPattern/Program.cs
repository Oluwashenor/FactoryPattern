using FactoryPattern.Data;
using FactoryPattern.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using FactoryPattern.Factories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
//builder.Services.AddTransient<ITime, Time>();
//builder.Services.AddSingleton<Func<ITime>>(x => () => x.GetService<ITime>()!);
builder.Services.AddAbstractFactory<ITime, Time>(); // this line does the same thing as the ones above
builder.Services.AddAbstractFactory<ISample, Sample>();
builder.Services.AddGenericClassWithDataFactory();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
