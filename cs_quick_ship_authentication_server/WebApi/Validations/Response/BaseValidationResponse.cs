﻿/*
                        GNU GENERAL PUBLIC LICENSE
                          Version 3, 29 June 2007
 Copyright (C) 2022 Mohammed Ahmed Hussien babiker Free Software Foundation, Inc. <https://fsf.org/>
 Everyone is permitted to copy and distribute verbatim copies
 of this license document, but changing it is not allowed.
 */

namespace cs_quick_ship_authentication_server.Validation.Response
{
    public abstract class BaseValidationResponse
    {
        public bool Succeeded { get; set; }
        public string Error { get; set; } = string.Empty;
        public string ErrorDescription { get; set; }
        public bool HasError => !string.IsNullOrEmpty(Error);
    }
}
