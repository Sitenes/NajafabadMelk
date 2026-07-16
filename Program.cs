using Microsoft.AspNetCore.Rewrite;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection"); // نام کانکشن استرینگ را از appsettings.json بخوانید
builder.Services.AddDbContext<RealEstateDbContext>(options =>
    options.UseSqlServer(connectionString));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

var rewriteOptions = new RewriteOptions()
    .AddRewrite(@"^(fa|en|ar)/(images|css|js|fonts|lib)/(.*)$", "$2/$3", skipRemainingRules: true)
    .AddRewrite(@"^(fa|en|ar)/(WebSite\.styles\.css)$", "$2", skipRemainingRules: true);

app.UseRewriter(rewriteOptions);

app.UseStaticFiles();
app.MapStaticAssets();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "localized_default",
    pattern: "{lang:regex(^fa$|^en$|^ar$)}/{controller=Home}/{action=Index}/{id?}"
).WithStaticAssets();

app.MapControllerRoute(
    name: "default_without_lang",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<RealEstateDbContext>();

    // await db.Database.MigrateAsync();
}
app.Run();
