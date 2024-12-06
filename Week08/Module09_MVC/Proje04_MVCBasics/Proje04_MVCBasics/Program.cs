//Bu sat�rda bir uygulama olu�turucu  olu�turuluyor
var builder = WebApplication.CreateBuilder(args);
//bu sat�r projemizin MVC �zelliklerini ta��mas�n� sa�lar
builder.Services.AddControllersWithViews();

//bu sat�rda ise yarat�lan uygulama olu�turucu ile bir uygulama olu�turuluyor
var app = builder.Build();
//Burada �a��r�lan uygulamalar/metotlar MiddleWare olarak adland�r�l�rlar.(Ara yaz�l�m)


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
//Bu sat�rda olu�turulmu� uygulama �al��t�r�l�yor
app.Run();
