using Skoruba.AuditLogging.Events;

namespace Neudesic.IdentityServer.Admin.BusinessLogic.Identity.Events.Identity
{
    public class UserRoleSavedEvent<TUserRolesDto> : AuditEvent
    {
        public TUserRolesDto Role { get; set; }

        public UserRoleSavedEvent(TUserRolesDto role)
        {
            Role = role;
        }
    }
}