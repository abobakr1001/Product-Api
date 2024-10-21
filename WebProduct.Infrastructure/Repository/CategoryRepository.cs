using WebProduct.Core.Entities;
using WebProduct.Core.Interface;
using WebProduct.Infrastructure.Data;

namespace WebProduct.Infrastructure.Repository
{
    public class CategoryRepository : GenericRepository<Category>, IcategoryRepository
    {
        public CategoryRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
