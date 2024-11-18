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
                    Ack = AckBrand,
                    Push = CreateBrand,
                    Statistics = ProductStatistics
                },
                Category = new()
                {
                    Pull = CategoryGet,
                    Push = CategoryPush,
                    Statistics = ProductStatistics
                },
                ProductType = new()
                {
                    Pull = FetchProductType
                },
            },
            Flags = new FeatureFlags()
            {
                category_images_supported = true
            }
        };

    private async IAsyncEnumerable<ProductType> FetchProductType(QueryFilter arg)
    {
        yield return new ProductType()
        {
            id = new Identity()
            {
                endpoint = "test_product_type"
            },
            name = "Test Product Type",
        };
    }

    public async ValueTask<ConnectorIdentification> Identify()
    {
        return new ConnectorIdentification()
        {
            endpointVersion = "2.0",
            platformVersion = "",
            platformName = "Bulk",
            protocolVersion = 7,
            serverInfo = new ConnectorServerInfo()
            {
                executionTime = 600,
                memoryLimit = 2048,
                postMaxSize = 600000,
                uploadMaxFilesize = 500000
            }
        };
    }

    public async Task<bool> Clear()
    {
        
        return true;
    }

    private Task AckBrand(IReadOnlyCollection<Identity> arg, bool isClear)
    {
        
        
        return Task.CompletedTask;
    }

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
            id = new Identity()
            {
                endpoint = "apple",
                host = 0
            },
            name = "Apple",
            sort = 1,
            urlPath = "apple",
            websiteUrl = "https://apple.com",
            i18ns = [
                new ManufacturerI18n()
                {
                    description = "Apple Desc",
                    languageIso2 = "en",
                    metaDescription = "meta desc",
                    metaKeywords = "meta key",
                    titleTag = "title tag"
                }
            ]
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
