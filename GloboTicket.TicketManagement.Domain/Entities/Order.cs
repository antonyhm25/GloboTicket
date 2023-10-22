using GloboTicket.TicketManagement.Domain.Common;
using GloboTicket.TicketManagement.Domain.Common.Audited;

namespace GloboTicket.TicketManagement.Domain.Entities;

public class Order : EntityBase, ITimes, IUserAudited
{
    public string UserId { get; set; } = default!;

    public int OrderTotal { get; set; }

    public DateTime OrderPlaced { get; set; }

    public bool OrderPaid { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? UpdatedBy { get; set; }
}
