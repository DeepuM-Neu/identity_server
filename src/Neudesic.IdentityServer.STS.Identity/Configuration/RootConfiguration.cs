using Neudesic.IdentityServer.Shared.Configuration.Configuration.Identity;
using Neudesic.IdentityServer.STS.Identity.Configuration.Interfaces;

namespace Neudesic.IdentityServer.STS.Identity.Configuration
{
    public class RootConfiguration : IRootConfiguration
    {      
        public AdminConfiguration AdminConfiguration { get; } = new AdminConfiguration();
        public RegisterConfiguration RegisterConfiguration { get; } = new RegisterConfiguration();
    }
}