using Skoruba.AuditLogging.Events;
using Neudesic.IdentityServer.Admin.BusinessLogic.Identity.Dtos.Identity;

namespace Neudesic.IdentityServer.Admin.BusinessLogic.Identity.Events.Identity
{
    public class RoleUsersRequestedEvent<TUsersDto> : AuditEvent
    {
        public TUsersDto Users { get; set; }

        public RoleUsersRequestedEvent(TUsersDto users)
        {
            Users = users;
        }
    }
}