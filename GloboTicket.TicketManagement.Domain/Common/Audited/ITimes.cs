namespace GloboTicket.TicketManagement.Domain.Common.Audited;

public interface ITimes
{
    DateTime? CreatedAt { get; set; }

    DateTime? UpdatedAt { get; set; }
}
