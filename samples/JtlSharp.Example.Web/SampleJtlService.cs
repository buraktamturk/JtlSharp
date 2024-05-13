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
                }
            },
            Flags = new FeatureFlags()
            {
                category_images_supported = true
            }
        };

    private Task<int> ProductStatistics()
    {
        throw new NotImplementedException();
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
