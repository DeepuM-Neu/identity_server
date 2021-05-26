using System.ComponentModel.DataAnnotations;
using Neudesic.IdentityServer.Admin.BusinessLogic.Identity.Dtos.Identity.Base;
using Neudesic.IdentityServer.Admin.BusinessLogic.Identity.Dtos.Identity.Interfaces;

namespace Neudesic.IdentityServer.Admin.BusinessLogic.Identity.Dtos.Identity
{
    public class RoleClaimDto<TKey> : BaseRoleClaimDto<TKey>, IRoleClaimDto
    {
        [Required]
        public string ClaimType { get; set; }


        [Required]
        public string ClaimValue { get; set; }
    }
}
