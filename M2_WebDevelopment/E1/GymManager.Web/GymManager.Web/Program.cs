using System.Net;

var builder = WebApplication.CreateBuilder(args);
//la carpeta wwwroot es donde se ubicaran todo el contenido estatico, imaganes, videos, css, etc.

// Add services to the container.
//invocacion del metodo addControllerWithView de la intancia services
builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseAuthorization();

//app.MapGet("/hi", () => "Hello!");

app.MapDefaultControllerRoute();
app.MapRazorPages();

//para poder acceder a los archivos estaticos se debe usar el método "app.UseStaticFiles();"
//lo que hace es registrar/indicar la petición del navegador http hacia 
//el archivo que se encuentre en esa ruta
app.UseStaticFiles();

//app.MapGet("/", () => "Hello World!");

//app.MapGet("/File1.html", () => "Test content of file1.html. I'm happy!");
//app.MapGet("/File1.html", () => DateTime.Now.ToString());

app.Run();