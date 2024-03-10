using MediatR;

namespace Ordering.Application.Features.Orders.Queries.GetOrdersList;

public sealed record GetOrdersListQuery : IRequest<List<OrderResponse>>
{
    public string UserName { get; set; }

    public GetOrdersListQuery(string userName)
    {
        UserName = userName;
    }
}
