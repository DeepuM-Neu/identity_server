param([string] $version, [string] $key)

dotnet nuget push ./packages/Neudesic.IdentityServer.Admin.BusinessLogic.$version.nupkg -k $key -s https://api.nuget.org/v3/index.json
dotnet nuget push ./packages/Neudesic.IdentityServer.Admin.BusinessLogic.Identity.$version.nupkg -k $key -s https://api.nuget.org/v3/index.json
dotnet nuget push ./packages/Neudesic.IdentityServer.Admin.BusinessLogic.Shared.$version.nupkg -k $key -s https://api.nuget.org/v3/index.json

dotnet nuget push ./packages/Neudesic.IdentityServer.Admin.EntityFramework.$version.nupkg -k $key -s https://api.nuget.org/v3/index.json
dotnet nuget push ./packages/Neudesic.IdentityServer.Admin.EntityFramework.Extensions.$version.nupkg -k $key -s https://api.nuget.org/v3/index.json
dotnet nuget push ./packages/Neudesic.IdentityServer.Admin.EntityFramework.Identity.$version.nupkg -k $key -s https://api.nuget.org/v3/index.json
dotnet nuget push ./packages/Neudesic.IdentityServer.Admin.EntityFramework.Shared.$version.nupkg -k $key -s https://api.nuget.org/v3/index.json

dotnet nuget push ./packages/Neudesic.IdentityServer.Admin.EntityFramework.Configuration.$version.nupkg -k $key -s https://api.nuget.org/v3/index.json
dotnet nuget push ./packages/Neudesic.IdentityServer.Shared.Configuration.$version.nupkg -k $key -s https://api.nuget.org/v3/index.json

dotnet nuget push ./packages/Neudesic.IdentityServer.Admin.UI.$version.nupkg -k $key -s https://api.nuget.org/v3/index.json
