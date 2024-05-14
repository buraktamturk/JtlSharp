using Jtl.Connector.Core.Model;

namespace JtlSharp.Example.Web;

public class SampleJtlService : IJtlService
{
    private readonly ILogger _logger;
    
    public SampleJtlService(ILogger<SampleJtlService> logger)
    {
        _logger = logger;
    }
    
    public Feature GetFeatures()
        => new()
        {
            Entities = new() {
                Product = new()
                {
                    Pull = GetProducts,
                    Push = CreateProduct,
                    Statistics = ProductStatistics
                },
                Manufacturer = new()
                {
                    Pull = GetBrands,
                    Push = CreateBrand,
                    Statistics = ProductStatistics
                },
                Category = new()
                {
                    Pull = CategoryGet,
                    Push = CategoryPush,
                    Statistics = ProductStatistics
                }
            },
            Flags = new FeatureFlags()
            {
                category_images_supported = true
            }
        };

    private async Task<Category> CategoryPush(Category arg)
    {
        return arg;
    }

    private async IAsyncEnumerable<Category> CategoryGet(QueryFilter arg)
    {
        yield return new Category()
        {

        };
    }

    private Task<int> ProductStatistics()
    {
        throw new NotImplementedException();
    }
    
    public async IAsyncEnumerable<Manufacturer> GetBrands(QueryFilter filter)
    {
        yield return new Manufacturer()
        {

        };
    }
    
    public async Task<Manufacturer> CreateBrand(Manufacturer product)
    {

        return product;
    }
    
    public async IAsyncEnumerable<Product> GetProducts(QueryFilter filter)
    {
        yield return new Product()
        {

        };
    }

    public async Task<Product> CreateProduct(Product product)
    {

        return product;
    }
}
