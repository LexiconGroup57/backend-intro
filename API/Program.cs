using API;
using API.repos;
using API.services;
using Backend_intro;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin();
    });
});
builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddScoped<IFinanceService, SavingsService>();

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("AllowAll");
app.MapControllers();
app.MapGet("/", () => "Hello World!");

app.MapGet("/api/values", () => new[] { "value1", "value2" });
app.MapGet("/about", () => "About");
app.MapGet("/contact", () => "Contact");
app.MapGet("/products/{category}", (string category) => "Product is of category: " + category);
app.MapGet("/products/{category}/{id}", (string category, int id) => "Product is of category: " + category + " and id: " + id);
app.MapGet("/{random}", (string random) => "This page doesn't exist");
app.MapGet("/guess/{number}", (int number) =>
{
    if (number == 42) return "You guessed it!";
    else if (number < 42) return "Too low";
    else return "Too high";
});
app.MapPost("/api/call", (DateTime start, DateTime end) =>
{
    CareProvider provider = new CareProvider();
    if (start > end) return "Start time must be before end time";
    provider.ScheduleTimeSlot(start, end);
    CareProviderRepo repo = new CareProviderRepo();
    repo.PostProvider(provider);
    return "Time slot scheduled";
});
app.MapPost("/api/values", (string value) => "Got a value: " + value);
app.MapPost("/home", (HomeViewModel homeViewModel) =>
{
    return homeViewModel.Description;
});
app.Run();