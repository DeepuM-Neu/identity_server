using Neudesic.IdentityServer.Admin.BusinessLogic.Identity.Dtos.Identity.Interfaces;

namespace Neudesic.IdentityServer.Admin.BusinessLogic.Identity.Dtos.Identity.Base
{
    public class BaseUserProviderDto<TUserId> : IBaseUserProviderDto
    {
        public TUserId UserId { get; set; }

        object IBaseUserProviderDto.UserId => UserId;
    }
}