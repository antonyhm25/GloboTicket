namespace GloboTicket.TicketManagement.Domain.Common;

public class EntityBase
{

    public EntityBase()
    {
        Id ??= Guid.NewGuid().ToString();
    }

    public string Id { get; set; }
}
