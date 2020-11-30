int currentRating = 0;
int voteCount = 0;
string voteLabel;

void GetCurrentRating()
{
  if(selectedProduct.Ratings == null)
  {
    currentRating = 0;
    voteCount = 0;
  }
  else
  {
    voteCount = selectedProduct.Ratings.Count();
    voteLabel = voteCount > 1 ? "Votes" : "Vote";
    currentRating = selectedProduct.Ratings.Sum() / voteCount;
  }

  System.Console.WriteLine($"Current rating for {selectedProduct.Id}: {currentRating}");
}

void SubmitRating(int rating)
{
  System.Console.WriteLine($"Rating received for {selectedProduct.Id}: {rating}");
  ProductService.AddRating(selectedProductId, rating);
  SelectProduct(selectedProductId);
}