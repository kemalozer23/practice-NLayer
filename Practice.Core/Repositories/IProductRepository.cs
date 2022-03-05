namespace Practice.Core.Repositories
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task<List<Product>> GetProductsWithCategory();
    }
}