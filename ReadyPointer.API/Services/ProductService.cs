using System.Net;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using ReadyPointer.API.Config;
using ReadyPointer.API.IServices;
using ReadyPointer.API.Models;

namespace ReadyPointer.API.Services;

public class ProductService : IProductService
{
    private readonly HttpClient _httpClient;
    private readonly IOptions<EndpointsConfig> _options;
    
    public ProductService(HttpClient httpClient,
                          IOptions<EndpointsConfig> options)
    {
        _httpClient = httpClient;
        _options = options;
    }
    
    /**
     * 
     */
    public async Task<List<Product>?> GetProducts()
    {
        var url = $"{_options.Value.BaseUrl}{_options.Value.GetAllObjectsUrl}";
        var result = await _httpClient.GetAsync(url);
        if (!result.IsSuccessStatusCode)
        {
            if (result.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return null;
            }
            throw new HttpRequestException($"External API request failed with status code {result.StatusCode}");
        }
        var content = await result.Content.ReadAsStringAsync();
        var products = JsonConvert.DeserializeObject<List<Product>>(content);
        return products;
    }

    public Task<Product> GetProductById(string id)
    {
        throw new NotImplementedException();
    }

    public Task<Product> AddProduct(Product product)
    {
        throw new NotImplementedException();
    }

    public Task<Product> DeleteProduct(string id)
    {
        throw new NotImplementedException();
    }
}