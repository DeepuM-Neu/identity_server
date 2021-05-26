using System.Collections.Generic;

namespace Neudesic.IdentityServer.STS.Identity.Configuration
{
    public class CultureConfiguration
    {
        public static readonly string[] AvailableCultures = { "en" };
        public static readonly string DefaultRequestCulture = "en";

        public List<string> Cultures { get; set; }
        public string DefaultCulture { get; set; } = DefaultRequestCulture;
    }
}
