using Skoruba.AuditLogging.Events;
using Neudesic.IdentityServer.Admin.BusinessLogic.Identity.Dtos.Identity;

namespace Neudesic.IdentityServer.Admin.BusinessLogic.Identity.Events.Identity
{
    public class UserRequestedEvent<TUserDto> : AuditEvent
    {
        public TUserDto UserDto { get; set; }

        public UserRequestedEvent(TUserDto userDto)
        {
            UserDto = userDto;
        }
    }
}