﻿namespace Neudesic.IdentityServer.Shared.Configuration.Configuration.Identity
{
    public class LoginConfiguration
    {
        public LoginResolutionPolicy ResolutionPolicy { get; set; } = LoginResolutionPolicy.Username;
    }
}