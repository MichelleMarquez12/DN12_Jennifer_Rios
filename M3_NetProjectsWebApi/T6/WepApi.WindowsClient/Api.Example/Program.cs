var builder = WebApplication.CreateBuilder(args);

// Configurar los servicios de la aplicaci�n
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configurar la canalizaci�n de solicitudes HTTP
app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Test API v1"));

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();
app.UseAuthentication();

app.MapControllers();

app.Run();