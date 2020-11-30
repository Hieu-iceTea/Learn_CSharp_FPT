public void ConfigureServices(IServiceCollection services)
{
    services.AddRazorPages();
    services.AddServerSideBlazor();
    services.AddControllers();
    services.AddTransient<JsonFileProductService>();
}