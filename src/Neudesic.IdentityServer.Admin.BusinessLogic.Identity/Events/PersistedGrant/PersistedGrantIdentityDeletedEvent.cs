﻿using Skoruba.AuditLogging.Events;

namespace Neudesic.IdentityServer.Admin.BusinessLogic.Identity.Events.PersistedGrant
{
    public class PersistedGrantIdentityDeletedEvent : AuditEvent
    {
        public string Key { get; set; }

        public PersistedGrantIdentityDeletedEvent(string key)
        {
            Key = key;
        }
    }
}