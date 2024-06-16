using DataAccessLibrary;
using LibraryManagementApp.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddTransient<ISqlDb, LibraryClass.SqlDb>(); //Adding a transient service for data which creates an instance every time we ask for it...singleton adds 1 instance for the entire application
builder.Services.AddTransient<IPeopleData, PeopleData>();
builder.Services.AddTransient<IBooksData, BooksData>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
