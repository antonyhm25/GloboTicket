using GloboTicket.TicketManagement.Application.Contracts.Persistence;
using GloboTicket.TicketManagement.Domain.Entities;
using Mapster;
using MediatR;

namespace GloboTicket.TicketManagement.Application.Features.Events;

public class GetEventsListQueryHandler : IRequestHandler<GetEventsListQuery, IReadOnlyList<EventListVm>>
{

    private readonly IAsyncRepository<Event> _repository;

    public GetEventsListQueryHandler(IAsyncRepository<Event> repository)
    {
        _repository = repository;
    }

    public async Task<IReadOnlyList<EventListVm>> Handle(GetEventsListQuery request, CancellationToken cancellationToken)
    {
        var allEvents = (await _repository.ListAllAsync()).OrderBy(e => e.Date);
        return allEvents.Adapt<IReadOnlyList<EventListVm>>();
    }
}
