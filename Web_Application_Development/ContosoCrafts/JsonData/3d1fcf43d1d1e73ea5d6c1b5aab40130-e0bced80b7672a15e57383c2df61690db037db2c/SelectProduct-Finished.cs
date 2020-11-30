void SelectProduct(string productId)
{
    selectedProductId = productId;
    selectedProduct = ProductService.GetProducts().First(x => x.Id == productId);
    GetCurrentRating();
}