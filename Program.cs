var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
    app.UseHttpsRedirection();  // Only redirect HTTP to HTTPS in production
}
else
{
    // Optionally log that you're in Development
    app.Logger.LogInformation("Running in Development mode without HTTPS redirection.");
}

app.UseStaticFiles(); // Serve static files (CSS, JS, etc.)

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages(); // Map Razor Pages
app.MapFallbackToPage("/Start");

app.Run();
