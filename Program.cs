// ============================================================
// Portfolio Website - Main Entry Point
// ============================================================
// This is the starting point of the ASP.NET Core application.
// It sets up the web server and configures middleware.
// ============================================================

var builder = WebApplication.CreateBuilder(args);

// Add MVC services to the container
// This enables Controllers and Views functionality
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    // In production, use error handler and HSTS
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

// Redirect HTTP to HTTPS for security
app.UseHttpsRedirection();

// Enable serving static files (CSS, JS, images)
app.UseStaticFiles();

// Enable routing
app.UseRouting();

// Map controller routes
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Run the application
app.Run();
