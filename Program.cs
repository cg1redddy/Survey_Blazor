using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using SurevyPoC.Data;

var builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration;

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();


var apiUrl = configuration["AppSettings:API_Url"];
var apiSecretKey = configuration["AppSettings:API_Key"];
var apiSecretValue = configuration["AppSettings:API_Value"];
builder.Services.AddHttpClient<ISurveyService, SurveyService>(client =>
{
    //get from appsettings.json file
    // client.BaseAddress = new Uri("https://my.api.mockaroo.com");
    client.BaseAddress = new Uri(apiUrl);
    client.DefaultRequestHeaders.Add(apiSecretKey, apiSecretValue);
});

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
