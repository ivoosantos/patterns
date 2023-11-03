using CQRSMediator.Models;

namespace CQRSMediator.Queries
{
    public class GetAllProductsQueryHandler
    {
        public Task<ProductViewModel> Handle(GetAllProductsQuery query)
        {
            return Task.FromResult(new ProductViewModel());
        }
    }
}
