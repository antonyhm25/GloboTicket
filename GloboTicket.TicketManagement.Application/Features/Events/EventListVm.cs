namespace GloboTicket.TicketManagement.Application.Features.Events;

public class EventListVm
{
    public required string Id { get; set; }

    public required string Name { get; set; }

    public DateTime Date { get; set; }

    public string? ImageUrl { get; set; }
}
