using Skoruba.AuditLogging.Events;
using Neudesic.IdentityServer.Admin.BusinessLogic.Dtos.Configuration;

namespace Neudesic.IdentityServer.Admin.BusinessLogic.Events.Client
{
    public class ClientClaimRequestedEvent : AuditEvent
    {
        public ClientClaimsDto ClientClaims { get; set; }

        public ClientClaimRequestedEvent(ClientClaimsDto clientClaims)
        {
            ClientClaims = clientClaims;
        }
    }
}