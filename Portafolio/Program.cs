using Portafolio.Servicios;
using Portafolio.Servicios.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//AddTransient --> servicios que viven por menos tiempo, cada vez que una clase intenta inyectar el servicio al constructor se le sirve una nueva instancia
//AddScoped --> Servicios delimitados a una misma peticion de http
//AddSingleton --> Servicio que vive para simpre, es unico, siempre se va a servir la misma instancia del servicio
builder.Services.AddTransient<IRepositorioProyectos, RepositorioProyectos>();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
