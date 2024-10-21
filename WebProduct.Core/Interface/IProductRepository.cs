using WebProduct.Core.Entities;

namespace WebProduct.Core.Interface
{
    public interface IProductRepository : IGenericRepository<Products>
    {

        // Task<IEnumerable<ProductDto>> GetAllAsync(ProductParams productParams);
        //Task<ReturnProductDto> GetAllAsync(ProductParams productParams);
        //Task<bool> AddAsync(CreateProductDto dto);
        //Task<bool> UpdateAsync(int id, UpdateProductDto dto);

        //Task<bool> DeleteAsync(int id);
    }
}
