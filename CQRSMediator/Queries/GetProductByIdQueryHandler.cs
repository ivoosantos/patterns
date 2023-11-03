using CQRSMediator.Models;

namespace CQRSMediator.Queries
{
    public class GetProductByIdQueryHandler
    {
        public Task<ProductDetailsViewModel> Handle(GetProductByIdQuery query)
        {
            return Task.FromResult(new ProductDetailsViewModel());
        }
    }
}
