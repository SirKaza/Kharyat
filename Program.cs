var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();
   

/*var recentGames = games
    .Where(game => game.Genre == "Action-adventure")
    .ToList();

foreach (var game in recentGames)
{
    Console.WriteLine(game.Title);
}
*/
try
{
    int year = int.Parse("abc");
}
catch (FormatException)
{
    Console.WriteLine("The year must be a valid format.");
}

IVideoGameRepository service = new VideoGameService();
var game = service.GetById(0);
Console.WriteLine(game?.Title);
game = service.GetById(2);
Console.WriteLine(game?.Title);

var service2 = new VideoGameService();
var games = await service2.GetAllAsync();
foreach (var g in games)
{
    Console.WriteLine(g.Title);
}

app.Run();