//Bu satýrda bir uygulama oluþturucu  oluþturuluyor
var builder = WebApplication.CreateBuilder(args);
//bu satýr projemizin MVC özelliklerini taþýmasýný saðlar
builder.Services.AddControllersWithViews();

//bu satýrda ise yaratýlan uygulama oluþturucu ile bir uygulama oluþturuluyor
var app = builder.Build();
//Burada çaðýrýlan uygulamalar/metotlar MiddleWare olarak adlandýrýlýrlar.(Ara yazýlým)


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
//Bu satýrda oluþturulmuþ uygulama çalýþtýrýlýyor
app.Run();
