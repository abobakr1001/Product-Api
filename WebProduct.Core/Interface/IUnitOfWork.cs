namespace WebProduct.Core.Interface
{
    public interface IUnitOfWork
    {
        public IcategoryRepository CategoryRepository { get; }
        public IProductRepository ProductRepository { get; }

        //public IBasketRepository BasketRepository { get; }
    }
}
