using MediatR;

namespace GloboTicket.TicketManagement.Application.Features.Events;

public class GetEventDetailQuery : IRequest<EventDetailVm>
{
    public required string Id { get; set; }
}
