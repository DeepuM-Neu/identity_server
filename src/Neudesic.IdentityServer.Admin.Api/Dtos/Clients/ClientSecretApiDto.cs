using System;
using System.ComponentModel.DataAnnotations;
using Neudesic.IdentityServer.Admin.EntityFramework.Helpers;

namespace Neudesic.IdentityServer.Admin.Api.Dtos.Clients
{
    public class ClientSecretApiDto
    {
        [Required]
        public string Type { get; set; } = "SharedSecret";

        public int Id { get; set; }

        public string Description { get; set; }

        [Required]
        public string Value { get; set; }

        public string HashType { get; set; }

        public HashType HashTypeEnum => Enum.TryParse(HashType, true, out HashType result) ? result : Neudesic.IdentityServer.Admin.EntityFramework.Helpers.HashType.Sha256;

        public DateTime? Expiration { get; set; }
    }
}