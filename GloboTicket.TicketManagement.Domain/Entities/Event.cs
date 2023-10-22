using GloboTicket.TicketManagement.Domain.Common;
using GloboTicket.TicketManagement.Domain.Common.Audited;

namespace GloboTicket.TicketManagement.Domain.Entities;

public class Event : EntityBase, ITimes, IUserAudited
{
    public required string Name { get; set; }

    public decimal Price { get; set; }

    public string? Artist { get; set; }

    public DateTime Date { get; set; }

    public string? Description { get; set; }

    public string? ImageUrl { get; set; }

    public string CategoryId { get; set; } = default!;

    public Category Category { get; set; } = default!;

    public DateTime? CreatedAt { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? UpdatedBy { get; set; }
}
