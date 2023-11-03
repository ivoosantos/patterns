using CQRSMediator.Queries;

namespace CQRSMediator.Mediator
{
    public interface ICqrsMediator
    {
        Task<IMediatorResult> Handler(IQuery query);
        Task<IMediatorResult> Handler(ICommand command);
    }
    public class CqrsMediator : ICqrsMediator
    {
        public async Task<IMediatorResult> Handler(IQuery query)
        {
            IMediatorResult mediatorResult;

            if (query is null)
                mediatorResult = new MediatorResult(null, false);

            if(query is GetProductByIdQuery)
            {
                var handler = new GetProductByIdQueryHandler();

                var result = await handler.Handle(query as GetProductByIdQuery);

                mediatorResult = new MediatorResult(result, true);
            }
            else if(query is GetAllProductsQuery)
            {
                var handler = new GetAllProductsQueryHandler();

                var result = await handler.Handle(query as GetAllProductsQuery);

                mediatorResult = new MediatorResult(result, true);
            }
            else
            {
                mediatorResult = new MediatorResult(null, false);
            }

            return mediatorResult;
        }

        public Task<IMediatorResult> Handler(ICommand command)
        {
            throw new NotImplementedException();
        }
    }

    public interface IQuery { }
    public interface ICommand { }

    public interface IMediatorResult
    {
        object Data { get; }
        bool Success { get; }
    }

    public class MediatorResult : IMediatorResult
    {
        public MediatorResult(object data, bool success)
        {
            Data = data;
            Success = success;
        }

        public object Data { get; private set; }
        public bool Success { get; private set; }
    }
}
