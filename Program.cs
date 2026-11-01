using Microsoft.EntityFrameworkCore;
using Lupas_Miruna_Lab2.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<Lupas_Miruna_Lab2Context>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("Lupas_Miruna_Lab2Context") 
                      ?? throw new InvalidOperationException("Connection string 'Lupas_Miruna_Lab2Context' not found.")));

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapRazorPages();

app.Run();