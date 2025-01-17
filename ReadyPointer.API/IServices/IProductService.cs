using ReadyPointer.API.Models;

namespace ReadyPointer.API.IServices;

public interface IProductService
{
    Task<List<Product>?> GetProducts();
    Task<Product> GetProductById(string id);
    Task<Product> AddProduct(Product product);
    Task<Product> DeleteProduct(string id);
}