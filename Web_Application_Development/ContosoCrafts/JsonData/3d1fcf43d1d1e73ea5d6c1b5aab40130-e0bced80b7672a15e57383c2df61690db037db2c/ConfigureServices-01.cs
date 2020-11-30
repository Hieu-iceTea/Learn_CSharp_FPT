public void ConfigureServices(IServiceCollection services)
{
    services.AddRazorPages();
    services.AddTransient<JsonFileProductService>();
}