using WebProduct.Core.Interface;
using WebProduct.Infrastructure.Data;

namespace WebProduct.Infrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public IcategoryRepository CategoryRepository { get; }

        public IProductRepository ProductRepository { get; }

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;


            CategoryRepository = new CategoryRepository(_context);
            ProductRepository = new ProductRepository(_context);

        }
    }
}
