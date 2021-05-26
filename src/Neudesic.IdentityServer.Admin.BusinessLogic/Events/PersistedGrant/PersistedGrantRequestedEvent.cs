using Skoruba.AuditLogging.Events;
using Neudesic.IdentityServer.Admin.BusinessLogic.Dtos.Grant;

namespace Neudesic.IdentityServer.Admin.BusinessLogic.Events.PersistedGrant
{
    public class PersistedGrantRequestedEvent : AuditEvent
    {
        public PersistedGrantDto PersistedGrant { get; set; }

        public PersistedGrantRequestedEvent(PersistedGrantDto persistedGrant)
        {
            PersistedGrant = persistedGrant;
        }
    }
}