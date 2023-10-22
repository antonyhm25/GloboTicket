using GloboTicket.TicketManagement.Domain.Common;
using GloboTicket.TicketManagement.Domain.Common.Audited;

namespace GloboTicket.TicketManagement.Domain.Entities;

public class Category : EntityBase, ITimes, IUserAudited
{
    public required string Name { get; set; }

    public ICollection<Event> Events { get; set; }
        = new List<Event>();

    public DateTime? CreatedAt { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? UpdatedBy { get; set; }
}
