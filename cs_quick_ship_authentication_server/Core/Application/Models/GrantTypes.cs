﻿using Domain.Common;
using System.Collections.Generic;

namespace Application.Models
{
    public class GrantTypes
    {
        public static IList<string> Code =>
            new[] { AuthorizationGrantTypesEnum.Code.GetEnumDescription() };

        public static IList<string> ClientCredentials =>
            new[] { AuthorizationGrantTypesEnum.ClientCredentials.GetEnumDescription() };

        public static IList<string> RefreshToken =>
            new[] { AuthorizationGrantTypesEnum.RefreshToken.GetEnumDescription() };

        public static IList<string> CodeAndClientCredentials =>
            new[] { AuthorizationGrantTypesEnum.ClientCredentials.GetEnumDescription(), 
                AuthorizationGrantTypesEnum.Code.GetEnumDescription() };
    }
}
