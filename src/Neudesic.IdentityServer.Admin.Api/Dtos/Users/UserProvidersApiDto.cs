using System.Collections.Generic;

namespace Neudesic.IdentityServer.Admin.Api.Dtos.Users
{
    public class UserProvidersApiDto<TKey>
    {
        public UserProvidersApiDto()
        {
            Providers = new List<UserProviderApiDto<TKey>>();
        }

        public List<UserProviderApiDto<TKey>> Providers { get; set; }
    }
}