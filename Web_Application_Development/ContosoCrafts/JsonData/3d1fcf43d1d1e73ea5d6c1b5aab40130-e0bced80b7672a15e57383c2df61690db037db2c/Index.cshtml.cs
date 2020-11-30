public IndexModel(ILogger<IndexModel> logger,
    JsonFileProductService productService)
{
    _logger = logger;
    ProductService = productService;
}

public JsonFileProductService ProductService { get; }
public IEnumerable<Product> Products { get; private set; }

public void OnGet()
{
    Products = ProductService.GetProducts();
}