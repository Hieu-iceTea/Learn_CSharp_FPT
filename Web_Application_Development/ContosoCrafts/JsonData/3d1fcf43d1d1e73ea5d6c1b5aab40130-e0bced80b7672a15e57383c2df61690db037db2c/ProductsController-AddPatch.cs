[HttpPatch]
public ActionResult Patch([FromBody] RatingRequest request)
{
    ProductService.AddRating(request.ProductId, request.Rating);

    return Ok();
}

public class RatingRequest
{
    public string ProductId { get; set; }
    public int Rating { get; set; }
}