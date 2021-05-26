using Skoruba.AuditLogging.Events;
using Neudesic.IdentityServer.Admin.BusinessLogic.Dtos.Configuration;

namespace Neudesic.IdentityServer.Admin.BusinessLogic.Events.ApiResource
{
    public class ApiResourcePropertyAddedEvent : AuditEvent
    {
        public ApiResourcePropertyAddedEvent(ApiResourcePropertiesDto apiResourceProperty)
        {
            ApiResourceProperty = apiResourceProperty;
        }

        public ApiResourcePropertiesDto ApiResourceProperty { get; set; }
    }
}