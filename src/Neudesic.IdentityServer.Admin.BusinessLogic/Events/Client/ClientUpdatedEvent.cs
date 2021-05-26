using Skoruba.AuditLogging.Events;
using Neudesic.IdentityServer.Admin.BusinessLogic.Dtos.Configuration;

namespace Neudesic.IdentityServer.Admin.BusinessLogic.Events.Client
{
    public class ClientUpdatedEvent: AuditEvent
    {
        public ClientDto OriginalClient { get; set; }
        public ClientDto Client { get; set; }

        public ClientUpdatedEvent(ClientDto originalClient, ClientDto client)
        {
            OriginalClient = originalClient;
            Client = client;
        }
    }
}