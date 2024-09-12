var builder = WebApplication.CreateBuilder(args);

// servisleri ekleylim bvuraya
// mc servis kaydı yapacagız
builder.Services.AddControllersWithViews();

var app = builder.Build();

// http istek  hattını yapılandıralım 
app.UseStaticFiles();

// Routing yapılandırması da asagıdaki gibi olacak 

//  şimdi de Varsayılan routing tanımlayılım 
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});
app.UseRouting();

app.MapGet("/", () => "Hello World!");

app.Run();
