//Bu satırda bir uygulama oluşturucu  oluşturuluyor
var builder = WebApplication.CreateBuilder(args);
//bu satır projemizin MVC özelliklerini taşımasını sağlar
builder.Services.AddControllersWithViews();

//bu satırda ise yaratılan uygulama oluşturucu ile bir uygulama oluşturuluyor
var app = builder.Build();
//Burada çağırılan uygulamalar/metotlar MiddleWare olarak adlandırılırlar.(Ara yazılım)


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

//localhost:5192/Home/Index
//localhost:5192/Home/
//localhost:5192
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
//Bu satırda oluşturulmuş uygulama çalıştırılıyor
app.Run();
