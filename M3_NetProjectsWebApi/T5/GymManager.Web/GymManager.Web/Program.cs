

using GymManager.ApplicationServices.Members;
using GymManager.ApplicationServices.Navigation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Localization;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

// Agregar los servicios requeridos
builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
//builder.Services.AddSingleton<IMembersAppService, MembersAppService>();
builder.Services.AddTransient<IMembersAppService, MembersAppService>();
builder.Services.AddTransient<IMenuAppService, MenuAppService>();
//builder.Services.AddScoped<IMembersAppService, MembersAppService>();
// Resto de la configuración del servidor y la aplicación

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();


app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
});


app.MapRazorPages();
app.UseStaticFiles();

app.Run();