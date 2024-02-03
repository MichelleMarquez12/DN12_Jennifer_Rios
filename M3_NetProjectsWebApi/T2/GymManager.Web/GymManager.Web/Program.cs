

using GymManager.ApplicationServices.Members;
using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);

// Agregar los servicios requeridos
builder.Services.AddRazorPages();

//builder.Services.AddSingleton<IMembersAppService, MembersAppService>();
builder.Services.AddTransient<IMembersAppService, MembersAppService>();
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

app.Map("/Members", app =>
{
    app.UseEndpoints(endpoints =>
    {
        endpoints.MapControllerRoute(
            name: "default",
            pattern: "{controller=Members}/{action=Index}/{id?}"
        );
    });
});


app.MapRazorPages();
app.UseStaticFiles();

app.Run();