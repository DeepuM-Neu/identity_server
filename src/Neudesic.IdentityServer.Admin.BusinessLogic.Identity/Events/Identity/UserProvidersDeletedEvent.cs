using Skoruba.AuditLogging.Events;

namespace Neudesic.IdentityServer.Admin.BusinessLogic.Identity.Events.Identity
{
    public class UserProvidersDeletedEvent<TUserProviderDto> : AuditEvent
    {
        public TUserProviderDto Provider { get; set; }

        public UserProvidersDeletedEvent(TUserProviderDto provider)
        {
            Provider = provider;
        }
    }
}