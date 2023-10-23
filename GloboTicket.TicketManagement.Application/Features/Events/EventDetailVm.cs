namespace GloboTicket.TicketManagement.Application.Features.Events;

public class EventDetailVm
{
    public required string Id { get; set; }

    public required string Name { get; set; }

    public decimal Price { get; set; }

    public string? Artist { get; set; }

    public DateTime Date { get; set; }

    public string? Description { get; set; }

    public string? ImageUrl { get; set; }

    public required string CategoryId { get; set; }

    public required CategoryDto Category { get; set; }
}
