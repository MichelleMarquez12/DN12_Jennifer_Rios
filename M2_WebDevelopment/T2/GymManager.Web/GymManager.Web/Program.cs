var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//para poder acceder a los archivos estaticos se debe usar el método "app.UseStaticFiles();"
//lo que hace es registrar/indicar la petición del navegador http hacia 
//el archivo que se encuentre en esa ruta
app.UseStaticFiles();

app.MapGet("/", () => "Hello World!");

//app.MapGet("/File1.html", () => "Test content of file1.html. I'm happy!");
app.MapGet("/File1.html", () => DateTime.Now.ToString());

//la carpeta wwwroot es donde se ubicaran todo el contenido estatico, imaganes, videos, css, etc.
app.Run();
