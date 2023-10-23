using GloboTicket.TicketManagement.Application.Contracts.Persistence;
using GloboTicket.TicketManagement.Domain.Entities;
using Mapster;
using MediatR;

namespace GloboTicket.TicketManagement.Application.Features.Events;

public class GetEventDetailQueryHandler : IRequestHandler<GetEventDetailQuery, EventDetailVm>
{
    private readonly IAsyncRepository<Event> _eventRepository;
    private readonly IAsyncRepository<Category> _categoryRepository;

    public GetEventDetailQueryHandler(IAsyncRepository<Event> eventRepository,
        IAsyncRepository<Category> catagoryRepository)
    {
        _eventRepository = eventRepository;
        _categoryRepository = catagoryRepository;
    }

    public async Task<EventDetailVm> Handle(GetEventDetailQuery request, CancellationToken cancellationToken)
    {
        var @event = await _eventRepository.GetByIdAsync(request.Id);
        var category = await _categoryRepository.GetByIdAsync(@event.Id);

        var eventDetail = @event.Adapt<EventDetailVm>();
        eventDetail.Category = category.Adapt<CategoryDto>();

        return eventDetail;
    }
}
