var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();


app.MapControllerRoute("test","{Area:Exists}/{controller=Home}/{action=privacy}/{id?}");
//app.MapControllerRoute("test", "{Area:Exists}/{controller=Home}/{action=privacy}/{id?}/{name}");

////app.MapControllerRoute(
//    name: "default",
//    pattern: "{Area=Admin}/{controller=Category}/{action=create}/{id?}");

app.MapControllerRoute("test1", "{controller=Home}/{action=privacy}/{id?}");

app.Run();
