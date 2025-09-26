using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using TaskManager.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<TaskManagerContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Seed test data
using (IServiceScope scope = app.Services.CreateScope())
{
    TaskManagerContext db = scope.ServiceProvider.GetRequiredService<TaskManagerContext>();
    db.Database.Migrate();

    if (!db.Tasks.Any())
    {
        db.Tasks.AddRange(
            new TaskManager.Data.Models.Task() { Title = "Buy groceries", OwnerID = "test-user-1" },
            new TaskManager.Data.Models.Task() { Title = "Do dishes", OwnerID = "test-user-1" }
        );
        db.SaveChanges();
    }
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

app.Run();
