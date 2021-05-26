using Skoruba.AuditLogging.Events;
using Neudesic.IdentityServer.Admin.BusinessLogic.Dtos.Configuration;

namespace Neudesic.IdentityServer.Admin.BusinessLogic.Events.IdentityResource
{
    public class IdentityResourcePropertyRequestedEvent : AuditEvent
    {
        public IdentityResourcePropertiesDto IdentityResourceProperties { get; set; }

        public IdentityResourcePropertyRequestedEvent(IdentityResourcePropertiesDto identityResourceProperties)
        {
            IdentityResourceProperties = identityResourceProperties;
        }
    }
}