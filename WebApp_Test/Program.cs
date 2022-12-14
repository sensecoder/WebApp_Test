var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc();
var app = builder.Build();
app.UseHttpsRedirection();
app.UseDefaultFiles();
app.UseStaticFiles();
app.UseRouting();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}" );

app.Run();
