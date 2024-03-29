﻿namespace Domain.Configuration
{
    public class OAuthServerOptions
    {
        /// <summary>
        /// This indicate which provider our identity provider will use
        /// InMemory Or BackStore
        /// </summary>
        public string Provider { get; set; }

        /// <summary>
        /// If is not availabe so, no user can login or register
        /// This will shout down the application domain
        /// </summary>
        public bool IsAvaliable { get; set; }

        /// <summary>
        /// This is the uri of the identity provider
        /// </summary>
        public string IDPUri { get; set; }

    }
}
