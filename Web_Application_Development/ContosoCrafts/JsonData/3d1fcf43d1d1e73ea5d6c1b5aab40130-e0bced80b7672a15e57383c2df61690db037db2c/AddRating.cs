public void AddRating(string productId, int rating)
{
    var products = GetProducts();
    var query = products.First(x => x.Id == productId);

    if(query.Ratings == null)
    {
        query.Ratings = new int[] { rating };
    }
    else
    {
        var ratings = query.Ratings.ToList();
        ratings.Add(rating);
        query.Ratings = ratings.ToArray();
    }

    using(var outputStream = File.OpenWrite(JsonFileName))
    {
        JsonSerializer.Serialize<IEnumerable<Product>>(
            new Utf8JsonWriter(outputStream, new JsonWriterOptions
            {
                SkipValidation = true,
                Indented = true
            }), 
            products
        );
    }
}