var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();

var app = builder.Build();

app.UseStaticFiles();

app.MapControllerRoute("default", "{controller=About}/{action=Index}/{id?}");
app.Run();
