﻿using Neudesic.IdentityServer.Admin.BusinessLogic.Shared.Dtos.Common;
using System.Collections.Generic;

namespace Neudesic.IdentityServer.Admin.BusinessLogic.Identity.Dtos.Identity.Interfaces
{
    public interface IUserRolesDto : IBaseUserRolesDto
    {
        string UserName { get; set; }
        List<SelectItemDto> RolesList { get; set; }
        List<IRoleDto> Roles { get; }
        int PageSize { get; set; }
        int TotalCount { get; set; }
    }
}
