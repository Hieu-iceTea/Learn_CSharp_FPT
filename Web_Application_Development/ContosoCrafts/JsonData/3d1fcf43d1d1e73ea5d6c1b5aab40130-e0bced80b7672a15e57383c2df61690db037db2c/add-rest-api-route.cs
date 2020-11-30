endpoints.MapGet("/products", (context) => 
{
    var products = app.ApplicationServices.GetService<JsonFileProductService>().GetProducts();
    var json = JsonSerializer.Serialize<IEnumerable<Product>>(products);
    return context.Response.WriteAsync(json);
});