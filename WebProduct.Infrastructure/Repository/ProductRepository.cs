using WebProduct.Core.Entities;
using WebProduct.Core.Interface;
using WebProduct.Infrastructure.Data;

namespace WebProduct.Infrastructure.Repository
{
    public class ProductRepository : GenericRepository<Products>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext context) : base(context)
        {

        }

    }


}
