using Skoruba.AuditLogging.Events;
using Neudesic.IdentityServer.Admin.BusinessLogic.Dtos.Configuration;

namespace Neudesic.IdentityServer.Admin.BusinessLogic.Events.ApiScope
{
    public class ApiScopeDeletedEvent : AuditEvent
    {
        public ApiScopeDto ApiScope { get; set; }

        public ApiScopeDeletedEvent(ApiScopeDto apiScope)
        {
            ApiScope = apiScope;
        }
    }
}