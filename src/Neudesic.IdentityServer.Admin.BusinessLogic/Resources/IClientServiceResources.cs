using Neudesic.IdentityServer.Admin.BusinessLogic.Helpers;

namespace Neudesic.IdentityServer.Admin.BusinessLogic.Resources
{
    public interface IClientServiceResources
    {
        ResourceMessage ClientClaimDoesNotExist();

        ResourceMessage ClientDoesNotExist();

        ResourceMessage ClientExistsKey();

        ResourceMessage ClientExistsValue();

        ResourceMessage ClientPropertyDoesNotExist();

        ResourceMessage ClientSecretDoesNotExist();
    }
}
