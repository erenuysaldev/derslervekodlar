using ECommerce.Business.Abstract;
using ECommerce.Business.Concrete;
using ECommerce.Business.Configuration;
using ECommerce.Business.Mapping;
using ECommerce.Data.Abstract;
using ECommerce.Data.Concrete;
using ECommerce.Data.Concrete.Contexts;
using ECommerce.Data.Concrete.Repositories;
using ECommerce.Entity.Concrete;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ECommerceDbContext>(x=>x.UseSqlServer(builder.Configuration.GetConnectionString("SqlServerConnection")));

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped(typeof(IGenericRepository<>),typeof(GenericRepository<>));
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IProductService, ProductService>();

builder.Services.AddAutoMapper(typeof(MappingProfile));
//Identity ayarlar� 
builder.Services.AddIdentity<ApplicationUser, ApplicationRole>(options =>
{
    options.Password.RequireDigit = true;
    options.Password.RequireUppercase = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireNonAlphanumeric = true;
    options.Password.RequiredLength = 8;

    options.User.RequireUniqueEmail = true;
    options.User.AllowedUserNameCharacters = "qwertyuopasdfghjklizxcvbnm1234567890-_.@";

}).AddEntityFrameworkStores<ECommerceDbContext>().AddDefaultTokenProviders();
//OptionsPattern kullanarak JwtConfig bilgilerini appsettings.json dosyas�ndan okuyoruz.
builder.Services.Configure<JwtConfig>(builder.Configuration.GetSection("JwtConfig"));
var  jwtConfig = builder.Configuration.GetSection("JwtConfig").Get<JwtConfig>();




//JWT(Authentication) ayarlar�
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience=true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer= jwtConfig?.Issuer,
        ValidAudience = jwtConfig?.Audience,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtConfig?.Secret ?? ""))
    }; .AddEntityFrameworkStores<ECommerceDbContext>().AddDefaultTokenProviders();

});









var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();