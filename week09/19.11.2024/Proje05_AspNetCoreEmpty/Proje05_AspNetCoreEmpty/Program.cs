var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();



app.UseStaticFiles();


//localhost:5200/home
//localhost:5200/product
//localhost:5200/product/details
//localhost:5200/product/details/4


app.MapControllerRoute(
    name:"default",
    pattern:"{controller=Home}/{action=Index}/{id?}"
);

app.Run();
