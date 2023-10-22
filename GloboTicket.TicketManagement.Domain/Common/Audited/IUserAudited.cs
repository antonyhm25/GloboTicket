namespace GloboTicket.TicketManagement.Domain.Common.Audited;

public interface IUserAudited
{
    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }
}
