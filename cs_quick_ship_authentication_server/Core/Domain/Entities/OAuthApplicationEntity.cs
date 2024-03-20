﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table("OAuthApplications", Schema = "OAuth")]
    public class OAuthApplicationEntity
    {
        [Key]
        public int ApplicationId { get; set; }
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
      //  public string[] AllowedScopes { get; set; }
        public string ClientUri { get; set; }
        public string RedirectUris { get; set; }
        public string ClientName { get; set; }
        public bool IsActive { get; set; }
        public string AllowedScopes { get; set; }
        public bool UsePkce { get; set; }
        public string GrantTypes { get; set; }
    }
}
